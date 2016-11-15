namespace Triangle.Objects
{
  public class TriangleVariables
  {
    private int _sideA;
    private int _sideB;
    private int _sideC;
    private int _outputTriangle;

    public int GetSideA()
    {
      return _sideA;
    }
    public int GetSideB()
    {
      return _sideB;
    }
    public int GetSideC()
    {
      return _sideC;
    }
    public void SetSideA(int newSideA)
    {
      _sideA = newSideA;
    }
    public void SetSideB(int newSideB)
    {
      _sideB = newSideB;
    }
    public void SetSideC(int newSideC)
    {
      _sideC = newSideC;
    }
    public bool TriangleChecker()
    {
      if (_sideA + _sideB <= _sideC || _sideA + _sideC <= _sideB || _sideB + _sideC <= _sideA)
      {
        return false;
      }
      else
      {
        return true;
      }
    }
    public bool ScaleneChecker()
    {
      if (_sideA != _sideB && _sideA != _sideC && _sideB != _sideC)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
    public bool EquilateralChecker()
    {
      if (_sideA == _sideB && _sideA == _sideC)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
    public bool IsoscelesChecker()
    {
      if (_sideA == _sideB || _sideA == _sideC || _sideB == _sideC)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
    public string TriangleTypeChecker()
    {
      if (!TriangleChecker())
      {
        return "Not a triangle";
      }
      else if (ScaleneChecker())
      {
        return "Scalene Triangle";
      }
      else if (EquilateralChecker())
      {
        return "Equilateral Triangle";
      }
      else if (IsoscelesChecker())
      {
        return "Isoscelese Triangle";
      }
      else
      {
        return "error.";
      }
    }
  }
}
