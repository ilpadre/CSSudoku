using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    public class Puzzle
    {
        private const int DefaultX = 9;
        private const int DefaultY = 9;
        private int[] ValidDigits = null;

        private int[,] Board { get; set; }

        public Puzzle()
        {
            Board = new int[DefaultX, DefaultY];
            ValidDigits = GenerateValidDigits(DefaultX);
        }

        public void InitBoard()
        {

        }

        public void InitBoard(int[,] board)
        {
            Board = board;
        }

        public bool BoardValuesAreInRange()
        {
            var valsAreGood = true;
            for (int i = 0; i < Board.GetLength(0); i++)
            {
                for (int j = 0; j < Board.GetLength(1); j++)
                {
                    if (Board[i, j] < 1 || Board[i, j] > 9)
                    {
                        valsAreGood = false;
                    }
                }
            }

            return valsAreGood;
        }

        public bool PuzzleISolved()
        {
            return false;
        }

        private int[] GenerateValidDigits(int numDigits)
        {
            for (int i = 0; i < Board.GetLength(0); i++)
            {
                ValidDigits[i] = i = 1;
            }

            return ValidDigits;
        }

    }
}
