using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_3 : MonoBehaviour
{
    int vidas;
    float exp;

    // Start is called before the first frame update
    void Start()
    {

        vidas = 10;
        exp = 100.5f;

        float producto = vidas * exp;
        float cociente = vidas / exp;
        int dobleVidas = vidas * 2;
        float tripleExp = exp * 3;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
