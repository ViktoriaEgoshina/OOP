class Figure
{
  private double _square;

  public Figure(int side)
  {
    _square = side * side;
  }

  public Figure(int side1, int side2)
  {
    _square = side1 * side2;
  }

  public Figure(int footing, double height)
  {
    _square = footing * height / 2;
  }

  public double Square
  {
    get
    {
      return _square;
    }
  }
}