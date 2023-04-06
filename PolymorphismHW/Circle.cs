namespace HendesiSekiller
{
    partial class Program
    {
        class Circle : PolymorphismHW.ICalculated
        {
            private int b;
            private double a;

            public double Radius { get; set; }
            public void CalculateArea(int a, int b)
            {
                int area = (int)(Math.PI * a * b);

            }

            public void CalculatePerimeter()
            {
                Console.WriteLine($"Circle areaaa {Math.PI*a*b}");
            }
        }
    }

    }
