using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace PracticaCalificada1.Models
{
    public class Sale
    {
        [Key]
        public int SalesID { get; set; }
        public int SalesPersonID { get; set; }
        public int CustomerID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
    }
}
