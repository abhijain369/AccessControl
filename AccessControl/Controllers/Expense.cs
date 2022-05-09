using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccessControl.Controllers
{
    public class Expense
    {

        public int ExpenseId { get; set; }
        public double Amount { get; set; }
        public string Category { get; set; }
        public string Comments { get; set; }
        public bool IsApproved { get; set; }
    }
}
