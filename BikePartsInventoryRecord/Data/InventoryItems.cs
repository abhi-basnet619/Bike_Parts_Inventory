using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikePartsInventoryRecord.Data
{
   public  class InventoryItems
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required(ErrorMessage = "You need to mention the name of task.")]
        public string ItemName { get; set; }

        [Required(ErrorMessage = "You need to enter the Quantity.")]
        public int Quantity { get; set; }

        public string AddedBy { get; set; }

    }
}
