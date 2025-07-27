using Microsoft.AspNetCore.Mvc;
using TastyPieShop.Models;
using TastyPieShop.ViewModels;

namespace TastyPieShop.Controllers
{
    public class PieController : Controller
    {

        private readonly IPieRepository _pieRepository;
        private readonly ICategoryRepository _categoryRepository;

        public PieController(IPieRepository pieRepository, ICategoryRepository categoryRepository)
        {
            _pieRepository = pieRepository;
            _categoryRepository = categoryRepository;
        }

        public IActionResult List()
        {
            var pieListVM = new PieListViewModel(_pieRepository.AllPies, "Cheese cakes");
          
            return View(pieListVM);
        }
    }
}
