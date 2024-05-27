static class ORTWorld{
    public static List <string> ListaDestinos {get; private set;}
    public static List <string> ListaHoteles {get; private set;}
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