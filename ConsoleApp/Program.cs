using System.Linq.Expressions;
using System.Numerics;

namespace ConsoleApp
{
    internal class Program
    {








        static void Main(string[] args)


        {

            //this is single line coment

            /*
             this is multiline comment
             */


            //data types

            int x = 1;             //whole number
            double y = 2.32;        //foating point number
            double c = 4.34354;
            bool z = true;          //stores value either true or false
            char j = 'a';           //single character
            string s = "test";      //multiple characters stored in array
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9 }; //stores multiple values of same type
            string divider = "------------------------------------------------------------------------";

            //type casting----------------------------------------

            int g = (int)y; //manual casting  explicit
                            //  int h = c;      //automatic casting i need to check it out:)


            //converting using functions
            int k = Convert.ToInt32(c);

            Console.WriteLine(k);



            Console.WriteLine("This value chanhed its type from double to int (manual) " + g);
            //Console.WriteLine("This value chanhed its type from double to int(automatic) "+h);
            Console.WriteLine("This value chanhed its type from double to int (By using built in methods) " + k);



            //loops---------------------------------------------------

            Console.WriteLine("Loops\n" + divider);//also includes concatenation

            for (int i = 1; i <= 10; i++)  //for loop performs opertions specified number of times
            {
                Console.WriteLine("For loop with displayed iterator " + i);

            }
            int n = 0;
            while (n <= 10) //while loop continues to loop if specified condition stays true
            {
                Console.WriteLine("While loop iterates 10 times in this case " + n);
                n++;
            }
            do
            {
                Console.WriteLine("Do while executes at least once");

            } while (n <= 10);


            foreach (int item in a)// loop designed to operate on arrays and its items
            {
                Console.WriteLine(item);
            }




            switch (x) //switch case statement allows to execute choosen case/code
            {
                case 1:
                    Console.WriteLine("Case " + x);
                    break;

                case 10:
                    Console.WriteLine("Case " + x);
                    break;


            }



            if (x == 1 || x == 5) //allows to check if condition or conditions are true and based on that executes code
            {
                Console.WriteLine("Hello from if statement \n" + x);
            }
            else
            {
                Console.WriteLine("Hello from if statement " + x);
            }


            //instanciating object and accesing their methods

            Console.WriteLine("OOP \n" + divider);

            Samolot samolot = new Samolot(10, 20, 300, "Testowy Samolot");
            samolot.DisplayProperties();

            samolot.SetName("F16");
            samolot.SetVmax(1500);
            samolot.DisplayProperties();

            Odrzutowiec odrzutowiec = new Odrzutowiec(15, 25, 2500, "F22");
            odrzutowiec.DisplayProperties();
            odrzutowiec.IncreaseSpeed();

            Turbosmigłowy turbo = new Turbosmigłowy(12, 18, 500, "Boeing");
            turbo.DisplayProperties();
            turbo.DestroyItself();



        }
        //OOP inherinence tests

        public class Samolot
        {
            private int dlugosc;
            private int szerokosc;
            private int vmax;
            private string name;

            // Constructor
            public Samolot(int i, int o, int p, string name)
            {
                this.dlugosc = i;
                this.szerokosc = o;
                this.vmax = p;
                this.name = name;
            }

            // Methods
            public void SetName(string u)
            {
                this.name = u;
            }

            public void SetVmax(int k)
            {
                this.vmax = k;
            }

            public void DisplayProperties()
            {
                Console.WriteLine("Maksymalna prędkość: " + vmax);
                Console.WriteLine("Szerokość samolotu: " + szerokosc);
                Console.WriteLine("Długość samolotu: " + dlugosc);
                Console.WriteLine("Nazwa: " + name);
            }
        }

        public class Odrzutowiec : Samolot
        {
            
            public Odrzutowiec(int i, int o, int p, string name) : base(i, o, p, name)
            {
            }

            public void IncreaseSpeed()
            {
                Console.WriteLine("Increased speed");
            }
        }

        public class Turbosmigłowy : Samolot
        {
            public Turbosmigłowy(int i, int o, int p, string name) : base(i, o, p, name)
            {
            }

            public void DestroyItself()
            {
                Console.WriteLine("Destroyed itself");
            }


            //file reading
            string path = "C:\\Users\\pawgr\\source\\repos\\pawelgrabacki\\cs-learning\\ConsoleApp\\identifiers.txt";

            string readText = File.ReadAllText(path);
            Console.WriteLine(readText);


        }
    }
}
