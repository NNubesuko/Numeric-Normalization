#include <stdio.h>
int main(void){
    // When min is 0 and max is 10
    
    // 0 is output
    printf("%d\n", numericNormalization(0, 0, 10));
    
    // 5 is output
    printf("%d\n", numericNormalization(5, 0, 10));
    
    // 10 is output
    printf("%d\n", numericNormalization(10, 0, 10));
    
    // 10 is output
    printf("%d\n", numericNormalization(-1, 0, 10));
    
    // 0 is output
    printf("%d\n", numericNormalization(11, 0, 10));
    
    return 0;
}

int numericNormalization(int x, int min, int max) {
    int mag = (max - min) + 1;
    x = (x - min) % mag + min;
    if (x < min) {
        x += mag;
    }
    return x;
}