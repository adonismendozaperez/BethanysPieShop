namespace WebShop.Repositories
{
    //Libraries
    using System;
    using System.Collections.Generic;
    using WebShop.Models;

    public class MockPieRepository : IPieRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

        public IEnumerable<Pie> Pies
        {
            get
            {
                return new List<Pie>
                {
                    new Pie{PieID = 1, Name = "Strawberry Pie", Price = 499.95M, ShortDescription ="Test"},
                    new Pie{PieID = 2, Name = "Cheese cake", Price = 599.95M, ShortDescription ="Test"},
                    new Pie{PieID = 3, Name = "Pumpkin Pie", Price = 699.95M, ShortDescription ="Test"}
                };
            }
        }

        public IEnumerable<Pie> PiesOfTheWeek => throw new NotImplementedException();

        public Pie GetPieByID(int pieID)
        {
            throw new NotImplementedException();
        }
    }
}
