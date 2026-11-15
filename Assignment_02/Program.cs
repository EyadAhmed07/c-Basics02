using System.Text;

namespace Assignment_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question01
            //string title = "clean code";
            //string upperTitile = title.ToUpper();
            //Console.WriteLine(title);
            //Console.WriteLine(upperTitile);
            #endregion


            #region Question02
            //string str1 = "clean code";
            //string str2 = "clean code";
            //Console.WriteLine(object.ReferenceEquals(str1,str2));
            #endregion

                
            #region Question03
            //StringBuilder sb = new StringBuilder();
            //sb.Append("Book List");
            //sb.Append("-Updated");
            //Console.WriteLine(sb);
            #endregion


            #region Question04
            //sb.Replace("Book List", "Library");
            //Console.WriteLine(sb);
            #endregion

                
            #region Question05
            //string title = "Clean code";
            //int pages = 464;
            //Console.WriteLine("Book:"+title+",pages:"+pages);
            #endregion

            #region Question06
            //Console.WriteLine($"Book:{title},pages:{pages}");
            #endregion


            #region quetion07
            //string x=string.Format("Book:{0},pages:{1}",title,pages);
            //Console.WriteLine(x);
            #endregion


            #region Question08
            //int pages = 464;
            //if (pages > 300)
            //    Console.WriteLine("Long book");
            //else
            //    Console.WriteLine("Short book");
            #endregion


            #region  Question09
            //int pages = 464;
            //bool isAvailable = true;
            //if(pages>300 && isAvailable)
            //    Console.WriteLine("You can borrow this book");
            #endregion


            #region Question10
            //string title = "Refactoring";
            //switch (title)
            //{
            //    case "Clean Code":
            //        Console.WriteLine("Great choice!");
            //    break;

            //    case "Refactoring":
            //        Console.WriteLine("Nice pick!");
            //    break;

            //    default:
            //        Console.WriteLine("Never heard of it");
            //    break;
            //}
            #endregion


            #region Question11
            //int pages = 464;
            //string book = (pages > 300) ? "Long Book" : "Short Book";
            //Console.WriteLine(book);
            #endregion


            #region Question12
            string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            //for (int i = 0; i < books.Length; i++)
            //{
            //    Console.WriteLine($"{i + 1}.{books[i]}");
            //}
            #endregion


            #region Question13
            //int j = 0;
            //while (j<books.Length)
            //{
            //    Console.WriteLine($"{j+1}.{books[j]}");
            //    j++;
            //}
            #endregion


            #region Question14
            //int i = 0;
            //do
            //{
            //    Console.WriteLine(books[i]);
            //    i++;

            //}while(i<3);
            #endregion


            #region Question15
            //foreach (string book in books)
            //{
            //    Console.WriteLine(book);
            //}
            #endregion


            #region Question16
            //for (int i = 0; i < books.Length; i++)
            //{
            //    if (books[i] == "Refactoring")
            //        break;
            //    else
            //        Console.WriteLine(books[i]);
            //}
            #endregion


            #region Question17
            //for (int i = 0; i < books.Length; i++)
            //{
            //    if (books[i] == "The Pragmatic Programmer")
            //        continue;
            //    else
            //        Console.WriteLine(books[i]);
            //}
            #endregion

                
            #region Question18
            PrintFirstBook(books);
            #endregion

        }
        public static void PrintFirstBook(string[]arr)
        {
            if (arr.Length == 0)
                return ;
            else
                Console.WriteLine($"First book:{arr[0]}");
        }
    }
}
