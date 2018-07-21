namespace WebShop.Repositories
{
    //Libraries
    using System.Collections.Generic;
    using WebShop.Models;

    public interface ICategoryRepository
    {
        IEnumerable<Category> Categories { get; }
    }
}
