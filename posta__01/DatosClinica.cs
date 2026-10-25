using System;
using System.Collections.Generic;

namespace posta__01
{
    // =====================================================
    //  Clase que representa un registro completo de cita
    // =====================================================
    public class RegistroCita
    {
        // --- Datos de Paciente_Cita ---
        public string Nombre { get; set; } = "";
        public string Apellido { get; set; } = "";
        public string DNI { get; set; } = "";
        public string SIS { get; set; } = "";
        public string Especialidad { get; set; } = "";
        public string Fecha { get; set; } = "";
        public string Hora { get; set; } = "";
        public string Costo { get; set; } = "S/. 0.00";

        // --- Datos de Tópico ---
        public string Peso { get; set; } = "";
        public string Talla { get; set; } = "";
        public string IMC { get; set; } = "";
        public string Temperatura { get; set; } = "";
        public string Presion { get; set; } = "";
        public string ClasificacionTemp { get; set; } = "";
        public string ClasificacionPresion { get; set; } = "";

        // --- Datos de Doctor ---
        public string Diagnostico { get; set; } = "";
        public string Medicamento { get; set; } = "";
    }

    // =====================================================
    //  Almacén estático compartido entre formularios
    // =====================================================
    public static class DatosClinica
    {
        public static List<RegistroCita> Citas { get; } = new List<RegistroCita>();

        /// <summary>
        /// Devuelve el último registro agregado, o null si no hay ninguno.
        /// </summary>
        public static RegistroCita? UltimaCita =>
            Citas.Count > 0 ? Citas[Citas.Count - 1] : null;
    }
}
