using System;

public class Class1
{
	public Atividade2()
    {
        Console.WriteLine("Seja bem vindo ao software para verificação das maiores temperaturas de acordo com a media semanal.\r\n ");
        double soma = 0.0;
        double media = 0.0;


        double[] temperaturas = new double[8];
        double[] acimaMedia = new double[8];

        System.Console.WriteLine("Por favor insira os valores semanal (lembrando, é necessário a inserção de 7 valores):");
        for (int i = 1; i < temperaturas.Length; i++)
        {


            Console.WriteLine("Temperatura Nº " + i + ":");
            temperaturas[i] = Convert.ToDouble(Console.ReadLine());
            soma = temperaturas[i] + soma;


        }


        media = soma / 3;


        System.Console.WriteLine("Os valores encontrados acima da media são:");
        for (int a = 0; a < temperaturas.Length; a++)
        {
            if (temperaturas[a] > media)
            {
                Console.WriteLine(temperaturas[a]);
            }
        }
        Console.ReadKey();


    }





    }
}
