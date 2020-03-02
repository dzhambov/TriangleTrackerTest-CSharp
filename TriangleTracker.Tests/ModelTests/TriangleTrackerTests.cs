using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleTracker.Models;

namespace TriangleTracker.Tests
{
  [TestClass]
  public class TriangleTests
  {

    [TestMethod]
    public void CheckTriangle_CheckIfIsTriangle_True()
    {
      Triangle testTriangle = new Triangle();
      Assert.AreEqual(true, testTriangle.CheckTriangle(2,3,10));
    }

    [TestMethod]
    public void CheckTriangle_CheckIfIsScaleneTriangle_True()
    {
      Triangle testTriangle = new Triangle();
      Assert.AreEqual(true, testTriangle.CheckTriangle(3,4,5));
    }

    [TestMethod]
    public void CheckTriangle_CheckIfIsEquilateralTriangle_True()
    {
      Triangle testTriangle = new Triangle();
      Assert.AreEqual(true, testTriangle.CheckTriangle(5,5,5));
    }

    [TestMethod]
    public void CheckTriangle_CheckIfIsIsoscelesTriangle_True()
    {
      Triangle testTriangle = new Triangle();
      Assert.AreEqual(true, testTriangle.CheckTriangle(4,4,6));
    }
  }
}