namespace BethanysPieShop.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using BethanysPieShop.Models;
    using BethanysPieShop.Repositories;

    public class PieController : Controller
    {
        private  IPieRepository _pieRepository;      
        private  ICategoryRepository _categoryRepository;
        

        public ViewResult List([FromServices] IPieRepository PieRepository, [FromServices] ICategoryRepository CategoryRepository )
        {
            _pieRepository = PieRepository;
            _categoryRepository = CategoryRepository;

            return View(_pieRepository.Pies);
        }

    }
}
