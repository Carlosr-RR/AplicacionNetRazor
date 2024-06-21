using AplicacionNetRazor.Datos;
using AplicacionNetRazor.Modelo;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AplicacionNetRazor.Pages.Cursos
{
    public class CrearModel : PageModel
    {
        private readonly AplicacionDbContext _contexto;

        public CrearModel(AplicacionDbContext contexto)
        { 
            _contexto = contexto;
        }

        [BindProperty]
        public Curso Curso { get; set; }

        [TempData] 

        public string Mensaje { get; set; }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost() 
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Curso.FechaCreacion = DateTime.Now;

            _contexto.Add(Curso);   
            await _contexto.SaveChangesAsync();
            Mensaje = "Curso Creado correctamente";
            return RedirectToPage("Index");
        }
    }
}
