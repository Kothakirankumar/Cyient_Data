namespace EMS
{
    class Employee
    {
        //attributes/properties (static or dynamic)
        private string name; // static
        public string Name{
           get => name;
           set {
               if(value.Length!=0)
                name = value;
               }
        }
        short id; // static
        decimal salary; //dynamic
        // Constructors
        public Employee(){ // default constructor
            name = "Joana";
            id = 103;
            salary = 80.00M;
            System.Console.WriteLine($"Employee name - {name},\n Id - {id},\n Salary - ${salary}/hour");
        }
        public Employee(string name, short id, decimal salary)//parameterised constructor
        {
            this.name=name;
            this.id=id;
            this.salary=salary;
            System.Console.WriteLine($"Employee name - {name},\n Id - {id},\n Salary - ${salary}/hour");
        }
        //Behaviours
        //                           vv                     vv                    vv
        //           Default parameters
       internal string GetDetails(string name = "Jessica", short id = 102, decimal salary = 50.00M){
            return $"Employee name - {name},\n Id - {id},\n Salary - ${salary}/hour";
        }
        public void DoTask(){}
        public void GetSalary(){}
    }
}