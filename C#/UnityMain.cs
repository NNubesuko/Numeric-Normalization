using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityMain : MonoBehaviour {
    private void Start() {
        // When min is 0 and max is 10
    
        // 0 is output
        Debug.LogFormat("{0}", NumericNormalization(0, 0, 10));

        // 5 is output
        Debug.LogFormat("{0}", NumericNormalization(5, 0, 10));

        // 10 is output
        Debug.LogFormat("{0}", NumericNormalization(10, 0, 10));

        // 10 is output
        Debug.LogFormat("{0}", NumericNormalization(-1, 0, 10));

        // 0 is output
        Debug.LogFormat("{0}", NumericNormalization(11, 0, 10));
    }

    private int NumericNormalization(int x, int min, int max) {
        int mag = (max - min) + 1;
        x = (x - min) % mag + min;
        if (x < min) {
            x += mag;
        }
        return x;
    }

    public float NumericNormalization(float x, float min, float max) {
        float mag = (max - min) + 1f;
        x = (x - min) % mag + min;
        if (x < min) {
            x += mag;
        }
        return x;
    }
}