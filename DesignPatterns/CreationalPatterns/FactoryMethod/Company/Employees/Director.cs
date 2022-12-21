namespace DesignPatterns.CreationalPatterns.FactoryMethodPatterns.Company.Employees
{
    public class Director : Manager
    {
        private string DirectedBranch { get; }

        public Director(string name, int salary, string responsibleDepartment, string directedBranch) : base(name, salary, responsibleDepartment)
        {
            DirectedBranch = directedBranch;
        }

        public override void Work()
        {
            Console.WriteLine("Director is working.");
        }

        public string GetManagedBranch()
        {
            return DirectedBranch;
        }

        public void DirectProject()
        {
            Console.WriteLine("Directing project.");
        }
    }
}