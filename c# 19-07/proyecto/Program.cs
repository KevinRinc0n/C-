// class Program {
//     static void Main() {
//         Console.WriteLine("Calculadora básica");
//         Console.Write("Ingresa el primer número: ");
//         double num1 = Convert.ToDouble(Console.ReadLine());

//         Console.Write("Ingresa el segundo número: ");
//         double num2 = Convert.ToDouble(Console.ReadLine());

//         Console.WriteLine($"Suma: {num1 + num2}");
//         Console.WriteLine($"Resta: {num1 - num2}");
//         Console.WriteLine($"Multiplicación: {num1 * num2}");
//         Console.WriteLine($"División: {num1 / num2}");
//     }
// }


// class Program {
//     static void Main() {
//         Console.Write("Ingresa un año: ");
//         int year = Convert.ToInt32(Console.ReadLine());

//         bool esBisiesto = (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);

//         if (esBisiesto) {
//             Console.WriteLine("Es un año bisiesto.");
//         } else {
//             Console.WriteLine("No es un año bisiesto.");
//         }
//     }
// }


// class Program {
//     static void Main() {
//         Console.WriteLine("Â¡Hola Mundo!");
//     }
// }


// class Program {
//     static void Main() {
//         Console.Write("Ingresa un número entero: ");
//         int numero = Convert.ToInt32(Console.ReadLine());

//         if (numero % 2 == 0) {
//             Console.WriteLine("Es un número par.");
//         } else {
//             Console.WriteLine("Es un número impar.");
//         }
//     }
// }


// class Program {
//     static void Main() {
//         Console.Write("Ingresa la temperatura en grados Celsius: ");
//         double celsius = Convert.ToDouble(Console.ReadLine());

//         double fahrenheit = celsius * 9 / 5 + 32;
//         double kelvin = celsius + 273.15;

//         Console.WriteLine($"Temperatura en Fahrenheit: {fahrenheit}Â°F");
//         Console.WriteLine($"Temperatura en Kelvin: {kelvin} K");
//     }
// }


// class Program {
//     static void Main() {
//         Console.Write("Ingresa el límite de la suma: ");
//         int limite = Convert.ToInt32(Console.ReadLine());

//         int suma = 0;
//         int numero;

//         Console.WriteLine("Ingresa números para sumar (ingresa 0 para terminar):");
//         numero = Convert.ToInt32(Console.ReadLine());
//         suma += numero;

//         while (numero > 0 && suma < limite) {
//             numero = Convert.ToInt32(Console.ReadLine());
//             suma += numero;
//         }

//         Console.WriteLine($"La suma total es: {suma}");
//     }
// }


// class Program {
//     static void Main() {
//         int opcion;

//         do {
//             Console.WriteLine("Menú de opciones:");
//             Console.WriteLine("1. Opción 1");
//             Console.WriteLine("2. Opción 2");
//             Console.WriteLine("3. Salir");
//             Console.Write("Elige una opción: ");
//             opcion = Convert.ToInt32(Console.ReadLine());

//             switch (opcion) {
//                 case 1:
//                     Console.WriteLine("Seleccionaste Opción 1.");
//                     break;
//                 case 2:
//                     Console.WriteLine("Seleccionaste Opción 2.");
//                     break;
//                 case 3:
//                     Console.WriteLine("¡Hasta luego!");
//                     break;
//                 default:
//                     Console.WriteLine("Opción inválida. Inténtalo de nuevo.");
//                     break;
//             }
//         } while (opcion != 3);
//     }
// }


// class Program {
//     static void Main() {
//         string contraseña;
//         const int LongitudMinima = 8;

//         do {
//             Console.Write("Ingresa una contraseña (al menos 8 caracteres): ");
//             contraseña = Console.ReadLine();
//         } while (contraseña.Length < LongitudMinima);

//         Console.WriteLine("¡Contraseña válida ingresada!");
//     }
// }


// class Program {
//     static void Main() {
//         Console.Write("Ingresa un número N para generar la secuencia de Fibonacci: ");
//         int n = Convert.ToInt32(Console.ReadLine());

//         int a = 0;
//         int b = 1;

//         for (int i = 0; i < n; i++) {
//             Console.Write(a + " ");
//             int temp = a;
//             a = b;
//             b = temp + b;
//         }
//     }
// }


// class Program {
//     static void Main() {
//         Console.Write("Ingresa un número entero: ");
//         int numero = Math.Abs(Convert.ToInt32(Console.ReadLine())); // Convertir a valor absoluto para evitar problemas con números negativos

//         int contadorDigitos = 0;

//         while (numero > 0) {
//             numero /= 10;
//             contadorDigitos++;
//         }

//         Console.WriteLine($"El número tiene {contadorDigitos} dígitos.");
//     }
// }


// class Program {
//     static void Main() {
//         Console.Write("Ingresa el límite de la suma: ");
//         int limite = Convert.ToInt32(Console.ReadLine());
//         int suma = 0;
//         int numero;
//         Console.WriteLine("Ingresa números para sumar (ingresa 0 para terminar):");
//         numero = Convert.ToInt32(Console.ReadLine());
//         while ((numero != 0) && (suma < limite)){                        
//             suma += numero;       
//             numero = Convert.ToInt32(Console.ReadLine());
//         }
//         Console.WriteLine($"La suma total es: {suma}");
//     }
// }


// class Program {
//     static void Main() {
//         int numero;

//         do {
//             Console.Write("Ingresa un número positivo mayor que cero: ");
//             numero = Convert.ToInt32(Console.ReadLine());
//         } while (numero <= 0);

//         Console.WriteLine("¡Número válido ingresado!");
//     }
// }


// class Program {
//     static void Main() {
//         Console.Write("Ingresa una palabra: ");
//         string palabra = Console.ReadLine();

//         int contadorVocales = 0;
//         for (int i = 0; i < palabra.Length; i++) {
//             char caracter = char.ToLower(palabra[i]);
//             if (caracter == 'a' || caracter == 'e' || caracter == 'i' || caracter == 'o' || caracter == 'u') {
//                 contadorVocales++;
//             }
//         }

//         Console.WriteLine($"La palabra tiene {contadorVocales} vocales.");
//     }
// }


// class Program {
//     static void Main() {
//         Random random = new Random();
//         int numeroAleatorio = random.Next(1, 101);

//         int intentos = 0;
//         int numeroUsuario;

//         Console.WriteLine("Adivina el número entre 1 y 100.");

//         while (true) {
//             Console.Write("Ingresa tu intento: ");
//             numeroUsuario = Convert.ToInt32(Console.ReadLine());
//             intentos++;

//             if (numeroUsuario == numeroAleatorio) {
//                 Console.WriteLine($"¡Adivinaste! El número era {numeroAleatorio}. ¡Lo lograste en {intentos} intentos!");
//                 break;
//             } else if (numeroUsuario < numeroAleatorio) {
//                 Console.WriteLine("El número es mayor. Sigue intentando.");
//             } else {
//                 Console.WriteLine("El número es menor. Sigue intentando.");
//             }
//         }
//     }
// }


class Program {
    static void Main() {
        Console.Write("Ingresa un número entero positivo: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        int contadorDivisores = 0;

        int i = 1;
        while (i <= numero) {
            if (numero % i == 0) {
                contadorDivisores++;
            }
            i++;
        }

        Console.WriteLine($"El número {numero} tiene {contadorDivisores} divisores.");
    }
}