using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NTD_Pie_Shop.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
