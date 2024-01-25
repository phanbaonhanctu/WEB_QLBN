using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WEB_QLBN.Models
{
    public class Benhnhan
    {
        public Guid id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public string gender { get; set; }
        public DateTime time { get; set; }
        public string ppdt { get; set; }
    }
}