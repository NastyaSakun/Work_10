using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work10
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList() { 1, 2, 3, 4, 5 };
            list.Add(7);
            list.Add("nastya");
            list.RemoveAt(0);

            foreach (object l in list)
            {
                Console.Write($"\0{l}\0");
            }
            Console.WriteLine();

            Console.WriteLine($"\0Количество элементов:\0{list.Count}");

            Console.Write("\0Введите индекс элемента:\0");
            Int32 num = Convert.ToInt32(Console.ReadLine());
            Console.Write($"\0Ваш элемент:\0{list[num]}\0");
            Console.WriteLine();


            Stack<double> stack = new Stack<double>(); //LIFO
            stack.Push(2.2);
            stack.Push(3.3);
            stack.Push(4.44);

            foreach (object s in stack)
            {
                Console.Write($"\0{s}\0");
            }

            Console.Write($"\n\0Введите кол-во элементов для удаления:\0");
            Int32 count = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                stack.Pop();
            }


            foreach (object s in stack)
            {
                Console.Write($"\0{s}\0");
            }
            Console.WriteLine();

            Console.Write($"\0{stack.First()};\0{stack.Last()};\0{stack.Max()};\0{stack.Min()};\0{stack.Peek()}");
            Console.WriteLine();


            LinkedList<double> llist = new LinkedList<double>();

            for (int i = 0; i < stack.Count; i++)
            {
                llist.AddLast(stack.ElementAt(i));
            }

            foreach (object l_ in llist)
            {
                Console.Write($"\0{l_}\0");
            }

            Console.Write("\n\0Введите ключ элемента:\0");
            Int32 numl = Convert.ToInt32(Console.ReadLine());
            Console.Write($"\0Ваш элемент:\0{llist.ElementAt(numl)}\0");
            Console.WriteLine();


            Stack<Student> stud = new Stack<Student>();
            stud.Push(new Student(Convert.ToString(new Random().Next(0, 5))));
            stud.Push(new Student(Convert.ToString(new Random().Next(5, 10))));

            Console.Write($"\0Объекты класса:\0");
            foreach (Student studs in stud)
            {
                Console.Write($"\0Объекты класса:\0{studs}\0");
            }
            Console.WriteLine();


            ObservableCollection<Student> student = new ObservableCollection<Student>(); 
            
            student.CollectionChanged += Users_CollectionChanged;

            student.Add(new Student(Convert.ToString(new Random().Next(0, 5))));
            student.Add(new Student(Convert.ToString(new Random().Next(5, 10))));
            student.RemoveAt(0);

            foreach(Student students in student)
            {
                Console.WriteLine($"\0{students.Name}");
            }

           

        }


        private static void Users_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch(e.Action)
            {
                case NotifyCollectionChangedAction.Add: 
                    Student newUser = e.NewItems[0] as Student;
                    Console.WriteLine("\0Добавлен новый объект: {0}", newUser.Name);
                    break;

                case NotifyCollectionChangedAction.Remove: 
                    Student oldUser = e.OldItems[0] as Student;
                    Console.WriteLine("\0Удален объект: {0}", oldUser.Name);
                    break;
            }
                
        }

    }
    }



