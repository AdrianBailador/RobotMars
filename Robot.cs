namespace RobotMars
{
    public class Robot
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Direction Facing { get; set; }


        public void TurnLeft()
        {
            switch (Facing)
            {
                case Direction.North:
                    Facing = Direction.West;
                    break;
                case Direction.West:
                    Facing = Direction.South;
                    break;
                case Direction.South:
                    Facing = Direction.East;
                    break;
                case Direction.East:
                    Facing = Direction.North;
                    break;
            }
        }

        public void TurnRight()
        {
            switch (Facing)
            {
                case Direction.North:
                    Facing = Direction.East;
                    break;
                case Direction.East:
                    Facing = Direction.South;
                    break;
                case Direction.South:
                    Facing = Direction.West;
                    break;
                case Direction.West:
                    Facing = Direction.North;
                    break;
            }
        }

        public void MoveForward()
        {
            switch (Facing)
            {
                case Direction.North:
                    Y++;
                    break;
                case Direction.East:
                    X++;
                    break;
                case Direction.South:
                    Y--;
                    break;
                case Direction.West:
                    X--;
                    break;
            }
        }
    }

    public enum Direction
    {
        North,
        East,
        South,
        West
    }
}