//arrays sao listas de valores
using System;

class Arrays
{
     static void Main (string [] args) {

    string [] listaMercado = new string [3] {"pão","arroz", "carne"};

    Console.WriteLine(listaMercado[3]);

    for (int i = 0; i < 3; i++) {
        Console.WriteLine(listaMercado[1]);
    }
    }
}
