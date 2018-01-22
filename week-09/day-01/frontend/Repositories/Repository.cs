using Frontend.Entities;
using Frontend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frontend.Repositories
{
    public class Repository
    {
        public LogContext LC { get; set; }

        public Repository(LogContext lc)
        {
            LC = lc;
        }

        public void AddNewLog(string endpointName, Item item)
        {
            string returnData = "";
            if (item.Numbers !=null)
            {
                foreach (var number in item.Numbers)
                {
                    returnData += number.ToString() + " ";
                }
            }
            else
            {
                returnData = item.Until.ToString();
            }
            

            var newLog = new Log();
            newLog.Endpoint = endpointName;
            newLog.CreatedAt = DateTime.Now;
            newLog.Data = returnData;
            LC.Logs.Add(newLog);
            LC.SaveChanges();
        }

        public void AddNewLog(string endpointName)
        { 
            var newLog = new Log();
            newLog.Endpoint = endpointName;
            newLog.CreatedAt = DateTime.Now;
            LC.Logs.Add(newLog);
            LC.SaveChanges();
        }

        public void AddNewLog(string endpointName, string input)
        {
            var newLog = new Log();
            newLog.Endpoint = endpointName;
            newLog.CreatedAt = DateTime.Now;
            newLog.Data = input;
            LC.Logs.Add(newLog);
            LC.SaveChanges();
        }

        public List<Log> GetAll()
        {
            return LC.Logs.ToList();
        }
    }
}
