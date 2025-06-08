using System.ComponentModel.DataAnnotations;

namespace Actividad3LengProg3.Models
{
    public class EstudianteViewModel
    {
        [Required(ErrorMessage ="Este campo no puede estar vacio")]
        [StringLength(60, MinimumLength =3, ErrorMessage ="La longitud del Nombre debe estar entre 3 y 60 caracteres")]
        public String NombreEstudiante { get; set; }

        [Required(ErrorMessage = "Este campo no puede estar vacio")]
        [EmailAddress(ErrorMessage ="Esta no es una dirección de correo electrónico valida")]
        public String CorreoElectronico { get; set; }

        public String Contrasena { get; set; }

        public String ConfirmarContrasena { get; set; }

        public String Matricula { get; set; }
    }
}
