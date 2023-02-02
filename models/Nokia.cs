using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioOrientaçãoObjetos.models
{
  public class Nokia : Smartphone
  {


    public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
    {

      modelo = "Oukitel";
      imei = "456";
    }

    public override void InstalarAplicativo(string nomeApp)
    {
      Console.WriteLine($"Instalando aplicativo {nomeApp} usando playstore");
    }
  }
}