using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
  interface ICalculator
  {
    int Add(int number1, int number2);
    int Multiply(int number1, int number2);
  }
  public class Calculator : ICalculator
  {

    public int Add(int n1, int n2)
    {
      return n1 + n2;
    }
    public int Multiply(int n1, int n2)
    {
      return n1 * n2;
    }
  }
  class TestCalculator
  {
    static bool TestCalc()
    {
      throw new NotImplementedException();
    }
    static void Main(string[] args)
    {
      try
      {
        TestCalc();
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
      }
    }
  }
}
