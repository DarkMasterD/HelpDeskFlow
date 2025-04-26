using System.ComponentModel.DataAnnotations;

namespace HelpDeskFlow.Models
{
    public class Comentarios
    {
        [Key]
        public int id_comentario {  get; set; }
        public string contenido { get; set; }
        public TimeSpan fecha { get; set; }
        public int id_ticket { get; set; }
        public int id_usuario { get; set; }
    }
}
