using System;
using System.Linq;
using System.Text;

namespace ChessBoard2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode; //Changes the Input Encoding to Unicode so symbols we input doesn't show up as questionmarks
            Console.OutputEncoding = Encoding.Unicode; //Changes the Output Encoding to Unicode
            
            Console.WriteLine("How big is the board?"); //Asks how big the board should be
            int Size = int.Parse(Console.ReadLine()); //Saves the input and converts it to an Int

            
            bool[,] chessboardArr = new bool[Size, Size]; //Creates a new bool for a 2d Array which should be the size we input in the variable "Size"

            Console.WriteLine("How should black pieces look?"); //Asks what the black boardpieces should look like in the console
            string blPiece = Console.ReadLine(); //Saves it as a string

            Console.WriteLine("How should white pieces look?"); //Asks what the white boardpieces should look like in the console
            string whPiece = Console.ReadLine(); //Saves it as a string

            Console.WriteLine("What should the chesspiece look like?"); //Asks what the chesspiece should look like in the console
            string chPiece = Console.ReadLine(); //Saves it as a string

            Console.WriteLine("Where would you like to place your chesspiece?"); //Asks where we would like to place the chesspiece
            string Place = Console.ReadLine(); //Saves the input as a string

            int Place1 = Convert.ToChar(Place.Substring(0,1)); //Separates the first "input" from the string "Place" to its own variable and converts it to a char
            int Place2 = int.Parse(Place.Substring(1, 1)); //Same as above but converts the input from string to int

            switch (Place1) //A switch to "convert" the input letter to a number
            {
                case 'A':
                    Place1 = 1;
                    break;
                case 'B':
                    Place1 = 2;
                    break;
                case 'C':
                    Place1 = 3;
                    break;
                case 'D':
                    Place1 = 4;
                    break;
                case 'E':
                    Place1 = 5;
                    break;
                case 'F':
                    Place1 = 6;
                    break;
                case 'G':
                    Place1 = 7;
                    break;
                case 'H':
                    Place1 = 8;
                    break;
                case 'I':
                    Place1 = 9;
                    break;
            }

            chessboardArr[Place1, Place2] = true; //Initializes the "chessboard" array

            for (int i = 1; i < Size; i++) //Outer loop (Rows)
            {
                for (int j = 1; j < Size; j++) //Inner loop (Columns)
                {
                    if (chessboardArr[i, j] == true) //If i == Place1 && j == Place 2 it will run the code below
                    {
                        Console.Write(chPiece); //Outputs the "chess" piece to the console
                    }
                    else if (j % 2 == 0) //If the int "j" is an even number run the code below
                    {
                        Console.Write(whPiece); //Writes the "white" piece to the console
                    }
                    else //If it's none of the above run the code below
                    {
                        Console.Write(blPiece); //Write the "black" piece to the console
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
