using System;
using System.Globalization;
using System.Text;
using System.Threading;

namespace EpamPracticeTask4
{
    /// <summary>
    /// Class for matrix
    /// </summary>
    public class Matrix: IFormattable
    {
        /// <summary>
        /// field for creating matrix
        /// </summary>
        public int[,] matrix;
        /// <summary>
        /// Count of rows
        /// </summary>
        public int Rows { get; }
        /// <summary>
        /// Count of columns
        /// </summary>
        public int Cols { get; }
        /// <summary>
        /// Constructor for matrix
        /// </summary>
        /// <param name="a">count of rows</param>
        /// <param name="b">count of columns</param>
        public Matrix(int a, int b)
        {
            matrix = new int[a, b];
            Rows = a;
            Cols = b;
            Generate();
        }
        /// <summary>
        /// Random genarating matrix
        /// </summary>
        private void Generate()
        {
            var random = new Random();
            Thread.Sleep(20);
            for (var i = 0; i < Rows; i++)
                for (var j = 0; j < Cols; j++)
                    matrix[i, j] = random.Next(0, 10);
        }

        /// <summary>
        /// Method to represent vector in string
        /// </summary>
        /// <returns> string which represent vector</returns>
        public override string ToString()
        {
            return ToString("", CultureInfo.CurrentCulture);
        }
        /// <summary>
        /// Method to represent vector in string
        /// </summary>
        /// <returns> string which represent vector</returns>
        public string ToString(string format, IFormatProvider formatProvider)
        {
            var sb = new StringBuilder();
            for (var i = 0; i < Rows; i++)
            {
                for (var j = 0; j < Cols; j++)
                    sb.Append($"{matrix[i, j]} ");
                sb.Append("\n");
            }
            sb.Append("\n");
            return sb.ToString();
        }
    }
}