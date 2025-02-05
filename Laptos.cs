namespace TiendaElectrodomesticos2
{
    internal class Laptos : ProductoBase, Igarantizable
    {



        public int ram { get; set; }
        public string procesador { get; set; }


        // Constructores

        public Laptos(int id, string nombre, float precio, string marca, int ram, string procesador) : base(id, nombre, precio, marca)
        {

            this.ram = ram;
            this.procesador = procesador;
        }

        //Sobreescribir metodos


        public override void MostrarDetalles()
        {
            Console.WriteLine($"Electrodomestico: ID: {id} - Nombre: {nombre} - Precio:{precio} - Marca:{marca} - Ram: {ram} - Procesador: {procesador}"); // fprma larga de sobreescribirlo sin usar base.

        }

        //Interfaz Igarantizable que solo devuelve un mensaje para ver si el producto tiene garantia y de cuanto

        public void ObtenerGarantia(string nombre)
        {

            Console.WriteLine($"Producto {nombre} cuenta con una garantia de 12 meses");
        }
    }
}

