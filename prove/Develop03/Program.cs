using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Please enter the details of the verse you wish to memorize:");

       
        
        string endProgram = "";
        string book;
        string chapter;
        string startVerse;
        string endVerse;
        string text;
        Scripture scripture1 = null;

     
        Console.Write("Are your doing a single verse or multiple?");
        string singleMultiple = Console.ReadLine();

        if (singleMultiple == "single")
        {
            Console.Write("What is the book:");
            book = Console.ReadLine();
            Console.Write("What is the chapter: ");
            chapter = Console.ReadLine();
            Console.Write("What is the verse number: ");
            startVerse = Console.ReadLine();
            Console.Write("Enter verse text: ");
            text = Console.ReadLine();
            scripture1 = new Scripture(text, book, chapter, startVerse);
        }
            
        else if(singleMultiple == "multiple")
            {
            Console.Write("What is the book:");
            book = Console.ReadLine();
            Console.Write("What is the chapter: ");
            chapter = Console.ReadLine();
            Console.Write("What is the verse number: ");
            startVerse = Console.ReadLine();
            Console.Write("What is the end verse number: ");
            endVerse = Console.ReadLine();
            Console.Write("Enter verse text: ");
            text = Console.ReadLine();
            scripture1 = new Scripture(text, book, chapter, startVerse, endVerse); // add ende berse
            }
            

        Console.Clear();
        scripture1.GetRenderedText();
        Console.Write("\nPress enter to continue or type 'quit' to finish: ");
        endProgram = Console.ReadLine();
        do{
            if (endProgram == "quit"){
                break;
            }else if (endProgram == ""){
                Console.Clear();
                scripture1.HideWords();
                scripture1.GetRenderedText();
                if(scripture1.AllWordsHiddenStatus())
                    Environment.Exit(0);
                Console.WriteLine("");
                Console.Write("\nPress enter to continue or type 'quit' to finish: ");
                endProgram = Console.ReadLine();
            }
          
        }while(endProgram == "");
    }
}