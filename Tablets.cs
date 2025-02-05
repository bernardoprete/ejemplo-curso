namespace TiendaElectrodomesticos2
{
    internal class Tablets : ProductoBase, Igarantizable
    {

        // Atributos


        public float tamanioPantalla { get; set; }
        public bool tieneLapiz { get; set; }


        //Constructores

        public Tablets(int id, string nombre, float precio, string marca, int tamanioPantalla, bool tieneLapiz) : base(id, nombre, precio, marca)
        {

            this.tamanioPantalla = tamanioPantalla;
            this.tieneLapiz = tieneLapiz;
        }

        //Sobreescritura de metodos


        public override void MostrarDetalles()
        {
            Console.WriteLine($"Electrodomestico: ID: {id} - Nombre: {nombre} - Precio:{precio} - Marca:{marca} - Tamanio Pantalla:{tamanioPantalla} - Lapiz: {tieneLapiz}"); // forma larga de sobreescribirlo sin usar base.

        }


        //Interfaz Igarantizable que solo devuelve un mensaje para ver si el producto tiene garantia y de cuanto

        public void ObtenerGarantia(string nombre)
        {

            Console.WriteLine($"Producto{nombre} cuenta con una garantia de 6 meses");
        }
    }
}
