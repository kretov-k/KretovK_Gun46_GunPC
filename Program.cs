namespace KretovK_Gun42_GunPC
{
    internal class Program
    {
        private class Task1
        {
            private readonly List<string> _listOfNames = new List<string>()
            {
                "StormTrooper", "Jedi", "Wookie"
            };

            public void TaskLoop()
            {
                Console.WriteLine("Task #1. List.");
                Console.WriteLine("To stop type -exit.");

                while (true)
                {
                    Console.WriteLine("Type a new item: ");
                    string input = Console.ReadLine();

                    if (input == "-exit")
                    {
                        break;
                    }

                    _listOfNames.Add(input);

                    Console.WriteLine("The contents of the list:");

                    foreach (string item in _listOfNames)
                    {
                        Console.WriteLine(item);
                    }

                    Console.WriteLine("Type new item to add in the middle of the list");
                    input = Console.ReadLine();

                    if (input == "-exit")
                    {
                        break;
                    }

                    int middleIndex = _listOfNames.Count / 2;

                    _listOfNames.Insert(middleIndex, input);

                    Console.WriteLine("Updated list:");

                    foreach (string item in _listOfNames)
                    {
                        Console.WriteLine(item);
                    }
                    Console.WriteLine("Thanks for adding two items, you are free to go young padawan, and may the 4 be with you. :-)");
                    break;
                }
            }
        }

        private class Task2
        {
            private readonly Dictionary<string, float> _students = new Dictionary<string, float>();

            public void TaskLoop()
            {
                Console.WriteLine("Task 2. Dictionary.");
                Console.WriteLine("Enter students and grades");
                Console.WriteLine("To finish adding students type -stop");
                Console.WriteLine("To stop type -exit.");

                while (true)
                {
                    Console.WriteLine("Type students name: ");
                    string name = Console.ReadLine();

                    if (name == "-exit")
                    {
                        return;
                    }

                    if (name == "-stop")
                    {
                        break;
                    }

                    Console.WriteLine("Type students grade from 2 to 5: ");
                    string input = Console.ReadLine();

                    if (input == "-exit")
                    {
                        return;
                    }

                    float grade;

                    if (!float.TryParse(input, out grade) || grade < 2 || grade > 5)
                    {
                        Console.WriteLine("Incorrect grade.");
                        continue;
                    }

                    _students[name] = grade;
                }

                Console.WriteLine("You've finished adding students.");
                Console.WriteLine("Now try searching them.");
                Console.WriteLine("To stop type -exit");

                while (true)
                { 
                    Console.WriteLine("Enter students name for search: ");
                    string searchName = Console.ReadLine();

                    if (searchName == "-exit")
                    {
                        break;
                    }

                    if (_students.TryGetValue(searchName, out float studentGrade))
                    {
                        Console.WriteLine($"Student {searchName} grade is: {studentGrade}");
                    }
                    else
                        Console.WriteLine("No such student.");
                }
            }
        }

        private class Task3
        { private class Node
            {
                public string Value;
                public Node Next;
                public Node Previous;

            }

            private Node _first;
            private Node _last;

            private void Add(string value)
            {
                Node newNode = new Node();
                newNode.Value = value;

                if (_first == null)
                {
                    _first = newNode;
                    _last = newNode;
                }
                else
                {
                    _last.Next = newNode;
                    newNode.Previous = _last;
                    _last = newNode;
                }
            }

            public void TaskLoop()
            {
                Console.WriteLine("Task 3. Linked list.");
                Console.WriteLine("Type from 3 to 6 elements. Type -stop to break input.");
                Console.WriteLine("To stop type -exit.");

                int count = 0;

                while (count < 6)
                {
                    Console.WriteLine($"Type element #{count + 1}: ");
                    string input = Console.ReadLine();

                    if (input == "-exit")
                    {
                        return;
                    }

                    if (input == "-stop")
                    {
                        if (count < 3)
                        {
                            Console.WriteLine("Less then 3 elements.");
                            continue;
                        }
                        break;
                    }
                    Add(input);
                    count++;
                }
                Console.WriteLine("Ordynary list:");
                Node current = _first;

                while (current != null)
                {
                    Console.WriteLine(current.Value);
                    current = current.Next;
                }
                Console.WriteLine("Reversed list:");
                current = _last;

                while (current != null)
                {
                    Console.WriteLine(current.Value);
                    current = current.Previous;
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Choose task number from 1 to 3.");

            if (!int.TryParse(Console.ReadLine(), out int task))
            {
                Console.WriteLine("Enter a number:");
                return;
            }

            switch (task)
            {
                case 1:
                    CheckTaskFirst();
                    break;

                case 2:
                    CheckTaskSecond();
                    break;

                case 3:
                    CheckTaskThird();
                    break;
            }        
        }
        private static void CheckTaskFirst()
        {
            var task1 = new Task1();
            task1.TaskLoop();
        }

        private static void CheckTaskSecond()
        {
            var task2 = new Task2();
            task2.TaskLoop();
        }
        private static void CheckTaskThird()
        {
            var task3 = new Task3();
            task3.TaskLoop();
        }
    }
}
