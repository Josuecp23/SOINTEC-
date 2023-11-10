using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOINTEC
{
    //clase para calcular el presupuesto segun el numero de personas
    public class CalcularPresupuestos
    {
        public int NumCotizacion { get; set; 
        }   
        public int NumPersonas { get; set;
        }
        public int CostoPersona { get; set;
        }
        public int TotalPresupuesto { get; set;
        }

        public static class CalculadoraPresupuesto
        {
            //metodo para calcular los presupestos segun las condiciones asginadas en el proyecto
            public static CalcularPresupuestos CalcularPresupuesto(int numeroPersonas)
            {
                CalcularPresupuestos presupuesto = new CalcularPresupuestos();
                presupuesto.NumPersonas = numeroPersonas;

                if (numeroPersonas <= 200)
                {
                    presupuesto.CostoPersona = 95;
                }
                else if (numeroPersonas <= 300)
                {
                    presupuesto.CostoPersona = 85;
                }
                else
                {
                    presupuesto.CostoPersona = 75;
                }

                presupuesto.TotalPresupuesto = presupuesto.CostoPersona * numeroPersonas;

                return presupuesto;
            }
        }
        public static class ManejadorArchivos
        {
            private const string RutaArchivo = "presupuestos.txt";

            public static void GuardarPresupuesto(CalcularPresupuestos presupuesto)
            {
                string linea = $"{presupuesto.NumCotizacion},{presupuesto.NumCotizacion},{presupuesto.NumCotizacion},{presupuesto.TotalPresupuesto}";
                File.AppendAllLines(RutaArchivo, new[] { linea });
            }
            //Lista para recorrer y encontrar los datos solicitados en el listview
            public static List<CalcularPresupuestos> ConsultarPresupuestos()
            {
                List<CalcularPresupuestos> presupuestos = new List<CalcularPresupuestos>();

                if (File.Exists(RutaArchivo))
                {
                    string[] lineas = File.ReadAllLines(RutaArchivo);

                    foreach (string linea in lineas)
                    {
                        string[] partes = linea.Split(',');
                        if (partes.Length == 4)
                        {
                            CalcularPresupuestos presupuesto = new CalcularPresupuestos
                            {
                                NumCotizacion = int.Parse(partes[0]),
                                NumPersonas = int.Parse(partes[1]),
                                TotalPresupuesto = int.Parse(partes[2])
                            };

                            presupuestos.Add(presupuesto);
                        }
                    }
                }

                return presupuestos;
            }

        }
    }
}
