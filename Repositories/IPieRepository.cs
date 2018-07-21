namespace BethanysPieShop.Repositories
{
    //Libraries
    using System.Collections.Generic;
    using BethanysPieShop.Models;

    public interface IPieRepository
    {
        IEnumerable<Pie> Pies { get; }

        IEnumerable<Pie> PiesOfTheWeek { get; }

        Pie GetPieByID(int pieID);
    }
}
