using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProyectoYoga_PixelPulse
{
    internal class Morfema
    {
        public static Dictionary<string, string> diccionarioSansEs = new() {
    {"Asana",Res.postura} ,
    {"Adho",Res.abajo},
    {"Ardha",Res.mitad},
    {"Urdhva",Res.arriba},
    {"Mukha",Res.rostro},
    {"Svana",Res.perro},
    {"Virabhadra",Res.guerrero},
    {"Vriksha",Res.arbol} ,
    {"Bala",Res.ninio},
    {"Bhujanga",Res.cobra},
    {"Paschi",Res.oeste},
    {"Setu",Res.puente},
    {"Shava",Res.cadaver},
    {"Trikona",Res.triangulo},
    {"Matsya",Res.pez},
    {"Mala",Res.guirnalda},
    {"Eka",Res.uno},
    {"Pada",Res.pie},
    {"Raja",Res.real},
    {"Kapota:",Res.paloma},
    {"Hasta",Res.mano},
    {"Parivrtta",Res.invertido},
    {"Janu", Res.rodilla},
    {"Sirsa", Res.cabeza},
    {"Tada",Res.montania } 
            
    };

        public static List<string> TraducirMorfema(string? sans)
        {
           
            string[] palabras = sans.Split(' ');
            List<string> morfemas = new();
            if (TieneNumerosRomanos(palabras[palabras.Length - 1])) {
                string oracion = string.Join(" ",palabras.Take(palabras.Length-1));
                return TraducirMorfema(oracion);
            }
            
            foreach (string palabra in palabras)
            {
                if (diccionarioSansEs.TryGetValue(palabra, out string traduccion)) 
                {
                    morfemas.Add(palabra+":"+ diccionarioSansEs[palabra]);
                }
                else
                {
                    string asana = palabra.Replace("asana", "a Asana");
                    morfemas.AddRange(TraducirMorfema(asana));
                }
            }
            return morfemas;

        }
        private static bool TieneNumerosRomanos(string cadena)
        {
            string patron = @"^M{0,3}(CM|CD|D?C{0,3})(XC|XL|L?X{0,3})(IX|IV|V?I{0,3})$";
            return Regex.IsMatch(cadena, patron);
        }
    }
}
