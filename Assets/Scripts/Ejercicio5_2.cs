using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_2 : MonoBehaviour
{
    [SerializeField] float num1, num2;

    // Start is called before the first frame update
    void Start()
    {
        

        if (num1 >=3 & num2 >=3)
        {

            Debug.Log("Los numeros son mayores o iguales a 3");

        }
        else
        {

            Debug.Log("Los numeros son menores a 3");

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
