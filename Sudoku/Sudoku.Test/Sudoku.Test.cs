using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sudoku.Test
{
    [TestClass]
    public class Sudoku
    {

        [TestMethod]
        public void BoardValuesWithinRange()
        {
            var puzzle = new Puzzle();
            puzzle.InitBoard(TestBoard1());
            var valsInRange = puzzle.BoardValuesAreInRange();
            Assert.IsTrue(valsInRange);
        }

        [TestMethod]
        public void CanVerifySolvedPuzzle()
        {
            var puzzle = new Puzzle();
            var puzzleIsSolved = puzzle.PuzzleISolved();
            Assert.IsTrue(puzzleIsSolved);
        }

        private int[,] TestBoard1()
        {
            int[,] board = new int[9,9]
            {
                {1,2,3,4,5,6,7,8,9 },
                {1,2,3,4,5,6,7,8,9 },
                {1,2,3,4,5,6,7,8,9 },
                {1,2,3,4,5,6,7,8,9 },
                {1,2,3,4,5,6,7,8,9 },
                {1,2,3,4,5,6,7,8,9 },
                {1,2,3,4,5,6,7,8,9 },
                {1,2,3,4,5,6,7,8,9 },
                {1,2,3,4,5,6,7,8,9 }
            };
            return board;
        }
    }
}
