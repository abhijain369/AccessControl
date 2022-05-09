using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccessControl.Models
{
    public class ExpenseModel
    {
            public int ExpenseId { get; set; }
            public double Amount { get; set; }
            public string Category { get; set; }
            public string Comments { get; set; }
            public bool IsApproved { get; set; }
            public bool IsAdmin { get; set; }

    }
}
