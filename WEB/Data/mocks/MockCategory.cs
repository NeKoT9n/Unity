using System;
using System.Collections.Generic;
using WEB.Data.Interfaces;
using WEB.Data.Models;

namespace WEB.Data.mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category { Name = "Ёлектромобили" },
                    new Category { Name = " лассика"},
                };
            }
        }
    }
}