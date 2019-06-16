using System;

public class Class1 {
    static void Aula68() {

        //Valores opcional
        double? x = null;
        double? y = null;
        double a;
        double b;

        Console.WriteLine(y.GetValueOrDefault());

        a = x ?? 5.0;

        Console.WriteLine(a);
    }
}
