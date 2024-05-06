using System;
using System.Runtime.Intrinsics.Arm;

class Superheroe{
    //Atributos

    public string Nombre {get; set;}
    public string Ciudad {get; set;}
    public double Peso {get; set;}
    public double Fuerza {get; set;}
    public double Velocidad {get; set;}

    //Constructor
    public Superheroe(string nombre, string ciudad, double peso, double fuerza, double velocidad){

        Nombre = nombre;
        Ciudad = ciudad;
        Peso = peso;
        Fuerza = fuerza;
        Velocidad = velocidad;
    }
    // metodo ObtenerSkill
    public double ObtenerSkill(double velocidad, double fuerza){
        Random rnd = new Random();
        double numRandom  = rnd.Next(1, 10);
        
        double obtenerSkill = (velocidad * 0.6) + (fuerza * 0.8) + numRandom; 
        return obtenerSkill;

    }
}