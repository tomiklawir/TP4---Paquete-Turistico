static class ORTWorld{
    public static List <string> ListaDestinos {get; private set;} = new List<string> {"Madrid", "Paris", "Maldivas", "Jamaica", "Alpes Suizos", "Eilat", "Rio de Janeiro", "Sudafrica", "Nueva York", "Estambul"};
    public static List <string> ListaHoteles {get; private set;} = new List<string> {"eurostars-madrid-tower", "le narcisse", "maldivas", "jamaica-hotel", "alpes suizos", "eilat royal beach", "hilton copacabana", "the palace", "nueva york", "intercontinental"};
    public static List <string> ListaAereos {get; private set;}
    public static List <string> ListaExcursiones {get; private set;}
    public static Dictionary<string, Paquete> Paquetes {get; private set;}

    static bool IngresarPaquete(string destinoSeleccionado, Paquete paquete)
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