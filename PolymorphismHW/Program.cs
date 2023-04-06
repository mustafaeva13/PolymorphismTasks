using System;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Channels;
#region(Task1-2)
namespace PolymorphismHW
{
    partial class Program
    {
        static void Main(string[] args)
        {
            //Square square = new Square();
            //square.CalculateArea(100, 100);

            //Triangle triangle = new Triangle();
            //triangle.CalculateArea(20, 30);

            //Circle circle = new Circle();
            //circle.CalculateArea(2, 3);

            //IPlayer player = (IPlayer)GetPlayer();
            //IPlayer player2 = (IPlayer)GetPlayer2();
            //player.Play();
            //player2.Play();


        }
          


        



    }
 }
#endregion

#region(Task3)
namespace Employee_Management_System
{

    ////Task3
    //Tapşırıq: "İşçilərin idarəetmə sistemi" konsol proqramını yaratmaq.
    // Təsvir: Menecer, proqramlaşdırıcı və dizayner kimi fərqli vəzifələrdə işçiləri
    // idarə edən konsol tətbiqi yaradın. Əmək haqqı və tətil günlərinin
    // hesablanması üçün interfeysləri həyata keçirin və müxtəlif növ işçilərlə
    // işləmək üçün polimorfizmi istifadə edin.
     interface  IEmployee
    {
        static void Main(string[] args )
        {
            Manager manager = new Manager();
            manager.Salary();

        }
        public void Salary()
        {
            string name;
            double Salary, holiday;
            Console.WriteLine("Input Employee Name:");
                name=(Console.ReadLine());

            Console.WriteLine("Input Salary: ");
            Salary=Convert.ToDouble(name);

            if(Salary<1000 && Salary >= 0)
            {
                Console.WriteLine("Name:" + name);
            }
            else if (Salary >= 1000 && Salary>=0)
            {
                holiday = Salary + 500;
                Console.WriteLine("Name: " + name);
            }
            else
            {
                Console.WriteLine("hecbiri: ");
            }
            Console.ReadKey();
        }
        public void Holiday()
        {
            Console.WriteLine("Holiday days:");
        }
        class Manager : IEmployee
        {
            internal void Salary()
            {
                throw new NotImplementedException();
            }
        }

        class Programist:IEmployee
        {
            
        }
        class Designer : IEmployee
        {

        }
    }
}
#endregion


namespace TransportPark
{
//   Tapşırıq: "Nəqliyyat parkı" konsol proqramını yaratmaq.

//Təsvir: Avtomobil, velosiped və motosiklet kimi müxtəlif növ nəqliyyat
//vasitələrini idarə edən konsol tətbiqi yaradın.Sürət, yanacaq sərfi və
//səyahət dəyərinin müəyyənləşdirilməsi üçün interfeysləri həyata keçirin və
//müxtəlif növ nəqliyyat vasitələri ilə işləmək üçün polimorfizmi istifadə edin.

    interface  ITransport
    {
        static void Main(string[] args)
        {

        }

        public void Speed()
        {

        }

        public void FuelConsumption()
        {

        }

        public void CostofTravel()
        {

        }

        class Car:ITransport
        {

        }
        class Byc:ITransport
        {

        }
        class Motobyc:ITransport
        {

        }
    }
   
    
}