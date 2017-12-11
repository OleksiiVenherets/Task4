using System;

namespace EpamPracticeTask4
{
    public class Operations:IOperations
    {
        /// <summary>
        /// Method for adding matrix
        /// </summary>
        /// <param name="firstMatrix">first matrix</param>
        /// <param name="secondMatrix">second matrix</param>
        /// <returns>return new matrix which is result of adding two matrix</returns>
        public Matrix Add(Matrix firstMatrix, Matrix secondMatrix)
        {
            if (firstMatrix == null || secondMatrix == null)
                throw new ArgumentNullException();
            var resultMatrix = new Matrix(firstMatrix.Rows, firstMatrix.Cols);
            if (CompareSizeMatrix(firstMatrix, secondMatrix))
            {
                for (var i = 0; i < firstMatrix.Rows; i++)
                    for (var j = 0; j < firstMatrix.Cols; j++)
                        resultMatrix.matrix[i, j] = firstMatrix.matrix[i, j] + secondMatrix.matrix[i, j];
            }
            else
                throw new SizeException("Sizes of matrix are not equal");
            return resultMatrix;
        }
        /// <summary>
        /// Method for substracting matrix
        /// </summary>
        /// <param name="firstMatrix">first matrix</param>
        /// <param name="secondMatrix">second matrix</param>
        /// <returns>return new matrix which is result of substracting two matrix</returns>
        public Matrix Subsract(Matrix firstMatrix, Matrix secondMatrix)
        {
            if (firstMatrix == null || secondMatrix == null)
                throw new ArgumentNullException();
            var resultMatrix = new Matrix(firstMatrix.Rows, firstMatrix.Cols);
            if (CompareSizeMatrix(firstMatrix, secondMatrix))
            {
                for (var i = 0; i < firstMatrix.Rows; i++)
                    for (var j = 0; j < firstMatrix.Cols; j++)
                        resultMatrix.matrix[i, j] = firstMatrix.matrix[i, j] - secondMatrix.matrix[i, j];
            }
            else
                throw new SizeException("Sizes of matrix are not equal");
            return resultMatrix;
        }
        /// <summary>
        /// Method for multiplication matrix on number
        /// </summary>
        /// <param name="matrix">matrix</param>
        /// <param name="number">number</param>
        /// <returns>return new matrix which is result of multiplication matrix on number</returns>
        public Matrix MultiplicationOnNumber(Matrix matrix, int number)
        {
            if (matrix == null)
                throw new ArgumentNullException();
            var resultMatrix = new Matrix(matrix.Rows, matrix.Cols);
            for (var i = 0; i < matrix.Rows; i++)
                for (var j = 0; j < matrix.Cols; j++)
                    resultMatrix.matrix[i, j] = matrix.matrix[i, j] * number;
            return resultMatrix;
        }
        /// <summary>
        /// Method for multiplicating matrix
        /// </summary>
        /// <param name="firstMatrix">first matrix</param>
        /// <param name="secondMatrix">second matrix</param>
        /// <returns>return new matrix which is result of multiplication two matrix</returns>
        public Matrix Multiplication(Matrix firstMatrix, Matrix secondMatrix)
        {
            if (firstMatrix == null || secondMatrix == null)
                throw new ArgumentNullException();
            var resultMatrix = new Matrix(firstMatrix.Rows, secondMatrix.Cols);
            if (firstMatrix.Rows == secondMatrix.Cols)
            {
                for (var i = 0; i < firstMatrix.Rows; i++)
                    for (var j = 0; j < secondMatrix.Cols; j++)
                        for (var k = 0; k < firstMatrix.Rows; k++)
                            resultMatrix.matrix[i, j] += firstMatrix.matrix[i, k] * secondMatrix.matrix[k, j];
            }
            else
                throw new SizeException("Sizes of matrix are not equal");
            return resultMatrix;
        }
        /// <summary>
        /// MEthod for transport matrix
        /// </summary>
        /// <param name="matrix"></param>
        /// <returns>return new transport matrix</returns>
        public Matrix TransportMatrix(Matrix matrix)
        {
            var resultMatrix = new Matrix(matrix.Cols, matrix.Rows);
            try
            {
                for (var i = 0; i < matrix.Cols; i++)
                    for (var j = 0; j < matrix.Rows; j++)
                    {
                        resultMatrix.matrix[i, j] = matrix.matrix[j, i];
                    }
            }
            catch (IndexOutOfRangeException)
            {
                Console.Write("Index is out of range");
            }
            return resultMatrix;
        }
        /// <summary>
        /// Method to get submatrix
        /// </summary>
        /// <param name="matrix">matrix</param>
        /// <param name="row1">start row</param>
        /// <param name="row2">end row</param>
        /// <param name="col1">start col</param>
        /// <param name="col2">end col</param>
        /// <returns>return submatix</returns>
        public Matrix SubMatrix(Matrix matrix, int row1, int row2, int col1, int col2)
        {
            if ((row1 <= matrix.Rows) || (row2 <= matrix.Rows) || (col1 <= matrix.Cols) || (col2 <= matrix.Cols))
            {
                var sizerow = row1 > row2 ? (row1 - row2) + 2 : (row2 - row1) + 2;
                var sizecol = col1 > col2 ? (col1 - col2) + 2 : (col2 - col1) + 2;
                var resultMatrix = new Matrix(sizerow, sizecol);
                for (var i = 0; i < sizerow; i++)
                    for (var j = 0; j < sizecol; j++)
                        resultMatrix.matrix[i, j] = matrix.matrix[i + row1 - 1, j + col1 - 1];
                return resultMatrix;
            }
            else
                throw new ArgumentException("The indexes of submatrix are nor valid");
        }
        /// <summary>
        /// Method to compare two matrix
        /// </summary>
        /// <param name="firstMatrix">first matrix</param>
        /// <param name="secondMatrix">second ,matrix</param>
        /// <returns>return true if matrix are equal</returns>
        public bool CompareMatrix(Matrix firstMatrix, Matrix secondMatrix)
        {
            if (!CompareSizeMatrix(firstMatrix, secondMatrix))
                return false;
            for (var i = 0; i < firstMatrix.Rows; i++)
                for (var j = 0; j < firstMatrix.Cols; j++)
                    if (firstMatrix.matrix[i, j] != secondMatrix.matrix[i, j])
                        return false;
            return true;
        }
        /// <summary>
        /// Metod to compare size of two matrix
        /// </summary>
        /// <param name="firstMatrix">first matrix</param>
        /// <param name="secondMatrix"></param>
        /// <returns>return true if size of matrix are equal</returns>
        public bool CompareSizeMatrix(Matrix firstMatrix, Matrix secondMatrix)
        {
            return firstMatrix.Rows == secondMatrix.Rows && firstMatrix.Cols == secondMatrix.Cols;
        }
    }
}