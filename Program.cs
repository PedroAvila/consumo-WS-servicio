using Newtonsoft.Json;
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

            //dynamic json = new Dictionary<string, dynamic>();
            //json.Add("Deporte", "Futbol");

            //List<Dictionary<string, string>> equipos = new List<Dictionary<string, string>>();
            //Dictionary<string, string> equipo1 = new Dictionary<string, string>();

            //equipo1.Add("Nombre", "Chelsea");
            //equipo1.Add("Pais", "Inglaterra");

            //equipos.Add(equipo1);

            //Dictionary<string, string> equipo2 = new Dictionary<string, string>();

            //equipo2.Add("Nombre", "Barcelona");
            //equipo2.Add("Pais", "España");

            //equipos.Add(equipo2);

            //json.Add("equipos", equipos);

            ////string result = client.GuardarJson(JsonConvert.SerializeObject(json));
            //string result = client.GuardarJson("{\"Deporte\":\"Futbol\",\"equipos\":[{\"Nombre\":\"AJAX\",\"Pais\":\"Holanda\"},{\"Nombre\":\"Real Madrid\",\"Pais\":\"España\"}]}");

            string result = client.ObtenerProductos();

            dynamic productos = JsonConvert.DeserializeObject(result);
            foreach (dynamic producto in productos)
            {
                Console.WriteLine(producto);
            }

            //Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
