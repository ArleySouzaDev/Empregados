namespace Funcionarios.Entities
{
    internal class Employee
    {
        public string name { get; set; }
        public int Hours { get; set; }
        public int ValuePerHour { get; set; }

        public Employee(string  name, int hours, double valuePerhour)
        {
            name = name;
            Hours = hours;
            ValuePerHour = ValuePerHour;

        }

        public double Payment()
        {
            return Hours *ValuePerHour;
        }
    }
}
