using System;


class ClientCode
{
    static void Main(string[] args)
    {
        Figures.FigureAreaCalculatorAPI calculator = new();

        calculator.ChangeFigureType(Figures.Type.Triangle);
        Console.WriteLine(
            calculator.CalculateArea(new Figures.AreaParameter(4f, 5.7f, 9.3f)) // TODO: simplify
            );
        calculator.ChangeFigureType(Figures.Type.Circle);
        Console.WriteLine(
           calculator.CalculateArea(new Figures.AreaParameter(1f)) // TODO: simplify
           );
    }
}
