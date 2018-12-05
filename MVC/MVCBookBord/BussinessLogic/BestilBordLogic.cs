using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCBookBord.ServiceLayer;
using MVCBookBord.Models;

namespace MVCBookBord.BussinessLogic {
    public class BestilBordLogic {
        public List<Table> GetAllFreeTables() {
            List<Table> foundTables = new List<Table>();

            BestilBordService bbs = new BestilBordService();
            foundTables = bbs.GetAllFreeTables();
            return foundTables;
        }
    }
}