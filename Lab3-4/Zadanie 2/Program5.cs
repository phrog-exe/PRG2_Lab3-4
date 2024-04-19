using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_4.Zadanie_2
{
    enum SeatStatus
    {
        Available,
        Reserved,
        Occupied
    }    
    
    class Program5
    {
        static void Main(string[] args)
        {
            SeatStatus[] seats = new SeatStatus[10];

            
            for (int i = 0; i < seats.Length; i++)
            {
                seats[i] = SeatStatus.Available;
            }

            
            int seatNumber = 5;
            seats[seatNumber] = SeatStatus.Reserved;

            Console.WriteLine($"Seat {seatNumber} status: {seats[seatNumber]}");
        }
    }
}
