namespace BethanysPieShop.Repositories
{
    //Libraries
    using System.Collections.Generic;
    using BethanysPieShop.Models;

    public interface ICategoryRepository
    {
        IEnumerable<Category> Categories { get; }
    }
}
