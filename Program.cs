namespace FacadeDesignPattern
{
    internal class Program
    {
        // Facade Design Pattern is used to hide the complexities of a system and provides
        // an easy-to-use interface to the client using which the client can access the
        // system. The Facade (usually a wrapper) class sits on the top of a group of
        // subsystems and allows them to communicate in a unified manner
        static void Main(string[] args)
        {
            Order order = new Order();
            order.PlaceOrder();
            Console.Read();
        }
    }
}