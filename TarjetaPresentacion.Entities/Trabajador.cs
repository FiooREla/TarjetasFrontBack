namespace TarjetaPresentacion.Entities
{
    public class Trabajador
    {
        public string vendor { get; set; }
        public string apellidopaterno { get; set; }
        public string apellidomaterno { get; set; }
        public string nombres { get; set; }
        public string sexo { get; set; }
        public string puesto { get; set; }
        public string direccionvendor { get; set; }
        public string direccionnumero { get; set; }
        public string telefonocelular { get; set; }
        public string nombrecorreoelectronico { get; set; }
        public string columna4 { get; set; }
        public string gerencia { get; set; }
        public string area { get; set; }
        public string subgerencia { get; set; }

        public Trabajador()
        {
            this.vendor = "";
            this.apellidopaterno = "";
            this.apellidomaterno = "";
            this.nombres = "";
            this.sexo = "";
            this.puesto = "";
            this.direccionvendor = "";
            this.direccionnumero = "";
            this.telefonocelular = "";
            this.nombrecorreoelectronico = "";
            this.columna4 = "";
            this.gerencia = "";
            this.area = "";
            this.subgerencia = "";
        }

    }
}
