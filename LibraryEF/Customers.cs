using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LibraryEF
{
    public class Customers
    {
        [Key]
        public string CustomerID { get; set; }
        public string CompanyName{ get; set; }
    }
}
