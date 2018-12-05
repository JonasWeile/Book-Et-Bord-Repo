using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCBookBord.Models {
    public class Table {
        public int Id { get; set; }
        public int Seats { get; set; }
        public bool Reserved { get; set; }

        public Table(int id, int seats, bool reserved) {
            Id = id;
            Seats = seats;
            Reserved = reserved;
        }
    }
}