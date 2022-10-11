using System;
        double  firstNumber;
        double   secondNumber ;
        System.Console.Write("Birinchi sonni kiriting: ");
        firstNumber = Convert.ToDouble(Console .ReadLine());
        System.Console.WriteLine("Qanday amal bajaray  + , - , / , * ");
        string   operation = Console.ReadLine();
        System.Console.Write("Ikkinchi sonni kiriring: ");
        secondNumber = Convert.ToDouble(Console .ReadLine());
        //        switch (operation){
        //         case "+" : 
        //                 System.Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}"); break ;
        //         case "-":
        //                 System.Console.WriteLine($"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}"); break ;
        //         case "*":
        //                 System.Console.WriteLine($"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}"); break ;
        //         case "/":
        //                 System.Console.WriteLine($"{firstNumber} / {secondNumber} = {firstNumber / secondNumber}"); break ;
        //         default :
        //                 System.Console.WriteLine("Operesion Not Found"); break ;
        // }
        string  result = operation switch{
                "+" => $"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}",
                "-" => $"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}",
                "*" => $"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}",
                "/" => $"{firstNumber} / {secondNumber} = {firstNumber / secondNumber}",
                _   => "Operesion Not Found"
        };

        System.Console.WriteLine(result);
        
 
        // System.Console.Write("Birinchi sonni kiriting: ");
        // firstNumber = Convert.ToInt32 (Console .ReadLine());
        // System.Console.Write("Ikkinchi sonni kiriring: ");
        // secondNumber = Convert.ToInt32(Console .ReadLine());
        // System.Console.WriteLine($"Yig`indi: {firstNumber + secondNumber} ");
        // System.Console.WriteLine($"Ayirma: {firstNumber - secondNumber}" );
        // System.Console.WriteLine($"Bo`linma: {firstNumber / secondNumber}");
        // System.Console.WriteLine($"Ko`paytma: {firstNumber * secondNumber}");
        // System.Console.WriteLine($"Qoldiq: {firstNumber % secondNumber}" );

        // System.Console.WriteLine($"Birinchi son ikkinchi sondan katta:  {firstNumber > secondNumber}");
        // System.Console.WriteLine($"Birinchi son ikkinchi sondan kichik:  {firstNumber < secondNumber}");
        // System.Console.WriteLine($"Birinchi son ikkinchi sondan katta yoki teng:  {firstNumber >= secondNumber}");
        // System.Console.WriteLine($"Birinchi son ikkinchi sondan kichik yoki teng:  {firstNumber <= secondNumber}");
        // System.Console.WriteLine($"Birinchi son ikkinchi songa teng:  {firstNumber == secondNumber}");
        // System.Console.WriteLine($"Birinchi son ikkinchi songa tengemas:  {firstNumber != secondNumber}");
        // string message = 
        //         firstNumber >= 0
        //                 ? "1st number is positive"
        //                 : "1st number is negative";
        // System.Console.WriteLine(message);


        // if(firstNumber > secondNumber ){
        //         System.Console.WriteLine("Birinchi son ikkinchi sondan katta");
        // }
        // else if(firstNumber == secondNumber ){
        //         System.Console.WriteLine("Birinchi son Ikkinchi songa teng");
        // }
        // else {
        //         System.Console.WriteLine("Ikkinchi son Birinchi sondan katta");
        // }

        // string javob = firstNumber >= 0 && secondNumber >=0
        //                 ? "1st and 2nd numbers are positive"
        //                 : "1st and 2nd numbers are negative";
        // System.Console.WriteLine(javob);
        //         string javob2 = firstNumber >= 0 || secondNumber >=0
        //                 ? "1st and 2nd numbers are positive"
        //                 : "1st and 2nd numbers are negative";
        // System.Console.WriteLine(javob2);
        // string javob3 = !(firstNumber >= 0 && secondNumber >=0)
        //                 ? "1st and 2nd numbers are not positive"
        //                 : "1st and 2nd numbers are not negative";
        // System.Console.WriteLine(javob3);
