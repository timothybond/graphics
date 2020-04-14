using System.Collections.Generic;

namespace Tetris.Logic.Tetriminos
{
    public class S : Tetrimino
    {
        public override IReadOnlyList<Location> PieceLocations => throw new System.NotImplementedException();

        public override Color Color => Color.Green;

        public override bool RotateClockwise(Board board)
        {
            throw new System.NotImplementedException();
        }

        public override bool RotateCounterclockwise(Board board)
        {
            throw new System.NotImplementedException();
        }

        protected override IReadOnlyList<Offset> PieceOffsets(Rotation rotation)
        {
            throw new System.NotImplementedException();
        }
    }
}
