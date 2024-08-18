using System;

namespace matrix
{
    
    class mat  
    {  
        public static void Main() 
        {
            int i, j; 
            int[,] arr = new int[3, 3]; 

            Console.Write("\n\nRead a 2D array of size 3x3 and print the matrix :\n");
            Console.Write("------------------------------------------------------\n");  

            Console.Write("Input elements in the matrix :\n");
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.Write("element "+"["+ i+"]"+"["+ j+"] : ");
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }  

            Console.Write("\nThe matrix is : \n");
            for (i = 0; i < 3; i++)
            {
                Console.Write("\n");
                for (j = 0; j < 3; j++)
                {
                    Console.Write("\t"+ arr[i, j]); 
                }
            }
            Console.Write("\n\n");
        }
    }
}