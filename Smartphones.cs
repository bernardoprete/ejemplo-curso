namespace TiendaElectrodomesticos2
{
    internal class Smartphones : ProductoBase, Igarantizable
    {

        // Atributos

        public int camaraMP { get; set; }
        public int capacidadBateria { get; set; }



        // Constructores

        public Smartphones(int id, string nombre, float precio, string marca, int camaraMP, int capacidadBateria) : base(id, nombre, precio, marca)
        {

            this.camaraMP = camaraMP;
            this.capacidadBateria = capacidadBateria;
        }


        //Sobreescritura de metodos


        public override void MostrarDetalles()
        {
            Console.WriteLine($"Electrodomestico: ID: {id} - Nombre: {nombre} - Precio:{precio} - Marca:{marca} - Camara MPX:{camaraMP} - Capacidad bateria en MP: {capacidadBateria}"); // forma larga de sobreescribirlo sin usar base.

        }

        //Interfaz Igarantizable que solo devuelve un mensaje para ver si el producto tiene garantia y de cuanto

        public void ObtenerGarantia(string nombre)
        {

            Console.WriteLine($"Producto {nombre} tiene una garantia de 18 meses");
        }
    }
}