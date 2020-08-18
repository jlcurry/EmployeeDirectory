using Gremlin.Net.Process.Traversal;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeDirectory
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Mike Murdock", "Lawyer");
            Person p2 = new Person("Tony Stark", "Ironman");
            Person p3 = new Person("Bruce Banner", "Scientist");

            var ar = new List<Person>();
            bool endApp = false;

            ar.Add(p1);
            ar.Add(p2);
            ar.Add(p3);
            while (!endApp)
            {
                //This is the console app main page
                Console.WriteLine("\nWelcome to the Employee Directory.");
                Console.WriteLine("\nDo you want to: \nA. Insert New Employee \nB. Update Employee \nC. Delete Employee \nD. Display Current Employees \nE. Exit");
                string choice = Console.ReadLine();

                //This is the insert employee name and job title
                if (choice == "A" || choice == "a")
                {
                    Console.Write("\n\nPlease enter the name of the employee you want to add: ");
                    string name = Console.ReadLine();

                    Console.Write("\n\nPlease enter the job title of the employee you want to add: ");
                    var title = Console.ReadLine();

                    var p = new Person(name, title);
                    ar.Add(p);

                    Console.WriteLine("\nYou have entered the employee: {0} \nJob Title: {1}", p.Name, p.Title);

                }
                //this is the update employee name or job title
                if (choice == "B" || choice == "b")
                {
                    Console.WriteLine("\n\nWhich do you want to update: \nA. Employee name \nB. Employee job title");
                    string update = Console.ReadLine();

                    if (update == "A" || update == "a")
                    {
                        Console.Write("\nWhich employee's name do you want to change: ");
                        string changeName = Console.ReadLine();
                       
                        Console.Write("\nWhat is the new name of the employee: ");
                        string newName = Console.ReadLine();

                        
                        var matchingName = ar.FirstOrDefault(i => i.Name == changeName);

                        if (matchingName != null)
                        {
                            matchingName.Name = newName;

                            Console.WriteLine("\nEmployee's name {0} has been changed to {1}", changeName, newName);
                        }

                        else
                        {
                            Console.WriteLine("\nEmployee' name not found.......Goodbye");
                            endApp = true;
                        }

                        
                    }
                    else 
                    {
                        Console.Write("\nWhich employee's job title do you want to change: ");
                        string changeTitle = Console.ReadLine();
                        
                        Console.Write("\nWhat is the new job title of the employee: ");
                        string newTitle = Console.ReadLine();
                        
                        var matchingTitle = ar.FirstOrDefault(i => i.Title == changeTitle);

                        if (matchingTitle != null)
                        {
                            matchingTitle.Title = newTitle;

                            Console.WriteLine("\nEmployee's job title {0} has been changed to {1}", changeTitle, newTitle);
                        }

                        else
                        {
                            Console.WriteLine("\nEmployee's job title not found.......Goodbye");
                            endApp = true;
                        }
                    }
                }
                //this is the delete employee name and job title
                if (choice == "C" || choice == "c")
                {
                    Console.Write("\n\nPlease enter the name of the employee you want to delete: ");
                    string deleteName = Console.ReadLine();

                    Console.Write("\n\nPlease enter the job title of the employee you want to delete: ");
                    string deleteTitle = Console.ReadLine();

                    ar.RemoveAll(s => s.Name == deleteName);

                    Console.WriteLine("\n{0}, {1} has been deleted", deleteName, deleteTitle);
                }
                //this shows all employees and job titles
                    if (choice == "D" || choice == "d")
                    {
                        Console.WriteLine("\n\nCurrent Employees: ");
                        foreach (Person pr in ar)
                            pr.Show();
                    }
                    //this exits the program
                    if (choice == "E" || choice == "e")
                    {
                        Console.WriteLine("\nGoodbye.");
                        endApp = true;
                    }
                }

                

        }
        }
    }

