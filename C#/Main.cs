using System;

public class Hello{
    public static void Main(){
        // When min is 0 and max is 10
    
        // 0 is output
        Console.WriteLine("{0}", NumericNormalization(0, 0, 10));
        
        // 5 is output
        Console.WriteLine("{0}", NumericNormalization(5, 0, 10));
        
        // 10 is output
        Console.WriteLine("{0}", NumericNormalization(10, 0, 10));
        
        // 10 is output
        Console.WriteLine("{0}", NumericNormalization(-1, 0, 10));
        
        // 0 is output
        Console.WriteLine("{0}", NumericNormalization(11, 0, 10));
    }
    
    public static int NumericNormalization(int x, int min, int max) {
        int mag = (max - min) + 1;
        x = (x - min) % mag + min;
        if (x < min) {
            x += mag;
        }
        return x;
    }
    
    public static float NumericNormalization(float x, float min, float max) {
        float mag = (max - min) + 1f;
        x = (x - min) % mag + min;
        if (x < min) {
            x += mag;
        }
        return x;
    }
    
    public static double NumericNormalization(double x, double min, double max) {
        double mag = (max - min) + 1;
        x = (x - min) % mag + min;
        if (x < min) {
            x += mag;
        }
        return x;
    }
}
