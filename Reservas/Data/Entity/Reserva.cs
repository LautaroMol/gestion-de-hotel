﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservas.BData.Data.Entity
{
	public class Reserva
	{
		public int Id { get; set; }
		[Required]
		public int NroReserva { get; set; }
		[Required(ErrorMessage = "La Fecha de inicio es Obligatoria")]
		public DateTime Fecha_inicio { get; set; }
		[Required(ErrorMessage = "La Fecha de fin es Obligatoria")]
		public DateTime Fecha_fin { get; set; }
		[Required(ErrorMessage = "El Dni del dueño de la reserva es obligatorio")]
		public int Dni { get; set; }
        [Required(ErrorMessage = "El Dni de los huespedes es obligatorio")]
        public List<Huesped> Huespedes { get; set; } = new List<Huesped>();
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "El campo {0} es requerido")]
        public int nhabs { get; set; }
        public List<Habitacion> Habitaciones { get; set; } = new List<Habitacion>();	
    }
}
