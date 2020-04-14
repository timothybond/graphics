using System.Collections.Generic;
using System.Linq;

namespace Tetris.Logic
{
    public abstract class Tetrimino
    {
        public Location Location { get; protected set; }

        public abstract IReadOnlyList<Location> PieceLocations { get; }

        public Rotation Rotation { get; protected set; }

        public abstract Color Color { get; }

        /// <summary>
        /// Rotates the Tetrimino clockwise.
        /// </summary>
        /// <param name="board">The current state of the board.</param>
        /// <returns><c>true</c> if it has room to rotate, <c>false</c> if it's blocked by something.</returns>
        public bool RotateClockwise(Board board)
        {
            var next = this.RotateClockwise();

            if (next.PieceLocations.All(board.IsOpenSpace))
            {

            }

            return false;
        }

        /// <summary>
        /// Rotates the Tetrimino counterclockwise.
        /// </summary>
        /// <param name="board">The current state of the board.</param>
        /// <returns><c>true</c> if it has room to rotate, <c>false</c> if it's blocked by something.</returns>
        public bool RotateCounterclockwise(Board board)
        {

        }
        
        /// <summary>
        /// Returns a new tetrimino that is the current one rotated clockwise.
        /// </summary>
        protected abstract Tetrimino RotateClockwise();

        /// <summary>
        /// Returns a new tetrimino that is the current one rotated counterclockwise.
        /// </summary>
        protected abstract Tetrimino RotateCounterclockwise();
        
        /// <summary>
        /// Moves the Tetrimino down by one space.
        /// <param name="board">The current state of the board.</param>
        /// <returns><c>true</c> if it has room to drop, <c>false</c> if it lands on something.</returns>
        /// </summary>
        public bool Drop(Board board)
        {
            if (!this.CanDrop(board))
            {
                return false;
            }

            this.Location = this.Location + Offset.Down;
            return true;
        }

        protected abstract IReadOnlyList<Offset> PieceOffsets(Rotation rotation);

        private bool CanDrop(Board board)
        {
            foreach (var location in this.PieceLocations)
            {
                if (location.Y == 0 || board[location + Offset.Down] != Color.None)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
