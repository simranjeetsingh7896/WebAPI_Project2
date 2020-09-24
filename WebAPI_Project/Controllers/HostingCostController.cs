using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI_Project.Controllers
{
    public class HostingCostController : ApiController
    {
        // GET api/HostingCost/{id}
        public  IEnumerable<string>  Get(int id)
        {
            double fortnights = id / 14;
            double fortnightprice = (fortnights + 1) * 5.50;
            double HST = (fortnightprice * 13) / 100;
            double totalcost = fortnightprice + HST;
            string s1 = fortnights + " fortnights at $5.50/FN = $" + fortnightprice.ToString("#0.00") + " CAD";
            string s2 = "HST 13% = $" + Math.Round(HST, 2) + " CAD";
            string s3 = "Total = $" + Math.Round(totalcost, 2) + " CAD";
            return new string[] { s1, s2, s3 };
        }
    }
}
