using System.Collections.Generic;

namespace Tic_tac_toe.Domain.Entities
{
    public class Matrix
    {
        public List<string> IndexNumbers { get; set; }
        public string[,] MatrixSize { get; set; }
        public int Index { get; set; }

        public Matrix(List<string> indexNumbers, string[,] matrixSize)
        {
            IndexNumbers = indexNumbers;
            MatrixSize = matrixSize;
            Index = 1;
        }
    }
}
