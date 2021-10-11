using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consumo
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceReference1.ServiciosSoapClient client = new ServiceReference1.ServiciosSoapClient();

            //string result = client.HelloWorld();

            //string result = client.Saludar("Pepe chivo");

            //string result = client.GuardarLog("Mensaje de consola");

            //var result = client.Sumar(4, 7);

            //string[] frutas = client.Obtenerfrutas().ToArray();
            //foreach (var fruta in frutas)
            //{
            //    Console.WriteLine(fruta);
            //}

            //ServiceReference1.ArrayOfString frutas = new ServiceReference1.ArrayOfString() { "Coco", "Cereza", "Almendra" };
            //string result = client.GuardarFrutas(frutas);

            //ServiceReference1.Equipos[] equipos = client.ObtenerEquipos();
            //foreach (ServiceReference1.Equipos equipo in equipos)
            //{
            //    Console.WriteLine($"{equipo.Nombre} - {equipo.Pais}");
            //}

            //ServiceReference1.Equipos[] equipos = new ServiceReference1.Equipos[2];
            //equipos[0] = new ServiceReference1.Equipos() { Nombre = "Sevilla", Pais = "España" };
            //equipos[1] = new ServiceReference1.Equipos() { Nombre = "Chelsea", Pais = "Inglaterra" };

            //string result = client.GuardarEquipos(equipos);

            //string result = client.GuardarXML("<?xml version='1.0' encoding='UTF-8'?><documento><deporte><![CDATA[Futbol]]></deporte><equipos><equipo><nombre><![CDATA[Ajax]]></nombre><pais><![CDATA[Holanda]]></pais></equipo><equipo><nombre><![CDATA[Valencia]]></nombre><pais><![CDATA[España]]></pais></equipo></equipos></documento>");

            string result = client.RetornarJson();

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
