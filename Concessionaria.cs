using System.Collections.Generic;

class Concessionaria{
  protected string localizacao;
  protected string gerente;
  protected int anoFundacao;
  List<Veiculos> carrosDisponiveis = new List<Veiculos>();

  public void AdicionarCarro(Veiculos x){
    carrosDisponiveis.add(x);
  }

}