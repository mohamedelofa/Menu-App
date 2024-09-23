using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu_Class_Library
{
	public class SortArrayWithAgeAsc : IComparer<Employee>
	{
		//public int Compare(object? x, object? y)
		//{
		//	Employee emp1 = x as Employee;
		//	Employee emp2 = y as Employee;
		//	return emp1.Age.CompareTo(emp2.Age);
		//}

		public int Compare(Employee? x, Employee? y)
		{
			return x.Age.CompareTo(y.Age);
		}
	}

	public class SortArrayWithAgeDsc : IComparer<Employee>
	{
		//public int Compare(object? x, object? y)
		//{
		//	Employee emp1 = x as Employee;
		//	Employee emp2 = y as Employee;
		//	return emp2.Age.CompareTo(emp1.Age);
		//}

		public int Compare(Employee? x, Employee? y)
		{
			return y.Age.CompareTo(x.Age);
		}
	}

	public class SortArrayWithNameAsc : IComparer<Employee>
	{
		//public int Compare(object? x, object? y)
		//{
		//	Employee emp1 = x as Employee;
		//	Employee emp2 = y as Employee;
		//	return emp1.Name.ToLower().CompareTo(emp2.Name.ToLower());
		//}

		public int Compare(Employee? x, Employee? y)
		{
			return x.Name.ToLower().CompareTo(y.Name.ToLower());
		}
	}

	public class SortArrayWithNameDsc : IComparer<Employee>
	{
		//public int Compare(object? x, object? y)
		//{
		//	Employee emp1 = x as Employee;
		//	Employee emp2 = y as Employee;
		//	return emp2.Name.ToLower().CompareTo(emp1.Name.ToLower());
		//}

		public int Compare(Employee? x, Employee? y)
		{
			return y.Name.ToLower().CompareTo(x.Name.ToLower());
		}
	}

	public class SortArrayWithIdAsc : IComparer<Employee>
	{
		//public int Compare(object? x, object? y)
		//{
		//	Employee emp1 = x as Employee;
		//	Employee emp2 = y as Employee;
		//	return emp1.Id.CompareTo(emp2.Id);
		//}

		public int Compare(Employee? x, Employee? y)
		{
			return x.Id.CompareTo(y.Id);
		}
	}

	public class SortArrayWithIdDsc : IComparer<Employee>
	{
		//public int Compare(object? x, object? y)
		//{
		//	Employee emp1 = x as Employee;
		//	Employee emp2 = y as Employee;
		//	return emp2.Id.CompareTo(emp1.Id);
		//}

		public int Compare(Employee? x, Employee? y)
		{
			return y.Id.CompareTo(x.Id);
		}
	}

}
