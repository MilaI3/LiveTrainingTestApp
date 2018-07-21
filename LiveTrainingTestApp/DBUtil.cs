using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LiveTrainingTestApp
{
    public class DBUtil
    {
        public void ConnectToDatabase()
        {
            Random rnd = new Random();
            int delay = rnd.Next(2000, 7000);
            System.Threading.Thread.Sleep(delay);
        }

        public void RetrieveData()
        {
            Random rnd = new Random();
            int delay = rnd.Next(2000, 5000);
            System.Threading.Thread.Sleep(delay);
            throw new System.Web.HttpException("Exception occurred reading data.");

        }


    }
}