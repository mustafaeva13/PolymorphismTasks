namespace PolymorphismHW
{
    partial class Program
    {
        class Triangle : ICalculated
        {
            public void CalculateArea(int a, int b)
            {
                int area = a * b / 2;
                Console.WriteLine(area);
            }
        }
    }

    }
