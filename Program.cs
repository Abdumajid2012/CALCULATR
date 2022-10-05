using System;


        int firstNumber;
        int secondNumber;
        System.Console.Write("Birinchi sonni kiriting: ");
        firstNumber = Convert.ToInt32 (Console .ReadLine());
        System.Console.Write("Ikkinchi sonni kiriring: ");
        secondNumber = Convert.ToInt32(Console .ReadLine());
        System.Console.WriteLine($"Yig`indi: {firstNumber + secondNumber} ");
        System.Console.WriteLine($"Ayirma: {firstNumber - secondNumber}" );
        System.Console.WriteLine($"Bo`linma: {firstNumber / secondNumber}");
        System.Console.WriteLine($"Ko`paytma: {firstNumber * secondNumber}");
        System.Console.WriteLine($"Qoldiq: {firstNumber % secondNumber}" );

        System.Console.WriteLine($"Birinchi son ikkinchi sondan katta:  {firstNumber > secondNumber}");
        System.Console.WriteLine($"Birinchi son ikkinchi sondan kichik:  {firstNumber < secondNumber}");
        System.Console.WriteLine($"Birinchi son ikkinchi sondan katta yoki teng:  {firstNumber >= secondNumber}");
        System.Console.WriteLine($"Birinchi son ikkinchi sondan kichik yoki teng:  {firstNumber <= secondNumber}");
        System.Console.WriteLine($"Birinchi son ikkinchi songa teng:  {firstNumber == secondNumber}");
        System.Console.WriteLine($"Birinchi son ikkinchi songa tengemas:  {firstNumber != secondNumber}");