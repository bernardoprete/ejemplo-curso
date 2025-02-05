/*Crear un sistema para gestionar productos electrónicos en una tienda. La tienda vende dispositivos como laptops, smartphones y tablets. Cada uno tiene características específicas, pero todos comparten atributos y métodos comunes.
Requisitos:
Clase Base:
Crear una clase base Producto.
Atributos: ID, Nombre, Precio, Marca.
Métodos: MostrarDetalles() (virtual), AplicarDescuento(float porcentaje).
Clases Derivadas (Herencia):
Crear tres clases derivadas: Laptop, Smartphone, y Tablet.
Cada clase tiene un atributo adicional:
Laptop: RAM (int), Procesador (string)
Smartphone: CamaraMP (int), CapacidadBateria (int)
Tablet: TamanioPantalla (float), TieneLápiz (bool)
Sobrescribir el método MostrarDetalles() para incluir los atributos específicos de cada clase.
Interfaz:
Crear una interfaz IGarantizable con el método ObtenerGarantia().
Implementar esta interfaz en las clases derivadas.
Asociación:
Crear una clase Cliente con los atributos: Nombre, Email y una lista de ProductosComprados (List<Producto>). ok 
Agregar un método AgregarProducto(Producto producto).ok
Lista de Productos:
Crear una lista de productos disponibles en la tienda y mostrar sus detalles.
Permitir que el cliente agregue productos a su lista de compras y calcular el total. */



using TiendaElectrodomesticos2;

//Crear Productos


internal class Program
{
    private static void Main(string[] args)
    {
        Laptos laptop1 = new Laptos(1, "Dell Inspiron", 5000, "Dell", 8, "Intel I7");
        Laptos laptop2 = new Laptos(2, "MacBook Air", 10000, "Apple", 8, "M1");
        Laptos laptop3 = new Laptos(3, "macBook Pro", 20000, "Apple", 8, "M2");
        Tablets tablet1 = new Tablets(1, "Aipad 10", 25000, "Apple", 4, false);
        Tablets tablet2 = new Tablets(2, "Aipad Pro", 30000, "Apple", 4, true);
        Smartphones smartphone1 = new Smartphones(1, "Iphone 15 Pro", 50000, "Apple", 12, 5000);
        Smartphones smartphone2 = new Smartphones(2, "Iphone 16 ", 55000, "Apple", 10, 4800);
        Smartphones smartphone3 = new Smartphones(3, "Samsung Galaxy S24", 60000, "Samsung", 50, 6000);

        // Crear una lista de productos disponibles en la tienda 

        List<ProductoBase> listaTienda = new List<ProductoBase>();


        // Agregar todos los productos a la lista.

        Console.WriteLine("productos con garantia :");
        listaTienda.Add(smartphone1);
        smartphone1.ObtenerGarantia(smartphone1.nombre);
        listaTienda.Add(smartphone2);
        listaTienda.Add(smartphone3);
        listaTienda.Add(tablet2);
        listaTienda.Add(laptop3);
        listaTienda.Add(tablet1);
        listaTienda.Add(tablet2);
        tablet2.ObtenerGarantia(tablet2.nombre);
        listaTienda.Add(laptop2);
        listaTienda.Add(smartphone3);


        // Ver los detalles de la lista con el metodo que esta sobreescrito MostrarDetalles().

        Console.WriteLine("Productos disponibles en la tienda: ");
        foreach (ProductoBase item in listaTienda)
        {
            item.MostrarDetalles();

        }


        // Creacion de clientes 

        Cliente cliente1 = new Cliente("Selene", "selepavlotsky@hotmail.com");
        Cliente cliente2 = new Cliente("Berna", "bernardo-prete@hotmail.com");
        Cliente cliente3 = new Cliente("Alvaro", "alpapichon@hotmail.com");


        // Cada cliente agregar sus productos a la lista.


        cliente1.AgregarProducto(smartphone3);
        cliente1.AgregarProducto(tablet2);
        cliente1.AgregarProducto(laptop1);
        cliente1.AgregarProducto(tablet1);
        cliente2.AgregarProducto(smartphone1);


        // Ver con detalles carrito del cliente.

        Console.WriteLine($"El carrito del cliente {cliente1.nombre} es:");
        cliente1.Mostrarcarrito();

        //determinar total compra cliente.

        int total = cliente1.CalcularTotalCompra();
        Console.WriteLine($"\nEl total de la compra de {cliente1.nombre} es: ${total}");

        Console.ReadKey();
    }
}
