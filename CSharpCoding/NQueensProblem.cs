using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCoding
{
    public class NQueensProblem
    {
        int noOfQueens = 0;
        int[,] chessTable;

        
        public void Solve(int noOfQueens)
        {
            this.noOfQueens = noOfQueens;
            chessTable = new int[noOfQueens, noOfQueens];

            if ( SetQueens(0))
            {
                PrintChessTable();
            }
            else
            {
                Console.WriteLine("No Valid solution exists");
            }

        }

        bool SetQueens(int n)
        {
            if (n >= noOfQueens) return true;

            for(int i=0; i<noOfQueens; i++)
            {
                if(IsValidPosition(i,n))
                {
                    chessTable[i, n] = 1;
                    if(SetQueens(n+1))
                    {
                        return true;
                    }

                    chessTable[i, n] = 0;
                }
            }

            return false;
        }

        private bool IsValidPosition(int row, int col)
        {
            for(int i = 0; i <col; i++)
            {
                if (chessTable[row, i] == 1) return false;
            }

            for (int i = col, j = row; i >= 0 && j < noOfQueens; i--,j++)
            {
                if(chessTable[j, i] == 1) return false;
            }

            for (int i = col, j = row; i >= 0 && j >= 0; i--, j--)
            {
                if(chessTable[j, i] == 1) return false;
            }

            return true;
        }

        void PrintChessTable()
        {
            for(int row = 0; row<noOfQueens; row++)
            {
                for(int col = 0; col < noOfQueens; col++)
                {
                    if(chessTable[row,col] == 1)
                    Console.Write("x ");
                    else Console.Write("- ");
                }

                Console.WriteLine();
            }

        }
    }
}
