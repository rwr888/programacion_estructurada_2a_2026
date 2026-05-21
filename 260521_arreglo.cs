Console.WriteLine("cuantos valores deseas guardar");
int size = int.Parse(Console.ReadLine());

// Crear arreglo de enteros con el tamaño capturado
int[] lista = new int [size];

// llenar arreglo de enteros elemento por elemento
for (int i = 0; i < size; i++){
    Console.WriteLine($"ingresa valor {i + 1}:");
    lista[i] = int.Parse(Console.ReadLine());
    }

//imprimir arreglo de enteros elemento por elemento
for (int i = 0; i < size; i++){
    Console.WriteLine($"Posicion {i + 1}: {lista[i]}");
    }

