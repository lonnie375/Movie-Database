// See https://aka.ms/new-console-template for more information

using MovieDataBase;




List<Movie> movieList = new List<Movie>()
{
    new Movie() { Title = "The Proud Family", Category = "Animated"},
    new Movie() { Title = "The PJs", Category = "Animated"},
    new Movie() { Title = "Fences", Category = "Drama"},
    new Movie() { Title = "Straight Outta Compton", Category = "Drama"},
    new Movie() { Title = "Remember the Titans", Category = "Drama"},
    new Movie() { Title = "Candyman", Category = "Horror"},
    new Movie() { Title = "Get Out", Category = "Horror"},
    new Movie() { Title = "Pitch Black", Category = "Scifi"},
    new Movie() { Title = "Spawn", Category = "Scifi"},
    new Movie() { Title = "Hancock", Category = "Scifi"},
    new Movie() { Title = "Blade", Category = "Scifi"},

};


Console.WriteLine("Welcome to the Movie List Application!");
Console.WriteLine("There are 11 movies in this list.");

bool choice = true;
do
{
            Console.Write($"What category are you interested in: Animated, Drama, Horror, or Scifi? ");

    string category = Console.ReadLine();
    bool choices = true; 
    while (choices == true)
    {

    
       //Movie Categories 

            var animated = movieList.Where(x => x.Category == "Animated").ToList();
            var drama = movieList.Where(x => x.Category == "Drama").ToList();
            var horror = movieList.Where(x => x.Category == "Horror").ToList();
            var scifi = movieList.Where(x => x.Category == "Scifi").ToList();

            if (category == "Animated")
            {
                foreach (var animate in animated)
                {
                    Console.WriteLine(animate.Title);
                }
            choices = false; 

            }
            else if (category == "Drama")
            {
                foreach (var dram in drama)
                {
                    Console.WriteLine(dram.Title);
                }
            choices = false;
        }
            else if (category == "Horror")
            {
                foreach (var horro in horror)
                {
                    Console.WriteLine(horro.Title);
                }
            choices = false;
        }
            else if (category == "Scifi")
            {
                foreach (var scif in scifi)
                {
                    Console.WriteLine(scif.Title);
                }
            choices = false;
        }
            else
            {
                Console.WriteLine("Please enter either Animated, Drama, Horror, or Scifi!");
            category = Console.ReadLine();

        }

    }


    //Ask the user if they want to continue 
    Console.Write("Continue? (y/n): ");
            string userContinue = Console.ReadLine();
            if (userContinue == "y")
            {
                continue; 
            }
            else
            {
                Console.WriteLine("Good Bye!");
                  choice = false; 
            }
} while (choice == true); 

