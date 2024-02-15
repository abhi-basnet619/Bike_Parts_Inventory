using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikePartsInventoryRecord.Data
{
    public class ApprovedItem
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required(ErrorMessage = "Please mention the name of task.")]
        public string ItemName { get; set; }

        [Required(ErrorMessage = "Give the required Quantity.")]
        public Guid ItemId { get; set; }
        public int Quantity { get; set; }
        public bool IsApproved { get; set; }
        public Guid TakenBy { get; set; }
        public string TakerName { get; set; }

        public Guid ApprovedBy { get; set; }

        public string ApproverName { get; set; }


    }
}
