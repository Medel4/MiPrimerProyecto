using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_2 : MonoBehaviour
{
    int vidas = 10;
    float exp = 100;
    char carac;

    
    void Start()
    {
        Debug.Log("El valor de vidas es " + vidas);
        Debug.Log("El valor de expereeriencia es " + exp);

        float resultadoSuma = vidas + exp;
        float resultadoResta = exp - vidas;

        Debug.Log("El valor de resultadoSuma es " + resultadoSuma);
        Debug.Log("El valor de resultadoResta es " + resultadoResta);


    }


    void Update()
    {
        
    }
}
