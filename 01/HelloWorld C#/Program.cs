//single line comment
//Pre-defined namespace
using System;
//User defined namespace
namespace HelloWorld
{
    enum Days
    {
        Monday=1, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    }
    //Type (class, interface, structs, enums, delegates)
    class Program
    {
        //Type member
        static void Main(string[] args)// main entry point of the program
        {
            //InputOutput();
            //TypeConversion();
            //DriversLicense();
            //Grades();
            //DisplayMeasurment();
            DisplayNumbers();
        }
        static void InputOutput(){
            string name;
            short age;
            Console.Write("Please enter your name ");
            name = Console.ReadLine(); // String always allows user to take inout in string form                 
            //Take input from user in string format
            Console.Write("Please enter your age ");
            age = Convert.ToInt16(Console.ReadLine());
            //Console.WriteLine($"Hello {name}"); // extrapolated string
            //Console.WriteLine("Hello "+ name); // concatenated string
            Console.WriteLine("Hello {0}! How are you? Your age is {1}", name, age + 1); // using placeholder
            Console.WriteLine("Today is " + DayOfWeek.Wednesday);
        }
        static void TypeConversion(){
            byte x=10; // 1 byte 
            int y = x; // 4 byte, implicit type conversion
            int b=255;
            sbyte a= (sbyte)b; // casting or explicit conversion
            Console.WriteLine(a);
        }

        static void DriversLicense(){
            //Selections
            Console.Write("Please enter your age ");
            short age = Convert.ToInt16(Console.ReadLine());
            if(age<18){
                Console.WriteLine("Not eigible for driver's license application");
                Console.WriteLine($"Please apply after {18-age} years");
            }
            else
                Console.WriteLine($"Congrats! your age is {age} years and you are eligible to apply for driver's license");
        }
        static void Grades(){
            Console.WriteLine("please enter your total marks obtained");
            short marks = Int16.Parse(Console.ReadLine());
            if(marks>90 && marks<=100)
                Console.WriteLine($"Congrats! you passed with flying colors, your grade is A and your score is {marks}" );
            else if(marks>80 && marks<=90)
                Console.WriteLine($"Congrats! you passed with flying colors, your grade is B and your score is {marks}");
            else if(marks>60 && marks<=80)
                Console.WriteLine($"Congrats! you passed with flying colors, your grade is C and your score is {marks}");
            else if(marks>40 && marks<=60)
                Console.WriteLine($"Congrats! you passed with flying colors, your grade is D and your score is {marks}");
            else if(marks>30 && marks<=40)
                Console.WriteLine($"Congrats! you just passed, your grade is E and your score is {marks}");
            else 
                Console.WriteLine($"Sorry! you failed grade is F and your score is {marks}");           
            
        }
        static void DisplayMeasurment(){
            int measurement = Int32.Parse(Console.ReadLine());
            switch (measurement)
            {
                case < 0:
                case > 100:
                    Console.WriteLine($"Measure value is {measurement}; out of acceptable range");    
                    break;  
                default:
                    Console.WriteLine($"Measured value is {measurement}");
                    break;
            }
        }
        static void DisplayNumbers(){
            //short s = 0;
            /*do
            {
              Console.Write(s+ " ");
              s++;
            } while (s<0);*/
            
            /*while (s<10)
            {
                 Console.Write(s+ " ");
                 s++; 
            }*/

            for (short s = 0; s < 10; s++)
            {
                Console.Write(s+ " ");
            }
            for(;;){

            }// infinite loop
        }
    }
}
