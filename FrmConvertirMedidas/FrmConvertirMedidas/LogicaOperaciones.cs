using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmConvertirMedidas
{
    class LogicaOperaciones
    {
        public string Operar(string operandoA, string Operador)
        {
            
            double operando1 = Convert.ToDouble(operandoA);
            Enumerado OperadorEnumerado = ConvertirStringEnumeradoOperadores(Operador);
            double? Resultado = Operar(operando1, Operador);
            string ResultadoConvertido;
            if (Resultado != null)
            {
                ResultadoConvertido = Resultado.ToString();
            }
            else
            {
                ResultadoConvertido = "Error";
            }
            return ResultadoConvertido;
        }

        private Enumerado ConvertirStringEnumeradoOperadores(string Operador)
        {
            Enumerado Resultado;
            switch (Operador)
            {
                case "Centímetros a Pulgadas":
                case "Centimeters to Inches":
                    Resultado = Enumerado.CentimetrosEnPulgadas;
                    break;
                case "Pulgadas a Centímetros":
                case "Inches to Centimeters":
                    Resultado = Enumerado.PulgadasEnCentimetros;
                    break;
                default:
                    Resultado = Enumerado.Desconocido;
                    break;
            }
            return Resultado;
        }
        private double? Operar(double operandoA,
                              Enumerado Operador)
        {
            double? Resultado = 0.0;
            double Conv = 2.54;
            switch (Operador)
            {
                case Enumerado.CentimetrosEnPulgadas:
                    Resultado = operandoA/Conv;
                    break;
                case Enumerado.PulgadasEnCentimetros:
                    Resultado = operandoA*Conv;
                    break;
                default:
                    System.Windows.Forms.MessageBox.Show(
                        "No se ha seleccionado ningún operador");
                    break;
            }
            return Resultado;
        }
    }
}

