using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCBookBord.Models;
using MVCBookBord.ServiceReference1;

namespace MVCBookBord.ServiceLayer {
    public class ModelConvert {

        public static List<Table> ConvertBTable(BTable[] receivedTables) {
            List<Table> foundTables = new List<Table>();
            Table tempTable = null;
            foreach (BTable tab in receivedTables) {

                tempTable = new Table(tab.Id, tab.Seats, tab.Reserved);

                foundTables.Add(tempTable);

            }
            return foundTables;
        }
    }
}