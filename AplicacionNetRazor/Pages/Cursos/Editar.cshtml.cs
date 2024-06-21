using AplicacionNetRazor.Datos;
using AplicacionNetRazor.Modelo;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AplicacionNetRazor.Pages.Cursos
{
    public class EditarModel : PageModel
    {
        private readonly AplicacionDbContext _contexto;
        public EditarModel(AplicacionDbContext contexto)
        {
            _contexto = contexto;
        }

        [BindProperty]
        public Curso Curso { get; set; }

        [TempData]

        public string Mensaje { get; set; }

        public async Task OnGet(int id)
        {
            Curso = await _contexto.Curso.FindAsync(id);
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                var CursoDesdeDB = await _contexto.Curso.FindAsync(Curso.Id);

                CursoDesdeDB.NombreCurso = Curso.NombreCurso;
                CursoDesdeDB.CantidadClases = Curso.CantidadClases;    
                CursoDesdeDB.Precio = Curso.Precio;

                await _contexto.SaveChangesAsync();
                Mensaje = "Curso Editado correctamente";
                return RedirectToPage("Index");
            }

            return RedirectToPage();
        }
    }
}
