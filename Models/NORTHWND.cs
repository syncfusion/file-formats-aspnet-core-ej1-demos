using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace samplebrowser.Models
{
    public partial class Orders
    {
        [Key]
        public int OrderID { get; set; }
        public string CustomerID { get; set; }
        public int EmployeeID { get; set; }
        public decimal? Freight { get; set; }
        public DateTime? OrderDate { get; set; }
        public string ShipCity { get; set; }
    }
}
