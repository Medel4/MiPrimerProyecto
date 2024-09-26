using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_5 : MonoBehaviour
{

    [SerializeField] float nivelPersonaje;


    void Start()
    {

        float resto = nivelPersonaje % 2;

        if (resto == 0)
        {

            Debug.Log("Par");

        }
        else
        {

            
            Debug.Log("Impar");

        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
