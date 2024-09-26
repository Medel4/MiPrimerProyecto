using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5 : MonoBehaviour
{
    [SerializeField] float num1, num2;
 

    void Start()
    {
        float resultado = num1 - num2;

        if (resultado == 0)
        {
            
            Debug.Log("Los numeros son iguales");

        }
        else
        {

            Debug.Log("Los numeros son distintos");

        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
