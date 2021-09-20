using Microsoft.AspNetCore.Mvc;
using ProyectoOctavoSEP.Models.Data;
using System.Linq;
namespace ProyectoOctavoSEP.Controllers
{
    public class TeacherController : Controller
    {
        private readonly DataContext _context;
        public TeacherController(DataContext context)
        {
            _context = context;
        }
  
        
        public IActionResult Index()
        {
           var teacher = _context.Teachers.ToList();

           return View();
        }
    }
}
