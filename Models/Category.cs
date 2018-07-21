namespace WebShop.Models
{
    //Libraries
    using System.Collections.Generic;

    public class Category
    {
        public int CatergoryID { get; set; }

        public string CategoryName { get; set; }

        public string Description { get; set; }

        public List<Pie> Pies { get; set; }
    }
}
