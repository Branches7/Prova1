
class Importados : Veiculos{
  
  protected override void definirValorVeiculo(double CustoFixo){
    valor = (CustoFixo*3.0) + (0.6*CustoFixo) + (CustoFixo/5);
  }
}