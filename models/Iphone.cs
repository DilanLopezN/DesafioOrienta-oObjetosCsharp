using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioOrientaçãoObjetos.models
{
  public class Iphone : Smartphone
  {
    public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
    {
      modelo = "Xr";
      imei = "123";
    }

    public override void InstalarAplicativo(string nomeApp)
    {
      Console.WriteLine($"Instalando aplicativo {nomeApp} com Appstore");
    }
  }
}