public static class ORTWorld{
    public static List <string> ListaDestinos {get; private set;} = new List<string> {"Madrid", "Paris", "Maldivas", "Jamaica", "Alpes Suizos", "Eilat", "Rio de Janeiro", "Sudafrica", "Nueva York", "Estambul"};
    public static List <string> ListaHoteles {get; private set;} = new List<string> {"eurostars-madrid-tower", "le narcisse", "maldivas", "jamaica-hotel", "alpes suizos", "eilat royal beach", "hilton copacabana", "the palace", "nueva york", "intercontinental"};
    public static List <string> ListaAereos {get; private set;} = new List<string> {"latam", "american airlines", "turkish airlines", "sigapour airlines", "gol", "flybondi", "aerolineas argentinas", "Delta", "emirates airlines", "boa"};
    public static List <string> ListaExcursiones {get; private set;} = new List <string> {"bernabeu-paseo", "louvre", "playa maldivas", "Bamboo-bote", "ski", "paseo", "cristo redentor", "safari", "bicis", "bosforo"};
    public static Dictionary<string, Paquete> Paquetes {get; private set;}

    public static bool IngresarPaquete(string destinoSeleccionado, Paquete paquete)
    {
        if(!Paquetes.Keys.Contains(destinoSeleccionado)){
            Paquetes.Add(destinoSeleccionado, paquete);
            return true;
        }
        else{
            return false;
        }
        
    }
}