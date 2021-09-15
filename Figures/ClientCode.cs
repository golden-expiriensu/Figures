using System;


class ClientCode
{
    static void Main(string[] args)
    {
        Figures.FigureAreaCalculatorAPI calculator = new(Figures.Type.Triangle);

        Console.WriteLine(
            calculator.CalculateArea(new Figures.AreaParameter(4f, 5.7f, 9.3f)) 
            );

        calculator.ChangeFigureType(Figures.Type.Circle);
        Console.WriteLine(
           calculator.CalculateArea(new Figures.AreaParameter(1f)) 
           );

        calculator.ChangeFigureType(Figures.Type.Squad);
        Console.WriteLine(
           calculator.CalculateArea(new Figures.AreaParameter(1.2f)) 
           );

        calculator.ChangeFigureType(Figures.Type.Rectangle);
        Console.WriteLine(
           calculator.CalculateArea(new Figures.AreaParameter(1.2f, 5f)) 
           );
    }
}
