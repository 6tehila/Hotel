﻿namespace Hotel.Entities
{
    public class Rooms
    {
        public int idRoom { get; set; }
        public int numOfBeds { get; set; }
        public bool IsFilled { get; set; }

        public Rooms(int idRoom, int numOfBeds, bool isfilled)
        {
            this.idRoom = idRoom;
            this.numOfBeds = numOfBeds;
            this.IsFilled = isfilled;
        }
    }
}
