using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_4 : MonoBehaviour
{
    [SerializeField] float num1, num2;


    void Start()
    {
        

        if (num2 == 0)
        {

            Debug.Log("ERROR: El divisor = 0");

        }
        else
        {

            float resultado = num1 / num2;
            Debug.Log("El resultado es: " +  resultado);

        }


    }

    // Update is called once per frame
    void Update()
    {

    }
}
