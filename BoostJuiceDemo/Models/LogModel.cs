using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoostJuiceDemo.Models
{
    public class LogModel
    {
        public int id { get; set; }
        public string webHookId { get; set; }
        public string webOrderId { get; set; }
        public string status { get; set; }
        public string user { get; set; }
        public string remoteIpaddress { get; set; }
        public DateTime createdOn { get; set; }
        public bool orderExist { get; set; }
    }

}
