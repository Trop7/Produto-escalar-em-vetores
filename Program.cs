namespace aula;

class Program
{
    static void Main(string[] args)
    {
        /*
         Dados dois vetores X e Y, ambos com n elementos,
          determinar o produto escalar desses vetores. 

          https://www.youtube.com/watch?v=gtR5eUxemUo

          calculo escalar
          v1{4,6,9}
          v2{6,54,3}
          multipicar e soma o produto.          
        */
        //Variaveis
        int[] vetor1 = new int[] { 4, 1, 6 };
        int[] vetor2 = new int[] { -3, 0, 2 };
        int produto =0;
        int temp = 0;
        int i;

        // ler e calcula o produto e soma o resultado do produto
        for (i = 0; i < vetor1.Length; i++)
        {
          temp = vetor1[i] * vetor2[i]; 
          produto += temp;
        }
        // ler o tipo de triangulo
         if (produto > 0)
         {
            Console.WriteLine($"E um triangulo Agudo {produto}");
         }
         else if(produto < 0)
         {
            Console.WriteLine($"E um triangulo Obtuso {produto}");
         }
         else
         {
            Console.WriteLine($"E um triangulo Reto {produto}");
         }
    }
}
