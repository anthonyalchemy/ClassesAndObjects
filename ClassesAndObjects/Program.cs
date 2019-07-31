using System;

namespace ClassesAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            //classes and ojects allow you to create custom data types
            //classes model real world  entities 
            /* Go to solution explorer 
             * Click on program 
             * add class 
             * rename 
             */

            //object will be created here which is an instance of a class 

            Book book1 = new Book(); //book object
            book1.title = "Harry Potter";
            book1.author = "J.K.Rowling";
            book1.pages = 400;

            Book book2 = new Book(); //book object
            book2.title = "Lord of the rings";
            book2.author = "Tolkein";
            book2.pages = 700;

            Console.WriteLine(book2.pages);
             

            Console.ReadLine();

        }
    }
}
