float promedio = 0;
Console.WriteLine("¿cuantas calificaciones deseas guardar?");
int size = int.Parse(Console.ReadLine());

//crear arrglo de enteros con el tamaño capturado
float[] calificaciones = new float[size];

//llenar arreglo de calificaciones, elemento por elemento
for (int i=0; i<size; i++){
    Console.WriteLine($"ingresa la calificacion {i+1}:");
    calificaciones[i] = float.Parse(Console.ReadLine());
}

// calcula el promedio
for (int i=0; i<size; i++){
    promedio = promedio + calificaciones[i];
}
promedio = promedio / size;

Console.WriteLine($"el promedio del alumno es: {promedio}");
