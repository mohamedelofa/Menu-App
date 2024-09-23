using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Xml.Linq;
using Menu_Class_Library;

namespace Menu_App
{
    internal class Program
    {
        static List<Employee> Employees = new List<Employee>();
        static void Main(string[] args)
        {
            //int id = 0;
            string name = null;
            decimal salary = 0;
            int age = 0;
            int index = 0;
            Gender gender;
            int size = 0;
            string[] Orders = { " New ", " Display ", " Sort "," Search "," Exit " };
            bool loob = true;
            int Xdist = Console.WindowWidth / 2;
            int Ydist = Console.WindowHeight / (Orders.Length + 1);
            int height = 0;
            while(loob)
            {
                Console.Clear();
                for(int i = 0; i < Orders.Length; i++)
                {
                    if(height == i)
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                    }
                    Console.SetCursorPosition(Xdist, (i + 1) * Ydist);
                    Console.WriteLine(Orders[i]);
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                ConsoleKeyInfo KeyInfo = Console.ReadKey();
                switch(KeyInfo.Key)
                {
                    case ConsoleKey.UpArrow:
                        height = height == 0 ? Orders.Length - 1 : height - 1; 
                        break;
                    case ConsoleKey.DownArrow:
                        height = height == Orders.Length - 1 ? 0 : height + 1;
                        break;
                    case ConsoleKey.Home:
                        height = 0;
                        break;
                    case ConsoleKey.Enter:
                        Console.Clear();
                        switch(height)
                        {
                            case 0:
                                Console.Write("Enter number of employees you want to add : ");
                                int n = Convert.ToInt32(Console.ReadLine());
                                //size += n;
                                New(n);
                                break;
                            case 1:
                                if (Employees.Count == 0)
                                {
                                    Console.WriteLine("No employees to display");
                                    Console.Write("Enter any key to return...... : ");
                                    Console.ReadKey();
                                }
                                else
                                    Display(Employees);
                                break;
                            case 2:
								if (Employees.Count == 0)
								{
									Console.WriteLine("No employees to Sort");
									//Console.Write("Enter any key to return...... : ");
									//Console.ReadKey();
								}
                                else
                                {
                                    Console.WriteLine("Choose what you want to sort based on : \n 1.Name \n 2.Age \n 3.Id");
                                    int choice = int.Parse(Console.ReadLine());
                                    Console.Clear();
                                    switch(choice)
                                    {
                                        case 1:
                                            Console.WriteLine("Choose you want Ascending or Descending : \n 1.Ascending \n 2.Descending");
                                            int namechoice = int.Parse(Console.ReadLine());
                                            switch(namechoice)
                                            {
                                                case 1:
                                                    Employees.Sort(new SortArrayWithNameAsc());
                                                    break;
                                                case 2:
													Employees.Sort( new SortArrayWithNameDsc());
													break;
                                            }
											Console.WriteLine("Done........");
											break;
                                        case 2:
											Console.WriteLine("Choose you want Ascending or Descending : \n 1.Ascending \n 2.Descending");
											int agechoice = int.Parse(Console.ReadLine());
											switch (agechoice)
											{
												case 1:
													Employees.Sort(new SortArrayWithAgeAsc());
													break;
												case 2:
													Employees.Sort(new SortArrayWithAgeDsc());
													break;
											}
											Console.WriteLine("Done........");
											break;
                                        case 3:
											Console.WriteLine("Choose you want Ascending or Descending : \n 1.Ascending \n 2.Descending");
											int idchoice = int.Parse(Console.ReadLine());
											switch (idchoice)
											{
												case 1:
													Employees.Sort(new SortArrayWithIdAsc());
													break;
												case 2:
													Employees.Sort(new SortArrayWithIdDsc());
													break;
											}
											Console.WriteLine("Done........");
											break;
                                    }
								}
								Console.Write("Enter any key to return...... : ");
								Console.ReadKey();
								break;
                            case 3:
								if (Employees.Count == 0)
								{
									Console.WriteLine("No employees to search");
									Console.Write("Enter any key to return...... : ");
									Console.ReadKey();
								}
                                else
                                {
                                    List<Employee> searched = Search();
                                    if (searched.Count == 0)
                                    {
                                        Console.WriteLine("No employees exist with this data");
                                        Console.Write("Enter any key to return...... : ");
                                        Console.ReadKey();
                                    }
                                    else
                                        Display(searched);
                                }
								break;
                            case 4:
                                loob = false;
                                break;
                        }
                        break;
                }
            }
        }
        private static void New(int n)
        {
            //Employee[] NewEmployees = new Employee[n];
            //for(int i = 0; i < Employees.Count; i++)
            //{
            //    NewEmployees[i] = Employees[i];
            //}
            int limit = n + Employees.Count;
            for (int i = Employees.Count; i < limit; i++)
            {
                Console.WriteLine("Add New Employee: ");
                //Console.Write($"Enter Id : ");
                //int id = Convert.ToInt32(Console.ReadLine());
                Console.Write($"Enter Name : ");
                string name = Console.ReadLine();
                Console.Write($"Enter Age : ");
                int age = Convert.ToInt32(Console.ReadLine());
                Console.Write($"Enter Salary : ");
                decimal salary = Convert.ToDecimal(Console.ReadLine());
                string g;
                do
                {
                    Console.Write($"Enter Gender(male or female) : ");
                    g = Console.ReadLine().ToLower();
                } while (g != "male" && g != "female");
                Gender gender = g == "male" ? Gender.male : Gender.female;
                //NewEmployees[i] = new Employee(name,salary,gender,age);
                Employees.Add(new Employee(name, salary, gender, age));
            }
            //Employees = NewEmployees;
            Console.WriteLine("Data Saved Successfully");
            Console.Write("Enter any key to return...... : ");
            Console.ReadKey();
        }
        private static void Display(List<Employee> emps)
        {
           
            Console.WriteLine("Display All : ");
            //foreach (Employee emp in Employees)
            //{
            //    //if (emp.Id == 0) continue;
            //    //emp.Display();
            //    Console.WriteLine(emp);
            //}

            emps.Display();
			Console.Write("Enter any key to return...... : ");
			Console.ReadKey();
		}

        private static List<Employee> Search()
        {
            List<Employee> Searched = new List<Employee>();
            Console.WriteLine("Choose what you want to search based on : \n1.Name\n2.Id");
            int choice = int.Parse(Console.ReadLine());
            Console.Clear();
            switch(choice)
            {
                case 1:
                    Console.Write("Enter Name : ");
                    string name = Console.ReadLine();
                    foreach(Employee e in Employees)
                    {
                        if(e.Name.ToLower() == name.ToLower())
                            Searched.Add(e);
                    }
                    break;
                case 2:
					Console.Write("Enter Id : ");
					int id = int.Parse(Console.ReadLine());
					foreach (Employee e in Employees)
					{
						if (e.Id == id)
							Searched.Add(e);
					}
					break;
            }
            return Searched;
        }
    }
}
