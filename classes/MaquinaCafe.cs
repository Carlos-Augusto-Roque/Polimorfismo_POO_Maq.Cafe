using System;

namespace Polimorfismo_POO_Maq.Cafe.classes
{
    public class MaquinaCafe
    {
        public float acucarDisponivel = 200;
        public float quantidadeAcucar;
        public string resposta;

        public void FazerCafe(float quantidadeAcucar, float acucarDisponivel){
            Console.WriteLine("Gostaria de escolher a quantidade de açucar? s/n");
            resposta = Console.ReadLine();
            
            if(resposta == "s"){                
            Console.WriteLine("Informe a quantidade: ");
            quantidadeAcucar = float.Parse(Console.ReadLine());

            }if(resposta == "s" && quantidadeAcucar < acucarDisponivel){
            Console.WriteLine("Retire e aproveite seu café...");
            return;

            }if(resposta == "s" && quantidadeAcucar > acucarDisponivel){
                Console.WriteLine("Quantidade de açucar insuficiente!");
                Console.WriteLine("Seu café será entregue sem açucar!");
                Console.WriteLine("Retire e aproveite seu café...");
            return;

            }if(resposta == "n" && quantidadeAcucar < acucarDisponivel){
                Console.WriteLine("Retire e aproveite seu café...");
            }return;
        }



        public void FazerCafe(){
            Console.WriteLine("Retire seu expresso...");
        }

    }
}
// Você trabalha em uma empresa especialista em máquinas de fazer café e sua equipe é a responsável por desenvolver uma classe para o novo modelo de cafeteiras que irão fabricar. No modelo anterior das cafeteiras, os usuários podiam selecionar se era para ser adicionado açúcar ou não, mas a nova versão da Super CafeteiraTabajaras Plus++ deve ser capaz de receber a quantidade (em gramas) de açúcar a ser colocada no café. Mesmo com essa nova possibilidade, o usuário não será obrigado a informar quanto de açúcar deseja. Deve-se adicionar 10 gramas de açúcar por padrão caso nenhum valor seja informado. 
// 1. Para começar, crie a classe "MaquinaCafe" com um atributo chamado "acucarDisponivel", que será útil para saber a quantidade de açúcar disponível na máquina. Se o açúcar acabar, a máquina só permitirá cafezinhos sem açúcar, certo?
//  2. Agora crie um método chamado "fazerCafe" na mesma classe. Esse método deve verificar se a quantidade de açúcar disponível na máquina é suficiente e, claro, fazer o café. 
// 3.Como o usuário não será obrigado a informar a quantidade de açúcar a ser adicionado no café, crie outro método com o nome "fazerCafe", que não recebe nenhum parâmetro. Isso é uma sobrecarga de métodos!