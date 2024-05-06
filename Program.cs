using System;

namespace TP02_1_Garber_Szwarcbort
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string nombre = "", ciudad = "";
           double peso = 0, fuerza = 0, velocidad = 0, skillDos = 0, skillUno = 0;
           Superheroe superheroe1 = new Superheroe(nombre, ciudad, peso, fuerza, velocidad);
           Superheroe superheroe2 = new Superheroe(nombre, ciudad, peso, fuerza, velocidad);
           

           int ingresoMenu = ingresarMenu("1. Cargar Datos Superhéroe 1 | 2.Cargar Datos Superhéroe 2 |3. Competir! | 4. Salir");
           while (ingresoMenu < 4)
           {
            switch (ingresoMenu){
                case 1:
                Console.WriteLine("Cargar Datos Superhéroe 1");
                superheroe1.Nombre = ingresarString("ingrese nombre del superheroe");
                superheroe1.Ciudad = ingresarString("ingrese ciudad del superheroe");
                superheroe1.Peso = ingresarDouble("ingrese el peso del superheroe");
                superheroe1.Fuerza = ingresarDouble("ingrese la fuerza del superheroe");
                superheroe1.Velocidad = ingresarDouble("ingrese la velocidad del superheroe");
                
                Console.WriteLine("Se ha creado el superheroe " + nombre);
                Console.WriteLine(ObtenerSuperHeroe(superheroe1));
                skillUno = superheroe1.ObtenerSkill(velocidad, fuerza);
                
                break;
                case 2:
                Console.WriteLine("Cargar Datos Superhéroe 2");
                superheroe2.Nombre = ingresarString("ingrese nombre del superheroe");
                superheroe2.Ciudad = ingresarString("ingrese ciudad del superheroe");
                superheroe2.Peso = ingresarDouble("ingrese el peso del superheroe");
                superheroe2.Fuerza = ingresarDouble("ingrese la fuerza del superheroe");
                superheroe2.Velocidad = ingresarDouble("ingrese la velocidad del superheroe");
                Console.WriteLine("Se ha creado el superheroe " + nombre);
                Console.WriteLine(ObtenerSuperHeroe(superheroe2));
                skillDos = superheroe2.ObtenerSkill(velocidad, fuerza);

                break;
                case 3: 
                Console.WriteLine("Competir!");
                if(superheroe1.Nombre == string.Empty|| superheroe2.Nombre == string.Empty)
                {
                    Console.WriteLine("No se puede competir, ingrese los datos restantes");
                }
                buscarGanador(skillUno, skillDos, superheroe1, superheroe2);
                
                break;
            }

            ingresoMenu = ingresarMenu("1. Cargar Datos Superhéroe 1 | 2.Cargar Datos Superhéroe 2 |3. Competir! | 4. Salir");

           }
           if(ingresoMenu == 4){
            Console.WriteLine("FIN");
           }
 
        }

        public static void buscarGanador(double skillUno, double skillDos, Superheroe superheroe1, Superheroe superheroe2) {
            double numSkillGanador, numSkillPerdedor;
            string nombreGanador;
            if(skillUno > skillDos){
                nombreGanador = superheroe1.Nombre;
                numSkillGanador = skillUno;
                numSkillPerdedor = skillDos;
            }else{
                nombreGanador = superheroe2.Nombre;
                numSkillGanador = skillDos;
                numSkillPerdedor = skillUno;
            }
            if((numSkillGanador- 30) > numSkillPerdedor){
                Console.WriteLine($"Ganó {nombreGanador} por amplia diferencia");
            }else if ((numSkillGanador- 10) > numSkillPerdedor){
                Console.WriteLine($"Ganó {nombreGanador}. Fue muy parejo");
            }else{
                Console.WriteLine($"Ganó {nombreGanador}. No le sobró nada");
            }
            
        }

            
            

            
        
        public static string ObtenerSuperHeroe(Superheroe superheroe){
            string super = $"nombre: {superheroe.Nombre} ciudad: {superheroe.Ciudad}  peso: {superheroe.Peso} fuerza: {superheroe.Fuerza} velocidad: {superheroe.Velocidad}";
            return super;
        }
        

        public static double ingresarDouble(string msj){
            double num = -1;
            do{
                Console.WriteLine(msj);
            num = int.Parse(Console.ReadLine());
            }while(num < 0 || num > 100);
            return num;
            
        }
        
        public static string ingresarString(string msj){
            string cadena = "";
            do{
                Console.WriteLine(msj);
            cadena = Console.ReadLine();
            }while(cadena == string.Empty);
            return cadena;
        }
        public static int ingresarMenu(string msj){
        Console.WriteLine(msj);
        int num = int.Parse(Console.ReadLine());
        return num;}
    
    }

    
}
