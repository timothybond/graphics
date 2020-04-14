using System.Collections.Generic;

namespace Tetris.Logic.Tetriminos
{
    public class O : Tetrimino
    {
        public override IReadOnlyList<Location> PieceLocations => throw new System.NotImplementedException();

        public override Color Color => Color.Yellow;

        public override bool RotateClockwise(Board board)
        {
            return true;
        }

        public override bool RotateCounterclockwise(Board board)
        {
            return true;
        }

        protected override IReadOnlyList<Offset> PieceOffsets(Rotation rotation)
        {
            throw new System.NotImplementedException();
        }
    }
}
