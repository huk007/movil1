using System.ComponentModel;

namespace movil1.Common.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Aliment1
    {
        [Key]
        public int IdAliment { get; set; }

        [Required]
        public string Alimento { get; set; }

        public float Calorias { get; set; }

        public float Grasas { get; set; }

        public float Proteinas { get; set; }

        public float Carbohidratos { get; set; }

        [Display(Name = "Cantidad gr.")]
        public int Cantidad { get; set; }

        [ForeignKey(Porciones)]
        public int IdPorcion { get; set; }

        public Porciones Porciones { get; set; }

    }

    public class Porciones
    {
        [Key]
        public int IdPorcion { get; set; }

        public string Porcion { get; set; }

        public string Tipo { get; set; }

        [Display(Name = "Cantidad 1")]
        public int Cantidad1 { get; set; }

    }

    public class AlimentoDiario1
    {
        [Key]
        public int IdAlimentDiario { get; set; }

        [Required]
        public string AlimentoDiario { get; set; }

        public string Cantidad { get; set; }

        public int Calorias { get; set; }

        public float Grasa { get; set; }

        public float Proteinas { get; set; }

        public float Carbohidratos { get; set; }

        [Display(Name = "Fecha 1")]
        public DateTime Fecha1 { get; set; }

        [Display(Name = "Fecha 2")]
        public DateTime Fecha2 { get; set; }

        [Key]
        public int IdUser { get; set; }

        [Key]
        public int IdAperitivo { get; set; }

        [Key]
        public int IdAliment { get; set; }

    }

    public class Medidas1
    {
        [Key]
        public int IdMedidas { get; set; }

        [Required]
        public string Medidas { get; set; }

        [Display(Name = "Medida Cintura")]
        public float MedCintura { get; set; }

        [Display(Name = "Medida Pecho")]
        public float MedPecho { get; set; }

        [Display(Name = "Medida Cadera")]
        public float MedCaderas { get; set; }

        [Display(Name = "Medida Piernas")]
        public float MedPiernas { get; set; }

        [Display(Name = "Proporcion de Grasa")]
        public float PropGrasa { get; set; }


        public DateTime Fecha { get; set; }

        [Key]
        public int IdUser { get; set; }
    }

    public class Datos1
    {
        [Key]
        public int IdDatos { get; set; }

        [Required]
        public float Datos { get; set; }

        public float Peso { get; set; }

        public int Edad { get; set; }

        public float Talla { get; set; }

        [Display(Name = "Habito Fisico")]
        public float HabitoFisico { get; set; }

        public string Genero { get; set; }

        [Display(Name = "Fecha 3")]
        public DateTime Fecha3 { get; set; }

        [Key]
        public int Iduser { get; set; }
    }

    public class Aperitivo1
    {
        [Key]
        public int IdAperitivo { get; set; }

        public string Aperitivo { get; set; }

        [Display(Name = "Tipo de Aperitivo")]
        public string TipoAperitivo { get; set; }

        [Display(Name = "Hora de Aperitivo")]
        public TimeSpan HoraAperitivo { get; set; }
    }

    public class EntrenamientoDiario1
    {
        [Key]
        public int IdEntrenamientoDiario { get; set; }

        [Display(Name = "Entrenamiento Diario")]
        public string EntrenamientoDiario { get; set; }

        [Display(Name = "Nombre de Entrenamiento Diario")]
        public float NombreEntrenamientoDiario { get; set; }

        [Display(Name = "Caloria Gastada")]
        public float CalGastada { get; set; }

        [Display(Name = "Fecha 4")]
        public DateTime Fecha4 { get; set; }

        [Key]
        public int IdUser { get; set; }

        [Key]
        public int IdEntrenamiento { get; set; }
    }

    public class User1
    {
        [Key]
        public int IdUser { get; set; }

        [Required] 
        public string User { get; set; }

        public string Clave { get; set; }

        public string Nombres { get; set; }

        public string Dni { get; set; }

        public string Sexo { get; set; }

        public string Correo { get; set; }
    }

    public class Hidratacion1
    {
        [Key]
        public int IdHidratacion { get; set; }

        public bool Hidratacion { get; set; }

        public float CantAgua { get; set; }

        [Key]
        public int IdUser { get; set; }
    }

    public class Entrenamiento1
    {
        [Key]   
        public int IdEntrenamiento { get; set; }

        public string Entrenamiento { get; set; }

        public string NombreEntrenamiento { get; set; }

        public float CaloriasQuemad { get; set; }
    }

}
