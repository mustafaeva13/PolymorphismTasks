namespace PolymorphismHW
{
    partial class Program
    {
        class Square : ICalculated
        {
            public void CalculateArea(int a ,int b)
            {
                int area = a * a;
                Console.WriteLine(area);
            }
        }
    }

    }
