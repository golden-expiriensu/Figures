using System;


class ClientCode
{
    static void Main(string[] args)
    {
        Figures.FigureAreaCalculatorAPI calculator = new(Figures.Type.Triangle);
        float triangleArea = calculator.CalculateArea(new Figures.AreaParameter(4f, 5.7f, 9.3f));

        Console.WriteLine(triangleArea);


        // can simlify call in one line with second parameter as figure type
        float squadArea = calculator.CalculateArea(new Figures.AreaParameter(4f), Figures.Type.Squad); 

        Console.WriteLine(squadArea);


        calculator.ChangeFigureType(Figures.Type.Circle);
        float circleArea = calculator.CalculateArea(new Figures.AreaParameter(1f));
        
        Console.WriteLine(circleArea);


        calculator.ChangeFigureType(Figures.Type.Squad);
        squadArea = calculator.CalculateArea(new Figures.AreaParameter(1.2f));
        
        Console.WriteLine(squadArea);


        calculator.ChangeFigureType(Figures.Type.Rectangle);
        float reactangleArea = calculator.CalculateArea(new Figures.AreaParameter(1.2f, 5f));
        
        Console.WriteLine(reactangleArea);
    }
}
