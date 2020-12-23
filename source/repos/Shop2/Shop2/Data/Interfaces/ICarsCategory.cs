using Shop2.Data.Models;
using System.Collections.Generic;

namespace Shop2.Data.Interfaces
{
    public interface ICarsCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
