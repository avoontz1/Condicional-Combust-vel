using System;

namespace Condicional_Combust_vel
{
    class Program
    {
        static void Main(string[] args)
        {
             //COLETA DE DADOS
            Console.WriteLine("Selecione um Tipo de Comnustível\nA- Alcool\nG- Gasolina");
            string Comb = Console.ReadLine();

            Console.WriteLine("Escolha a quantidade de Combustível desejada:");
            float quantC = float.Parse(Console.ReadLine());

            //VARIAVEIS ALCOOL
            float alcool = 4.9f;
            float descAl1 = 0.05f;
            float descAl2 = 0.03f;
            
            //VARIAVEIS GASOLINA
            float gasolina = 5.3f;
            float descG1= 0.06f;
            float descG2 = 0.04f;

            //VARIAVEIS ABRANGENTES
            float valorTotal;

            
            switch (Comb)
            {
                case "A":
                    Console.WriteLine("O valor total a ser pago (com desconto aplicado) é de: R$ "+CalculocDes(quantC, alcool, descAl1, descAl2));
                    break;

                case "G":
                    Console.WriteLine("O valor total a ser pago (com desconto aplicado) é de: R$ "+CalculocDes(quantC, gasolina, descG1, descG2));
                    break;

                default:
                    Console.WriteLine("OPÇÃO INVÁLIDA");
                    break;
            }
            

        
            float CalculocDes(float litros, float valor, float percent1, float percent2)
            {

                if(litros >20){
                    float valorFinal = litros*valor;
                    float desconto = (litros*valor)*percent1;

                    return valorFinal-desconto;
                }else{
                    float valorFinal = litros*valor;
                    float desconto = (litros*valor)*percent1;

                    return valorFinal-desconto;
            }


        }
        }
    }
}
