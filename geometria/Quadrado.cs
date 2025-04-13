public class Quadrado : Forma
{
    public double Lado { get; set; }

    public Quadrado(double lado)
    {
        Lado = lado;
    }

    public override double CalcularArea()
    {
        return Lado * Lado;
    }
}
