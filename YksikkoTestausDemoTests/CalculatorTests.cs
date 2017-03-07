using Microsoft.VisualStudio.TestTools.UnitTesting;
using YksikkoTestausDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YksikkoTestausDemo.Tests
{
  [TestClass()]
  public class CalculatorTests
  {
    [TestMethod()]
    public void AddTest()
    {
      //AAA-periaate
      //arrange = alustus, valmistelu
      Calculator calc = new Calculator();
      int n1 = 5;
      int n2 = 8;
      int expected = 13;
      //act=toimi
      int actual = calc.Add(n1, n2);
      //assert=tarkistus
      Assert.AreEqual(expected, actual);
    }
    [TestMethod()]
    public void AddTestZero()
    {
      //AAA-periaate
      //arrange = alustus, valmistelu
      Calculator calc = new Calculator();
      int n1 = 0;
      int n2 = 0;
      int expected = 0;
      //act=toimi
      int actual = calc.Add(n1, n2);
      //assert=tarkistus
      Assert.AreEqual(expected, actual);
    }

    [TestMethod()]
    public void MultiplyTest()
    {
      //AAA-periaate
      //arrange = alustus, valmistelu
      Calculator calc = new Calculator();
      int n1 = 5;
      int n2 = 8;
      int expected = 40;
      //act=toimi
      int actual = calc.Multiply(n1, n2);
      //assert=tarkistus
      Assert.AreEqual(expected, actual);

    }

    [TestMethod()]
    public void DivideTest()
    {
      //arrange = alustus, valmistelu
      Calculator calc = new Calculator();
      int n1 = 20;
      int n2 = 4;
      int expected = 5;
      //act=toimi
      int actual = calc.Divide(n1, n2);
      //assert=tarkistus
      Assert.AreEqual(expected, actual);
    }
  [TestMethod]
  [ExpectedException(typeof(DivideByZeroException), "nollalla jako")]
  public void JaaNollallaTest()
    {
      //arrange = alustus, valmistelu
      Calculator calc = new Calculator();
      int n1 = 2;
      int n2 = 0;
      int expected = 1;
      //act=toimi
      int actual = calc.Divide(n1, n2);
      //assert=tarkistus
      Assert.AreEqual(expected, actual);

    }
  }
}