using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Program
    {
        public static void initialList()
        {
            Movie movie1= new Movie("John Wick", "Action");
            Movie movie2 = new Movie("Olympus has Fallen", "Action");
            Movie movie3 = new Movie("Star Wars", "Science Fiction");
            Movie movie4 = new Movie("Interstellar", "Science Fiction");
            Movie movie5 = new Movie("Bruce Almighty", "Comedy");
            Movie movie6 = new Movie("Tropic Thunder", "Comedy");
            Movie movie7 = new Movie("A Few Good Men", "Drama");
            Movie movie8 = new Movie("Forrest Gump", "Drama");
            Movie movie9 = new Movie("It", "Horror");
            Movie movie10 = new Movie("The Hitcher", "Horror");
            Movie movie11 = new Movie("Aladdin", "Animated");
            Movie movie12 = new Movie("A Scanner Darkly", "Animated");


            MoviesList.movies.Add(movie1);
            MoviesList.movies.Add(movie2);
            MoviesList.movies.Add(movie3);
            MoviesList.movies.Add(movie4);
            MoviesList.movies.Add(movie5);
            MoviesList.movies.Add(movie6);
            MoviesList.movies.Add(movie7);
            MoviesList.movies.Add(movie8);
            MoviesList.movies.Add(movie9);
            MoviesList.movies.Add(movie10);
            MoviesList.movies.Add(movie11);
            MoviesList.movies.Add(movie12);


            menu();
        }

        public static void menu()
        {
            Console.WriteLine("1- Action");
            Console.WriteLine("2- Science Fiction");
            Console.WriteLine("3- Comedy");
            Console.WriteLine("4- Drama");
            Console.WriteLine("5- Horror");
            Console.WriteLine("6- Animated");

            Console.WriteLine("\n7- Add a new movie to the list.");

            getInput();
        }

        public static void getInput()
        {
            Console.Write("\n\nPlease enter a category: ");
            int input = 0;
            try
            {
                input = int.Parse(Console.ReadLine());
            }
            catch 
            {
                Console.WriteLine("ERROR: input must be a corresponding category number.");
                getInput();
            }
            if(input >=1 && input <=6)
            {
                showList(input);
            }
            else
            {
                Console.WriteLine("ERROR: input must be a corresponding category number.");
                getInput();
            }
        }

        public static void userAddedMovie()
        {
            Console.Write("\nEnter the title of the movie: ");
            string title = Console.ReadLine();
            foreach (Movie m in MoviesList.movies)
            {
                if (title == m.getTitle())
                {
                    Console.WriteLine("\nThat movie already exists, try again.");
                    menu();
                }
            }
            Console.Write("\nEnter the category of the movie: ");
            string category = Console.ReadLine();
            category = category.ToLower();
            if (category != "action" && category != "science fiction" && category != "comedy" 
                && category != "drrama" && category != "horror" && category != "animated")
            {
                Console.WriteLine("\nInvalid category. Category must be:" +
                    "\nAction, Science Fiction, Comedy, Drama, Horror, or Animated");
                userAddedMovie();
                    
            }
            else
            {
                Movie movie = new Movie(title, category);
                MoviesList.movies.Add(movie);
                Console.Clear();
                menu();
            }
        }

        public static void showList(int input)
        {
            switch (input)
            {
                case 1:
                    Console.WriteLine("Action Movies: \n");
                    foreach (Movie m in MoviesList.getMovies())
                    {
                        if (m.getCategory().ToLower() == "action")
                        {
                            Console.WriteLine(m.getTitle());
                        }
                    }
                    again();
                    break;
                case 2:
                    Console.WriteLine("Science Fiction Movies:\n");
                    foreach (Movie m in MoviesList.movies)
                    {
                        
                        if (m.getCategory().ToLower() == "science fiction")
                        {
                            Console.WriteLine(m.getTitle());
                        }
                    }
                    again();
                    break;
                case 3:
                    Console.WriteLine("Comedy Movies:\n");
                    foreach (Movie m in MoviesList.movies)
                    {
                        if (m.getCategory().ToLower() == "comedy")
                        {
                            Console.WriteLine(m.getTitle());
                        }
                    }
                    again();
                    break;
                case 4:
                    Console.WriteLine("Drama Movies:\n");
                    foreach (Movie m in MoviesList.movies)
                    {
                        if (m.getCategory().ToLower() == "drama")
                        {
                            Console.WriteLine(m.getTitle());
                        }
                    }
                    again();
                    break;
                case 5:
                    Console.WriteLine("Horror Movies:\n");
                    foreach (Movie m in MoviesList.movies)
                    {
                        if (m.getCategory().ToLower() == "horror")
                        {
                            Console.WriteLine(m.getTitle());
                        }
                    }
                    again();
                    break;
                case 6:
                    Console.WriteLine("Animated Movies:\n");
                    foreach (Movie m in MoviesList.movies)
                    {
                        if (m.getCategory().ToLower() == "animated")
                        {
                            Console.WriteLine(m.getTitle());
                        }
                    }
                    again();
                    break;
                case 7:
                    userAddedMovie();
                    break;
                default:
                    Console.WriteLine("ERROR: invalid category.");
                    menu();
                    break;
            }
        }

        public static void again()
        {
            Console.WriteLine("\nPress 'y' to enter a new category or any other key to exit");
            string input = Console.ReadLine();
            input = input.Trim();
            input = input.ToLower();

            if (input == "y")
            {
                menu();
            }
            else
            {
                Environment.Exit(0);
            }
        }

        static void Main(string[] args)
        {
            initialList();
            Console.ReadLine();
        }
    }
}
