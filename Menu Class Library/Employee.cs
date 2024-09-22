using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Text;

namespace Menu_Class_Library
{
    public class Employee : Human
    {
        private static int _id = 0;
        public int Id { get; private set; }
        public decimal Salary { set; get; }

        public Employee( string name , decimal salary , Gender gender , int age) : base(name,gender,age)
        {
            Id = ++_id;
            Salary = salary;
        }
        public void Display()
        {
            Console.WriteLine($"{{\n   Id = {Id}\n   Name = {Name}\n   Age = {Age}\n   Salary = {Salary}\n   Gender = {Gender}\n}},");
        }

		public override string ToString()
		{
            StringBuilder sb = new StringBuilder();
            string basestring = base.ToString();
            sb.Append($"Id = {Id} , ");
            sb.Append(basestring);
            sb.Append($"Salary = {Salary}");
            return sb.ToString();
		}
	}
}
