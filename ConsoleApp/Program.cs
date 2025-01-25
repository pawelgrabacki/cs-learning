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

            int x = 10;             //whole number
            double y = 2.32;        //foating point number
            double c = 4.34354;
            bool z = true;          //stores value either true or false
            char j = 'a';           //single character
            string s = "test";      //multiple characters stored in array
            string divider = "------------------------------------------------------------------------";

            //type casting----------------------------------------

            int g = (int)y; //manual casting  explicit
          //  int h = c;      //automatic casting i need to check it out:)


            //converting using functions
            int k = Convert.ToInt32(c);

                Console.WriteLine(k);
          


            Console.WriteLine("This value chanhed its type from double to int (manual) "+g);
            //Console.WriteLine("This value chanhed its type from double to int(automatic) "+h);
            Console.WriteLine("This value chanhed its type from double to int (By using built in methods) " + k);



            //loops---------------------------------------------------

            Console.WriteLine("Loops\n" + divider);//also includes concatenation

            for (int i = 1; i<=10; i++)  //for loop performs opertions specified number of times
            {
                Console.WriteLine("For loop with displayed iterator "+i);

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
                
            }while (n <= 10);

            


          
        }
    }
}
