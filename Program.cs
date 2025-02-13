namespace BookMan
{
    using BookMan.Controllers;
    using System;
    using static BookManagement.Controllers.BookControllers;

    internal class Program
    {
        private static void Main(string[] args)
        {
            var controller = new BookController();

            while (true)
            {
                Console.WriteLine("\nBook Manager");
                Console.WriteLine("1. View all books");
                Console.WriteLine("2. View a single book");
                Console.WriteLine("3. Delete a book");
                Console.WriteLine("4. Search books");
                Console.WriteLine("5. Exit");
                Console.WriteLine("6. Add a book");

                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            controller.List();
                            break;
                        case 2:
                            Console.Write("Enter book ID: ");
                            if (int.TryParse(Console.ReadLine(), out int id))
                            {
                                controller.Single(id);
                            }
                            else
                            {
                                Console.WriteLine("Invalid ID.");
                            }
                            break;
                        case 3:
                            Console.Write("Enter book ID: ");
                            if (int.TryParse(Console.ReadLine(), out int deleteId))
                            {
                                controller.Delete(deleteId);
                            }
                            else
                            {
                                Console.WriteLine("Invalid ID.");
                            }
                            break;
                        case 4:
                            Console.Write("Enter keyword to search: ");
                            string keyword = Console.ReadLine();
                            controller.Search(keyword);
                            break;
                        case 5:
                            Console.WriteLine("Goodbye!");
                            return;
                        default:
                            Console.WriteLine("Invalid choice.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            }
        }
    }
}
