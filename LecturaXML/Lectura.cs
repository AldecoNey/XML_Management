using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace LecturaXML
{
    class Lectura
    {
        public static void Main(string[] args)
        {
            string xml = leerXML();
            Console.WriteLine(xml);
        }

        private static string leerXML()
        {
            string resultado = "";
            string path = Directory.GetCurrentDirectory();
            path = path.Replace("bin\\Debug\\net6.0", "");

            using (XmlReader reader = XmlReader.Create(path + "miXMLEmpleados.xml"))
            {
                while (reader.Read())
                {
                    if (reader.IsStartElement())
                    {
                        switch (reader.Name)
                        {
                            case "Empleados":
                                resultado += "Start <Empleados> element." + "\n";
                                break;
                            case "Listado":
                                resultado += "Start <Listado> element." + "\n";
                                break;
                            case "Empleado":
                                resultado += "Start <Empleado> element." + "\n";
                                break;
                            case "Id":
                                resultado += "Start <Id> element." + "\n";
                                if (reader.Read())
                                {
                                    resultado += "  Text node: " + reader.Value.Trim() + "\n";
                                }
                                break;
                            case "NombreCompleto":
                                resultado += "Start <NombreCompleto> element." + "\n";
                                if (reader.Read())
                                {
                                    resultado += "  Text node: " + reader.Value.Trim() + "\n";
                                }
                                break;
                            case "Cuil":
                                resultado += "Start <Cuil> element." + "\n";
                                if (reader.Read())
                                {
                                    resultado += "  Text node: " + reader.Value.Trim() + "\n";
                                }
                                break;
                            case "Sector":
                                resultado += "Start <Sector> element." + "\n";

                                string attribute = reader["Denominacion"] ?? "";
                                if (attribute != null)
                                {
                                    resultado += "  Has attribute Denominacion: " + attribute + "\n";
                                }
                                attribute = reader["Denominacion"] ?? "";
                                if (attribute != null)
                                {
                                    resultado += "  Has attribute Id: " + attribute + "\n";
                                }
                                attribute = reader["Denominacion"] ?? "";
                                if (attribute != null)
                                {
                                    resultado += "  Has attribute ValorSemaforo: " + attribute + "\n";
                                }
                                attribute = reader["Denominacion"] ?? "";
                                if (attribute != null)
                                {
                                    resultado += "  Has attribute ColorSemaforo: " + attribute + "\n";
                                }
                                break;

                            case "CupoAsignado":
                                resultado += "Start <CupoAsignado> element." + "\n";
                                if (reader.Read())
                                {
                                    resultado += "  Text node: " + reader.Value.Trim() + "\n";
                                }
                                break;
                            case "CupoConsumido":
                                resultado += "Start <CupoConsumido> element." + "\n";
                                if (reader.Read())
                                {
                                    resultado += "  Text node: " + reader.Value.Trim() + "\n";
                                }
                                break;
                            case "SubSectores":
                                resultado += "Start <SubSectores> element." + "\n";
                                if (reader.Read())
                                {
                                    resultado += "  Text node: " + reader.Value.Trim() + "\n";
                                }
                                break;
                            case "TotalCupoAsignadoSector":
                                resultado += "Start <TotalCupoAsignadoSector> element." + "\n";
                                if (reader.Read())
                                {
                                    resultado += "  Text node: " + reader.Value.Trim() + "\n";
                                }
                                break;
                            case "TotalCupoConsumidoSector":
                                resultado += "Start <TotalCupoConsumidoSector> element." + "\n";
                                if (reader.Read())
                                {
                                    resultado += "  Text node: " + reader.Value.Trim() + "\n";
                                }
                                break;
                            case "ValorDial":
                                resultado += "Start <ValorDial> element." + "\n";

                                if (reader.Read())
                                {
                                    resultado += "  Text node: " + reader.Value.Trim() + "\n";
                                }

                                break;
                        }
                    }

                }
            }
            return resultado;
        }
    }
}
