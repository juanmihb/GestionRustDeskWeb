using System.ComponentModel.DataAnnotations;

namespace GestionRustDeskWeb.Models
{
    public class RustDeskViewModel
    {
        [Required(ErrorMessage = "La IP o nombre del equipo es obligatorio")]
        [Display(Name = "IP o Nombre del Equipo Remoto")]
        public string Destino { get; set; } = string.Empty;

        [Required(ErrorMessage = "El usuario administrador es obligatorio")]
        [Display(Name = @"Usuario Administrador (DOMINIO\usuario)")]
        public string Usuario { get; set; } = string.Empty;

        [Required(ErrorMessage = "La contraseña de administrador es obligatoria")]
        [DataType(DataType.Password)]
        [Display(Name = "Contraseña Administrador")]
        public string PasswordAdmin { get; set; } = string.Empty;

        [Display(Name = "Nueva Contraseña para RustDesk")]
        [DataType(DataType.Password)]
        public string? NuevaPassRustDesk { get; set; }

        // Propiedades de resultado
        public string? IdResultado { get; set; }
        public bool PassActualizada { get; set; }
        public string? MensajeError { get; set; }
        public bool Exito { get; set; }
    }
}