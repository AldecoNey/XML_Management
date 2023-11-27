using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace EjercicioCuatro
{
    class LeerXML
    {
        public static void Main(string[] args)
        {
            string xml = leerXML();
            Console.WriteLine(xml);
        }

        public static string leerXML()
        {
            string resultado = "";
            string path = Directory.GetCurrentDirectory();
            path = path.Replace("bin\\Debug\\net6.0", "");

            try
            {
                XmlDocument xDoc = new XmlDocument();
                xDoc.Load(path + "empleados.xml");
                XmlNodeList empleados = xDoc.GetElementsByTagName("empleados");
                XmlNodeList listado = ((XmlElement)empleados[0]).GetElementsByTagName("listado");
                XmlNodeList listaEmpleados = ((XmlElement)listado[0]).GetElementsByTagName("empleado");

                foreach (XmlElement nodo in listaEmpleados)
                {
                    int i = 0;
                    XmlNodeList id = nodo.GetElementsByTagName("id");
                    XmlNodeList nombreCompleto = nodo.GetElementsByTagName("nombreCompleto");
                    XmlNodeList cuil = nodo.GetElementsByTagName("cuil");
                    XmlNodeList sector = nodo.GetElementsByTagName("sector");
                    XmlNodeList cupoAsignado = nodo.GetElementsByTagName("cupoAsignado");
                    XmlNodeList cupoConsumido = nodo.GetElementsByTagName("cupoConsumido");

                    resultado += "Empleado: " + nombreCompleto[i].InnerText + "  " +
                        "Id: " + id[i].InnerText + "  " +
                        "Cuil: " + cuil[i].InnerText + "  " +
                        "Sector: " + sector[i].InnerText + "  ";


                    foreach (XmlElement nodoSector in sector)
                    {
                        string denominacion = nodoSector.GetAttribute("denominacion");
                        if (denominacion != null && denominacion != "")
                        {
                            resultado += denominacion;
                        }
                        string idSector = nodoSector.GetAttribute("id");
                        if (idSector != null && idSector != "")
                        {
                            resultado += idSector;
                        }
                        string valorSemaforo = nodoSector.GetAttribute("valorSemaforo");
                        if (valorSemaforo != null && valorSemaforo != "")
                        {
                            resultado += valorSemaforo;
                        }
                        string colorSemaforo = nodoSector.GetAttribute("colorSemaforo");
                        if (colorSemaforo != null && colorSemaforo != "")
                        {
                            resultado += colorSemaforo;
                        }
                    }


                   resultado += "Cupo asignado: " + cupoAsignado[i].InnerText + "  " +
                        "Cupo consumido: " + cupoConsumido[i++].InnerText + "\n";
                }

                XmlNodeList subSectores = ((XmlElement)empleados[0]).GetElementsByTagName("subSectores");
                XmlNodeList totalCupoAsignadoSector = ((XmlElement)empleados[0]).GetElementsByTagName("totalCupoAsignadoSector");
                XmlNodeList totalCupoConsumidoSector = ((XmlElement)empleados[0]).GetElementsByTagName("totalCupoConsumidoSector");
                XmlNodeList valorDial = ((XmlElement)empleados[0]).GetElementsByTagName("valorDial");

                resultado += "SubSectores: " + subSectores[0].InnerText + "  " +
                      "Total de cupos asignados por sector: " + totalCupoAsignadoSector[0].InnerText + "  " +
                      "Total de cupos consumidos por sector: " + totalCupoConsumidoSector[0].InnerText + "  " +
                      "Valor Dial: " + valorDial[0].InnerText + "  " +"\n";
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
            return resultado;
        }
    }
}
