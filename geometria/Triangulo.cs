public class Triangulo : Forma
{
    public double Base { get; set; }
    public double Altura { get; set; }

    public Triangulo(double b, double h)
    {
        Base = b;
        Altura = h;
    }

    public override double CalcularArea()
    {
        return (Base * Altura) / 2;
    }
}
