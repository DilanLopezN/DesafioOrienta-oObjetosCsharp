using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioOrientaçãoObjetos.models
{
  public abstract class Smartphone
  {
    public string Numero { get; set; }
    // TODO: Implementar as propriedades faltantes de acordo com o diagrama
    private string Modelo { get; set; }
    private int Memoria { get; set; }

    private string Imei { get; set; }
    // (check)

    public Smartphone(string numero, string modelo, string imei, int memoria)
    {
      Numero = numero;
      Modelo = modelo;
      Memoria = memoria;
      Imei = Imei;
      // TODO: Passar os parâmetros do construtor para as propriedades(check)
    }

    public void Ligar()
    {
      Console.WriteLine("Ligando...");
    }

    public void ReceberLigacao()
    {
      Console.WriteLine("Recebendo ligação...");
    }

    public abstract void InstalarAplicativo(string nomeApp);
  }
}