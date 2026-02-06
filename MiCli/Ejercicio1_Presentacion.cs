namespace MiCli;

// TODO: Crea un programa que imprima tu Nombre, Carrera y Hobby favorito en líneas separadas
public class Ejercicio1_Presentacion
{
    public static string ObtenerPresentacion()
    {
        // TODO: Declara tres variables string: nombre, carrera y hobby
        string nombre = "Pedro Feliz";
        string carrera = "Ingenieria en Sistemas Computacionales";
        string hobby = "Videojuegos";
        // TODO: Retorna un string con las tres variables en líneas separadas
        return $"Hola mi nombre es {nombre},\nestudio la carrera de {carrera},\ny mi hobby favorito es {hobby}"; //OJO: reemplaza este texto
        throw new NotImplementedException();
    }
    
    public static void Ejecutar()
    {
        Console.WriteLine(ObtenerPresentacion());
    }
}
