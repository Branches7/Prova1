using System;
using System.Collections.Generic;

class Veiculos{

  //Atributos
  private Concessionaria carro;
  protected string cor;
  protected string marca;
  protected string modelo;
  protected double valor;
  protected int anoFabricacao;
  protected List<double> valorPortfolio = new List<double>();

  //get e set
  public string Cor  
  {
    get { return cor; }
    set { cor = value; }
  }

  public string Marca 
  {
    get { return marca; }
    set { marca = value; } 
  }

  public string Modelo
  {
    get { return modelo; } 
    set { modelo = value; } 
  }

  //metodos
  protected virtual void definirValorVeiculo(double CustoFixo){
    valorPortfolio.add(valor);
  }

  private void CalcularPortfolio(){
    double somaPortfolio = 0;

    for (int x=0;x < valorPortfolio.Count; x++){
      somaPortfolio += valorPortfolio[x];
    }
  }
  
}