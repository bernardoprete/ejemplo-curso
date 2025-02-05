namespace TiendaElectrodomesticos2
{
    internal class Cliente
    {

        public string nombre { get; set; }
        public string email { get; set; }
        List<ProductoBase> ProductosComprados { get; set; } = new List<ProductoBase>(); // crear una lista que pueda meter cualquier producto que compre el cliente.


        // Constructores

        public Cliente(string nombre, string email)
        {

            this.nombre = nombre;
            this.email = email;



        }

        //METODOS

        // Permitir que el cliente agregue productos a su lista de compras y calcular el total.


        public void AgregarProducto(ProductoBase producto)
        {
            ProductosComprados.Add(producto);
            Console.WriteLine($"Se agrego a la lista de {nombre} el producto {producto.nombre}");



        }
        // Calcular el total de la lista de productos de tipo ProductoBase.
        public int CalcularTotalCompra()
        {
            int total = 0;
            foreach (ProductoBase item in ProductosComprados)
            {
                total += (int)item.precio;
            }
            return total;
        }

        //Metodo para mostrar todos los datos de la lista (carrito).

        public void Mostrarcarrito()
        {

            foreach (ProductoBase item in ProductosComprados)
            {
                item.MostrarDetalles();

            }


        }






    }
}








