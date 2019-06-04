namespace movil1.Common.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    
    public class Aliment
    {
        [Key]
        public int IdAliment { get; set; }

        [Required]
        public string Alimento { get; set; }

        public float Calorias { get; set; }

        public float Grasas { get; set; }

        public float Proteinas { get; set; }

        public float Carbohidratos { get; set; }

        public int IdPorcion { get; set; }

    }

    public class Porciones
    {
        [Key]
        public int IdPorcion { get; set; }

        public string Porcion { get; set; }

        public string Tipo { get; set; }

        public int Cantidad { get; set; }

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

        public DateTime Fecha1 { get; set; }

        public DateTime Fecha2 { get; set; }

        public int IdUser { get; set; }

        public int IdAperitivo { get; set; }

        public int IdAliment { get; set; }

    }

    public class Medidas1
    {
        [Key]
        public int IdMedidas { get; set; }

        [Required]
        public string Medidas { get; set; }

        public float MedCintura { get; set; }

        public float MedPecho { get; set; }

        public float MedCaderas { get; set; }

        public float MedPiernas { get; set; }

        public float PropGrasa { get; set; }

        public DateTime Fecha { get; set; }

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

        public float HabitoFisico { get; set; }

        public string Genero { get; set; }

        public int Iduser { get; set; }

        public DateTime Fecha3 { get; set; }

    }

    public class Aperitivo1
    {
        [Key]
        public int IdAperitivo { get; set; }

        public string Aperitivo { get; set; }

        public string TipoAperitivo { get; set; }

        public TimeSpan HoraAperitivo { get; set; }
    }

    public class EntrenamientoDiario1
    {
        [Key]
        public int IdEntrenamientoDiario { get; set; }

        public string EntrenamientoDiario { get; set; }

        public float NombreEntrenamientoDiario { get; set; }

        public float CalGastada { get; set; }

        public DateTime Fecha4 { get; set; }

        public int IdUser { get; set; }

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
