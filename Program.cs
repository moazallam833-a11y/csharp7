namespace csharp7
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            #region Question 1

            Book book = new Book();

            //Console.WriteLine(book.password);
            #endregion

            #region Question 2
            Book book1 = new Book();

            Console.WriteLine(book.copiesInStock);
            #endregion

            #region Question 3
            Book book2   = new Book();

            book2.Title = "C# Basics";

            Console.WriteLine(book2.Title);
            #endregion

            #region Question 4
            Book book3 = new Book();

             
            book.Genre = Genre.Science;

            Console.WriteLine(book.Genre);
            #endregion

            #region Question 5
            Console.WriteLine((int)Genre.Fiction);
            Console.WriteLine((int)Genre.NonFiction);
            Console.WriteLine((int)Genre.Science);
            #endregion
            #region Question 6
            int genreNumber = 1;

            Genre genre = (Genre)genreNumber;

            Console.WriteLine(genre);
            #endregion
            #region Question7
            Genre genre1 = Genre.Fiction;

            string genreText = genre.ToString();

            Console.WriteLine(genreText);
            #endregion
            #region Question8
            string genre_Text = "Science";

            Genre genre2 = (Genre)Enum.Parse(typeof(Genre), genre_Text);

            Console.WriteLine(genre2    );
            #endregion
            #region Q9
            string genreText1 = "Mystery";

            Genre genre3;

            if (Enum.TryParse(genreText1, out genre3))
            {
                Console.WriteLine(genre3);
            }
            else
            {
                Console.WriteLine("Unknown genre");
            }
            #endregion








        }
    }
}
