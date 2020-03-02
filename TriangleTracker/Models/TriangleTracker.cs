namespace TriangleTracker.Models
{
  public class Triangle
  {
    public bool CheckTriangle(int sideA, int sideB, int sideC)
    {
      if (sideA > (sideB + sideC) || sideB > (sideA + sideC) || sideC > (sideA + sideB))
      {
        return true;
      }
      else if ((sideA != sideB) && (sideA != sideC) && (sideB != sideC))
      {
        return true;
      } 
      else if ((sideA == sideB) && (sideA == sideC))
      {
        return true;
      }
      else if ((sideA == sideB) || (sideA == sideC) || (sideB == sideC))
      {
        return true;
      }
      return false;
    }
  }
}