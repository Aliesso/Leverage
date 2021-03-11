using Leverage.Data;
using Leverage.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Leverage.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminSection1Controller : Controller
    {
        public LgContext _context;
        private readonly IWebHostEnvironment _env;
        public AdminSection1Controller(LgContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public IActionResult Index()
        {
            return View(_context.Start.ToList());
        }
        public IActionResult Edit(int? id)
        {
            if (id == null) return 
                    NotFound();
            Start selectedStart=_context.Start.FirstOrDefault(s => s.ID == id);
            return View(selectedStart);
        }
        [HttpPost]
        public IActionResult Edit(int? id,Start start,IFormFile Photo)
        {
            if (id == null)
                return NotFound();
            if (Photo!=null)
            {
                //Image Upload
                string imgName = Guid.NewGuid() + "_" + Photo.FileName;
                string uploadLink = Path.Combine(_env.WebRootPath, "uploads");
                string filePath = Path.Combine(uploadLink, imgName);

                using FileStream file = new FileStream(filePath, FileMode.Create);
                Photo.CopyTo(file);
                start.PhotoURl = imgName;
            }

            _context.Start.Update(start);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
