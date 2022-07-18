public class Main {
    public static void main(String[] args) {
        // When min is 0 and max is 10

        // 0 is output
        System.out.printf("%d\n", numericNormalization(0, 0, 10));

        // 5 is output
        System.out.printf("%d\n", numericNormalization(5, 0, 10));

        // 10 is output
        System.out.printf("%d\n", numericNormalization(10, 0, 10));

        // 10 is output
        System.out.printf("%d\n", numericNormalization(-1, 0, 10));

        // 0 is output
        System.out.printf("%d\n", numericNormalization(11, 0, 10));
    }

    public static int numericNormalization(int x, int min, int max) {
        int mag = (max - min) + 1;
        x = (x - min) % mag + min;
        if (x < min) {
            x += mag;
        }
        return x;
    }
    
    public static float numericNormalization(float x, float min, float max) {
        float mag = (max - min) + 1f;
        x = (x - min) % mag + min;
        if (x < min) {
            x += mag;
        }
        return x;
    }
    
    public static double numericNormalization(double x, double min, double max) {
        double mag = (max - min) + 1;
        x = (x - min) % mag + min;
        if (x < min) {
            x += mag;
        }
        return x;
    }
}