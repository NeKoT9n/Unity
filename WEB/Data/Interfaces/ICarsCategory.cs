using System.Collections.Generic;
using WEB.Data.Models;

namespace WEB.Data.Interfaces
{
    public interface ICarsCategory
    {
        
        IEnumerable<Category> AllCategories { get; }
    }
}