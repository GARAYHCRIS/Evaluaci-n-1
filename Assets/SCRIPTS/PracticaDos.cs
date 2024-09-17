using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;

public class PracticaDos : MonoBehaviour
{
    public class Comparador
{
    // Esta función compara tres valores enteros y devuelve un string basado en ciertas condiciones.
    public static string CompararValores(int valor1, int valor2, int valor3)
    {
        // Determina el valor mayor entre los tres parámetros.
        int mayor = Math.Max(valor1, Math.Max(valor2, valor3));
        
        // Determina el valor menor entre los tres parámetros.
        int menor = Math.Min(valor1, Math.Min(valor2, valor3));

        // Verifica si el valor mayor es superior a 100.
        if (mayor > 100)
        {
            return "Mayor fuera de rango";
        }
        // Verifica si el valor menor es inferior a 0.
        else if (menor < 0)
        {
            return "Menor fuera de rango";
        }
        // Si ninguno de los valores supera los umbrales, calcula y devuelve el promedio.
        else
        {
            float promedio = (valor1 + valor2 + valor3) / 3.0f;
            return "El valor promedio es: " + promedio;
        }
    }
}

public class Programa
{
    public static void Main()
    {
        // Llama a la función CompararValores con los valores 20, 42 y 38.
        string resultado = Comparador.CompararValores(20, 42, 38);
        
        // Imprime el resultado en la consola.
        Console.WriteLine(resultado);
    }
}
private float timer = 0f;
    private float delay = 4.5f;
    private int[] numbers = { 97, -64, -3, -58, -15, 58, 51, 38, -31, -37 };

    private bool arrayTerminado=false;

    void Start()
    {
        // Genera tres números aleatorios entre -100 y 100.
        int valor1 = UnityEngine.Random.Range(-100, 101);
        int valor2 = UnityEngine.Random.Range(-100, 101);
        int valor3 = UnityEngine.Random.Range(-100, 101);

        // Llama a la función CompararValores con los valores aleatorios.
        string resultado = Comparador.CompararValores(valor1, valor2, valor3);

        // Imprime el resultado en la consola.
        Debug.Log(resultado);
    }

    void Update()
    {
        // Incrementar el temporizador con el tiempo transcurrido desde el último frame
        timer += Time.deltaTime;

        // Verificar si han pasado 4.5 segundos
        if (timer >= delay && !arrayTerminado)
        {
            // Llamar a la función para modificar el array
            ModifyArray();
          arrayTerminado=true;  
            // Reiniciar el temporizador para evitar múltiples ejecuciones
            timer = 0f;
        }
    }

    void ModifyArray()
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] % 2 == 0) // Verificar si el número es par
            {
                numbers[i] *= 2; // Duplicar el valor del número par
            }
        }

        // Imprimir el array modificado en la consola
        Debug.Log("Array modificado: " + string.Join(", ", numbers));
    }
}


