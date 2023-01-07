namespace DesignPatterns.CreationalPatterns.FactoryMethod.Concretes
{
    public class Employee
    {
        private string Name { get; }
        private int Salary { get; }

        public Employee(string name, int salary)
        {
            Name = name;
            Salary = salary;
        }

        public virtual void Work()
        {
            Console.WriteLine("Employee is working.");
        }

        public string GetName()
        {
            return Name;
        }

        public int GetSalary()
        {
            return Salary;
        }
    }
}