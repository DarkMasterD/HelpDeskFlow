using HelpDeskFlow.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HelpDeskFlow.Controllers
{
    public class TicketController : Controller
    {
        private readonly HelpDeskFlowContext _HelpDeskFlowContext;

        public TicketController(HelpDeskFlowContext context)
        {
            _HelpDeskFlowContext = context;
        }
        public IActionResult ListarTicket()
        {
            return View();
        }
        [HttpGet]
        public IActionResult NuevoTicket() 
        {
            var prioridades = new List<SelectListItem>
            {
                new SelectListItem{ Text = "Abierto", Value = "Abierto" },
                new SelectListItem{ Text = "En Proceso", Value = "En Proceso" },
                new SelectListItem{ Text = "Resuelto", Value = "Resuelto" },
                new SelectListItem{ Text = "Cerrado", Value = "Cerrado" }
            };

            ViewBag.Prioridades = prioridades;
            return View();
        }
        [HttpPost]
        public IActionResult NuevoTicket([FromForm] Tickets ticket) 
        {
            ticket.id_usuario_cliente = Convert.ToInt32(HttpContext.Session.GetInt32("id_usuario"));
            ticket.fecha_creacion = DateTime.Now;

            _HelpDeskFlowContext.Tickets.Add(ticket);
            _HelpDeskFlowContext.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
    }
}
