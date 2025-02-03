// See https://aka.ms/new-console-template for more information
class Program
{

    static void main()
    {

        Console.WriteLine("Aplicacion de BlackJack!");


        Baraja barajaNueva = new Baraja();
        Jugador jugador1 = new Jugador("Jugador UNO",barajaNueva);
        Jugador crupier = new Jugador("CRUPIER", barajaNueva, true);

        Console.WriteLine("Repartimos las cartas.");
        for (int i = 0; i < 2; i++){
            string cartaJugador = barajaNueva.RobarCarta();
            jugador1.RecibirCarta(cartaJugador, barajaNueva.ObtenerValor(cartaJugador));
            string cartaCrupier = barajaNueva.RobarCarta();
            crupier.RecibirCarta(cartaCrupier, barajaNueva.ObtenerValor(cartaCrupier));
        }
        Console.WriteLine(jugador1);
        Console.WriteLine(crupier);


    }
}
