using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu_Class_Library
{
	public class SortArrayWithAgeAsc : IComparer
	{
		public int Compare(object? x, object? y)
		{
			Employee emp1 = x as Employee;
			Employee emp2 = y as Employee;
			return emp1.Age.CompareTo(emp2.Age);
		}
	}

	public class SortArrayWithAgeDsc : IComparer
	{
		public int Compare(object? x, object? y)
		{
			Employee emp1 = x as Employee;
			Employee emp2 = y as Employee;
			return emp2.Age.CompareTo(emp1.Age);
		}
	}

	public class SortArrayWithNameAsc : IComparer
	{
		public int Compare(object? x, object? y)
		{
			Employee emp1 = x as Employee;
			Employee emp2 = y as Employee;
			return emp1.Name.ToLower().CompareTo(emp2.Name.ToLower());
		}
	}

	public class SortArrayWithNameDsc : IComparer
	{
		public int Compare(object? x, object? y)
		{
			Employee emp1 = x as Employee;
			Employee emp2 = y as Employee;
			return emp2.Name.ToLower().CompareTo(emp1.Name.ToLower());
		}
	}

	public class SortArrayWithIdAsc : IComparer
	{
		public int Compare(object? x, object? y)
		{
			Employee emp1 = x as Employee;
			Employee emp2 = y as Employee;
			return emp1.Id.CompareTo(emp2.Id);
		}
	}

	public class SortArrayWithIdDsc : IComparer
	{
		public int Compare(object? x, object? y)
		{
			Employee emp1 = x as Employee;
			Employee emp2 = y as Employee;
			return emp2.Id.CompareTo(emp1.Id);
		}
	}

}
