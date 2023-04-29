using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using P2_2020ML603_2020VR650.Models;

namespace P2_2020ML603_2020VR650.Controllers
{
    public class CasosController : Controller
    {

        private readonly covidDbContext _covidContext;

        public CasosController(covidDbContext covidContext)
        {
            _covidContext = covidContext;
        }



        public IActionResult Index()
        {
            ViewData["listaDepartamento"] = new SelectList(ListarDepartamentos(), "id_departamento", "nombre_departamento");
            ViewData["listaGenero"] = new SelectList(ListarGenero(), "id_genero", "nombre");
            ViewData["listadoCasos"] = listarCasos();

            return View();
        }

        public IActionResult InsertarCasos(Casos nuevoCasos)
        {
            _covidContext.Add(nuevoCasos);
            _covidContext.SaveChanges();
            return RedirectToAction("Index");
        }


        // Utils 
        public List<Departamentos> ListarDepartamentos()
        {
            var listaDepartamento = (from Departamentos in _covidContext.Departamentos select Departamentos).ToList();

            return listaDepartamento;
        }

        public List<Genero> ListarGenero()
        {

            var listaGenero = (from Genero in _covidContext.Genero select Genero).ToList();

            return listaGenero;

        }

        public List<CasosReportados> listarCasos()
        {
            List<CasosReportados> listadoCasos = (from c in _covidContext.Casos
                                                   join d in _covidContext.Departamentos on c.id_departamento equals d.id_departamento
                                                   join g in _covidContext.Genero on c.id_genero equals g.id_genero

                                                   select new CasosReportados
                                                   {
                                                       departamento = d.nombre_departamento,
                                                       genero = g.nombre,
                                                       confirmados = c.casos_confirmados,
                                                       recuperados = c.casos_recuperados,
                                                       fallecidos = c.fallecidos
                                                   }).ToList();

            return listadoCasos;
        }
    }

    public class CasosReportados
    {
        public string? departamento { get; set; }
        public string? genero { get; set; }
        public int? confirmados { get; set; }
        public int? recuperados { get; set; }
        public int? fallecidos { get; set; }
    }

}
