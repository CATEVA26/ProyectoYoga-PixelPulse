using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    {"Sirsa", Res.cabeza}
    };
       
        public static List<string> TraducirMorfema(string? sans)
        {
            string[] palabras = sans.Split(" ");
            List<string> morfemas = new();

            foreach (string palabra in palabras)
            {
                if (diccionarioSansEs.ContainsKey(palabra))
                {
                    morfemas.Add(palabra+":"+ diccionarioSansEs[palabra]);
                }
                else
                {
                    string asana = palabra.Replace("asana", "a Asana");
                    TraducirMorfema(asana);
                }


            }
            return morfemas;

        }



        private static void ConvertirEn()
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
        }


    }
}
