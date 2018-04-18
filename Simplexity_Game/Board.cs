﻿using System;

namespace Simplexity_Game {
    /// <summary>
    /// Class that creates a board and manages it's win condition
    /// </summary>
    public class Board {
        // Bi-dimensional array that will serve as a board
        Piece[,] BoardArray { get; }

        /// <summary>
        /// Constructor for the Board, initializes the array
        /// </summary>
        public Board() {
            BoardArray = new Piece[7, 7];
        }

        /// <summary>
        /// This method will try to place the piece on the given column and
        /// return true or false according to the possibilities
        /// </summary>
        public bool PlacePiece(Piece piece, int column) {
            // Starts at true because the player will probably give as an input
            // a possible column to play
            bool canPlay = true;
            // Calls the private method to see where the piece will be placed
            int row = CheckColumn(column);

            // If the row is a possible one it will place the piece there
            if ((row >= 0) && (row < 7)) {
                BoardArray[row, column] = piece;
            } else {

                // If not, gives the return value a false
                canPlay = false;
            }


            return canPlay;
        }

        /// <summary>
        /// This method will check at which position 
        /// </summary>
        private int CheckColumn(int column) {
            // Starts at -1 so that it will return an error by default, any
            // value that's not between 0 and 6 can be considered an error
            // so we give it -1 because it's impossible to have negative values
            int row = -1;

            // Checks the given column for the spare space
            for (int i = 0; i < 7; i++) {

                // If the current space is null will break the cicle and 
                // return it
                if (BoardArray[i, column] == null) {
                    row = i;
                    break;
                }
            }

            return row;
        }
    }
}