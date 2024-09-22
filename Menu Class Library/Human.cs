using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu_Class_Library
{
	public class Human
	{
		public string Name { set; get; }

		public readonly Gender Gender;
		public int Age { set; get; }

		public Human(string name, Gender gender, int age)
		{
			Name = name;
			Gender = gender;
			Age = age;
		}

		public override string ToString() => $"Name = {Name} , Gender = {Gender} , Age = {Age} ,";
	}
}
