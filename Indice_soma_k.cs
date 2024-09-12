using System;
using System.Runtime.Serialization;

//Observe o trecho de código abaixo: int INDICE = 12, SOMA = 0, K = 1; enquanto K < INDICE faça { K = K + 1; SOMA = SOMA + K; } imprimir(SOMA);
public class indice { 
    public static void Main(String[] args) {
        int indice = 12;
        int soma = 0;
        int k = 1;

        while(k < indice) {
            k += 1;
            soma += k;
        }
        Console.WriteLine(soma);
    }
}