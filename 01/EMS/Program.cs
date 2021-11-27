using System;
namespace EMS
{
    class Program
    {
        static void Main(string[] args)
        {
           InstantiateEmployee();
        }
        static void InstantiateEmployee(){
            // create object of Employee class
            Employee obj = new Employee("Josh",105,95.00M); // default or instance constructor     
            obj.Name = "Bill";   
            System.Console.WriteLine(obj.Name);                      
                        //               using named parameter      
                        //                    vv     
            Console.WriteLine(obj.GetDetails(salary: 75.00M)); 
            
        }
    }
}
