/*
 * <root>
<kissat>
<kissa>Mesi</kissa>
<kissa>Tassu</kissa>
</kissat>
<koirat>
<koira>Arska</koira>
<koira>Bella</koira>
</koirat>
</root>
 * */
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLDemo2
{
  class Program
  {
    static void ReadDemoXML(string file)
    {
      DataSet ds = new DataSet();
      ds.ReadXml(file);
      //kerrotaan taulujen nimet
      Console.WriteLine("Löytyi {0} taulua", ds.Tables.Count);
      foreach (DataTable dt in ds.Tables)
      {
        Console.WriteLine("- taulu {0} ", dt.TableName);
      }
      Console.WriteLine("Löytyi {0} relaatiota", ds.Relations.Count);
      if (ds.Relations.Count == 2)
      {
        DataTable first = ds.Relations[0].ParentTable;
        DataTable firstChild = ds.Relations[0].ChildTable;
        Console.WriteLine("taulun {0} lapsi on {1} ", first.TableName, firstChild.TableName);
        DataTable second = ds.Relations[1].ParentTable;

        Console.WriteLine("taulun {0} lapsi on {1} ", second.TableName, ds.Relations[1].ChildTable.TableName);
        //  foreach (DataRow row in first.Rows)
        //    Console.WriteLine(row["controlID"] + " " + row["rolesEnabled"] + " " + row["rolesVisible"]);
      }
      Console.ReadLine();
    }
    static void Main(string[] args)
    {
      ReadDemoXML(@"D:\test.xml");
    }
  }
}
