using CriandoException.Entities.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriandoException.Entities
{
     class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime Checkout { get; set; }
        public DateTime Checkin { get; set; }

        public Reservation() 
        {
        }
        public Reservation(int roomNumber, DateTime checkin, DateTime checkout)
        {
            if (checkout <= checkin)
            {
                throw new DomainException("Check-out date must be after check-in date.");
            }
            RoomNumber = roomNumber;
            Checkin = checkin;
            Checkout = checkout;
        }

        public double Duration()
        {
            TimeSpan duration = Checkout.Subtract(Checkin);
            return (int) duration.TotalDays;
        }

        public void UpdateDates(DateTime checkin, DateTime checkout)
        {
            if (checkin < DateTime.Now || checkout < DateTime.Now)
            {
                throw new DomainException("Reservation dates for update must be future dates.");
            }
            if (checkout <= checkin)
            {
                throw new DomainException("Check-out date must be after check-in date.");
            }
            Checkin = checkin;
            Checkout = checkout;
        }

        public override string ToString()
        {
            return "Room "
                + RoomNumber
                + ", check-in: "
                + Checkin.ToString("dd/MM/yyyy")
                + ", check-out: "
                + Checkout.ToString("dd/MM/yyyy")
                + ", "
                + Duration()
                + " nights";
        }
    }
}
