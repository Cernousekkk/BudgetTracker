using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetTracker
{
    public class Categories
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public decimal Limit { get; set; }

        public Categories(string name)
        {
            name = Name;
        }
    }
}
