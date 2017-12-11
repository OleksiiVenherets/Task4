using System;

namespace EpamPracticeTask4
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstMatrix = new Matrix(6, 6);
            var secondMatrix = new Matrix(6, 6);
            var operations = new Operations();
            Console.WriteLine($"First matrix: \n {firstMatrix.ToString()}");
            Console.WriteLine($"Second matrix: \n {secondMatrix.ToString()}");

            //adding
            try
            {
                Console.WriteLine($"Adding two matrix:\n{(operations.Add(firstMatrix, secondMatrix)).ToString()}");
            }
            catch (SizeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.Message);
            }
            //substracting
            try
            {
                Console.WriteLine($"Substracting two matrix:\n{(operations.Subsract(firstMatrix, secondMatrix)).ToString()}");
            }
            catch (SizeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.Message);
            }
            //multi on number
            try
            {
                Console.WriteLine($"Multiplication matrix on number:\n{(operations.MultiplicationOnNumber(firstMatrix, 2)).ToString()}");
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.Message);
            }
            //multi 2 matrix
            try
            {
                Console.WriteLine($"Multiplication two matrix:\n{(operations.Multiplication(firstMatrix, secondMatrix)).ToString()}");
            }
            catch (SizeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.Message);
            }
            //Transport
            Console.WriteLine($"Transport matrix:\n{(operations.TransportMatrix(firstMatrix)).ToString()}");
            //Submatrix
            try
            {
                Console.WriteLine($"Multiplication matrix on number:\n{(operations.SubMatrix(firstMatrix, 2, 4, 2, 4)).ToString()}");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            //Compare
            Console.WriteLine(operations.CompareMatrix(firstMatrix, secondMatrix)
                ? "matrixs are equal"
                : "matrixs are not equal");

            Console.ReadKey();
        }
    }
}
