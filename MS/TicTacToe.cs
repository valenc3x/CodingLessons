using System;

namespace MS
{
    public class TicTactoe{

        // Time: O(n)
        public static bool CheckBoard(int[][] b){
            for (int k=0; k<b[0].Length; k++)
            {
                if (b[k][0] == 0 || b[0][k] == 0) {
                    continue;
                }
                // horizontal line
                if (b[k][0] == b[k][1]  && b[k][0] == b[k][2]) {
                    return true;
                }
                // vertical line
                if (b[0][k] == b[1][k]  && b[0][k] == b[2][k]) {
                    return true;
                }
            }
            // down diagonal
            if (b[0][0] != 0) {
                if (b[0][0] == b[1][1]  && b[0][0] == b[2][2]) {
                    return true;
                }
            }
            // up diagonals
            if (b[2][0] != 0) {
                if (b[2][0] == b[1][1]  && b[2][0] == b[0][2]) {
                    return true;
                }
            }
            return false;
        }

        public static void Main(){

            // one line
            int[][] board = new int[][] {
                new int[] {1, 0, 1},
                new int[] {0, 0, 0},
                new int[] {0, 0, 0}
            };
            Console.WriteLine( CheckBoard(board) );

            // line down
            board = new int[][] {
                new int[] {1, 0, 0},
                new int[] {1, 0, 0},
                new int[] {1, 0, 0}
            };
            Console.WriteLine( CheckBoard(board) );

            // diagonal
            board = new int[][] {
                new int[] {1, 0, 0},
                new int[] {0, 1, 0},
                new int[] {0, 0, 1}
            };
            Console.WriteLine( CheckBoard(board) );

            // not finished
            board = new int[][] {
                new int[] {1, 0, 0},
                new int[] {0, 1, 1},
                new int[] {1, 0, 0}
            };
            Console.WriteLine( CheckBoard(board) );
        }
    }
}
