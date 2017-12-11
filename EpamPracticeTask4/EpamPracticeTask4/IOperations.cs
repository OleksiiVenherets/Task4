namespace EpamPracticeTask4
{
    public interface IOperations
    {
        /// <summary>
        /// Method for adding matrix
        /// </summary>
        /// <param name="firstMatrix">first matrix</param>
        /// <param name="secondMatrix">second matrix</param>
        /// <returns>return new matrix which is result of adding two matrix</returns>
        Matrix Add(Matrix firstMatrix, Matrix secondMatrix);
        /// <summary>
        /// Method for substracting matrix
        /// </summary>
        /// <param name="firstMatrix">first matrix</param>
        /// <param name="secondMatrix">second matrix</param>
        /// <returns>return new matrix which is result of substracting two matrix</returns>
        Matrix Subsract(Matrix firstMatrix, Matrix secondMatrix);
        /// <summary>
        /// Method for multiplication matrix on number
        /// </summary>
        /// <param name="matrix">matrix</param>
        /// <param name="number">number</param>
        /// <returns>return new matrix which is result of multiplication matrix on number</returns>
        Matrix MultiplicationOnNumber(Matrix matrix, int number);
        /// <summary>
        /// Method for multiplicating matrix
        /// </summary>
        /// <param name="firstMatrix">first matrix</param>
        /// <param name="secondMatrix">second matrix</param>
        /// <returns>return new matrix which is result of multiplication two matrix</returns>
        Matrix Multiplication(Matrix firstMatrix, Matrix secondMatrix);
        /// <summary>
        /// MEthod for transport matrix
        /// </summary>
        /// <param name="matrix"></param>
        /// <returns>return new transport matrix</returns>
        Matrix TransportMatrix(Matrix matrix);
        /// <summary>
        /// Method to get submatrix
        /// </summary>
        /// <param name="matrix">matrix</param>
        /// <param name="row1">start row</param>
        /// <param name="row2">end row</param>
        /// <param name="col1">start col</param>
        /// <param name="col2">end col</param>
        /// <returns>return submatix</returns>
        Matrix SubMatrix(Matrix matrix, int row1, int row2, int col1, int col2);
        /// <summary>
        /// Method to compare two matrix
        /// </summary>
        /// <param name="firstMatrix">first matrix</param>
        /// <param name="secondMatrix">second ,matrix</param>
        /// <returns>return true if matrix are equal</returns>
        bool CompareMatrix(Matrix firstMatrix, Matrix secondMatrix);
        /// <summary>
        /// Metod to compare size of two matrix
        /// </summary>
        /// <param name="firstMatrix">first matrix</param>
        /// <param name="secondMatrix"></param>
        /// <returns>return true if size of matrix are equal</returns>
        bool CompareSizeMatrix(Matrix firstMatrix, Matrix secondMatrix);

    }
}