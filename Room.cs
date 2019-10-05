namespace CreateClass {
    internal class Room
    {
        private int RoomNumber { get; }

        public Room(int roomNumber)
        {
            RoomNumber = roomNumber;
        }

        public override string ToString()
        {
            return ",room number: " + RoomNumber.ToString();
        }
    }
}