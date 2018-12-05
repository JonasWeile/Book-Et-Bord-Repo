using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCBookBord.ServiceReference1;
using MVCBookBord.Models;


namespace MVCBookBord.ServiceLayer {
    public class BestilBordService {
       public List<Table> GetAllFreeTables() {
            BookingServiceClient bsc = new BookingServiceClient();
            var foundBTables = bsc.GetAllFreeTables();
            List<Table> allTables = ModelConvert.ConvertBTable(foundBTables);
            return allTables;
        }

    }
}