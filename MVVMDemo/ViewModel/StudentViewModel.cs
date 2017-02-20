using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVMDemo.Model;
using System.Collections.ObjectModel;

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
  }
}
