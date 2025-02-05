namespace TiendaElectrodomesticos2
{
    internal class ProductoBase
    {

        public int id { get; set; }
        public string nombre { get; set; }

        public float precio { get; set; }

        public string marca { get; set; }

        // Constructores


        public ProductoBase(int id, string nombre, float precio, string marca)
        {


            this.id = id;
            this.nombre = nombre;
            this.precio = precio;
            this.marca = marca;
        }


        //Metodos

        //Virtual 1er metodo

        public virtual void MostrarDetalles()
        {

            Console.WriteLine($"ID : {id} - Nombre: {nombre} - Precio: {precio} - Marca: {marca}");
        }


        // 2do metodo

        public float AplicarDescuento(float porcentaje)
        {

            precio -= precio * (porcentaje / 100);
            return precio;

        }


    }
}