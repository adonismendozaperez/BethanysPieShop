namespace BethanysPieShop.Repositories
{
    //Libraries
    using System.Collections.Generic;
    using BethanysPieShop.Models;

    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> Categories
        {
            get
            {
                return new List<Category>
                {
                    new Category{CatergoryID = 1, CategoryName = "Fruit Pies", Description = "All-fruity pies"},
                    new Category{CatergoryID = 2, CategoryName = "Cheese cake", Description = "All-Cheese cake pies"},
                    new Category{CatergoryID = 3, CategoryName = "Seasonal Pies", Description = "All-Seasonal pies"}
                };
            }
        }
    }
}
