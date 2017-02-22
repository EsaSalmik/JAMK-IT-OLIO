using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVMDemo.Model;
using System.Collections.ObjectModel;
using MySql.Data.MySqlClient;

namespace MVVMDemo.ViewModel
{
  public class StudentViewModel
  {
    public ObservableCollection<Student> Students
    {
      get;
      set;
    }
    public void LoadStudents()
    {
      ObservableCollection<Student> students = new ObservableCollection<Model.Student>();
      //lisätään esimerkin vuoksi muutama opiskelija, oikeassa sovelluksessa haettaisiin esim tietokannasta
      students.Add(new Student { FirstName = "Kalle", LastName = "Jalkanen", Asioid="A1234" });
      students.Add(new Student { FirstName = "Teppo", LastName = "Testaaja",  Asioid = "B1234" });
      students.Add(new Student { FirstName = "Tomi", LastName = "Töttenström", Asioid = "C1234" });
      students.Add(new Student { FirstName = "Anni", LastName = "Ainokainen", Asioid = "D1234" });
      Students = students;
    }
    //metodi StudentViewModeliin jolla haetaan oppilastiedot mysql-palvemilta
    public void LoadStudentsFromMysql()
    {
      try
      {
        ObservableCollection<Student> students = new ObservableCollection<Student>();
        //luodaan yhteys labranetin mysql-palvelimelle
        string connStr = GetMysqlConnectionString();
        string sql = "SELECT firstname, lastname, asioid FROM student";
        using (MySqlConnection conn = new MySqlConnection(connStr))
        {
          conn.Open();
          using (MySqlCommand cmd = new MySqlCommand(sql, conn))
          using (MySqlDataReader reader = cmd.ExecuteReader())
          {
            while (reader.Read())
            {
              MVVMDemo.Model.Student s = new Model.Student();
              s.FirstName = reader.GetString(0);
              s.LastName = reader.GetString(1);
              s.Asioid = reader.GetString(2);
              students.Add(s);
            }
            Students = students;
          }
        }
      }
      catch
      {
        throw;
      }
    }
    private string GetMysqlConnectionString()
    {
      string pw = "";
      //haetaan salasa App.Config- konfiguraatiotiedostosta
      pw = MVVMDemo.Properties.Settings.Default.passu;
      return string.Format
        ("Data source=mysql.labranet.jamk.fi;Initial Catalog=salesa;user=salesa;password={0}", pw);
    }
  }
}
