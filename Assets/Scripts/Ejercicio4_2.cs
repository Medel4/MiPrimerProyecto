using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_2 : MonoBehaviour
{

    string info;
    string nombre = "Yago";
    string apellido1 = "Medel";
    string apellido2 = "Marcos";
    int edad = 19;


    void Start()
    {

        construirNombre(nombre, apellido1, apellido2);
        Debug.Log(info);        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    string construirNombre(string nombre, string apellido1, string apellido2)
    {

        info = ("La persona se llama " + nombre + " " + apellido1 + " " + apellido2 + " y tiene " + edad + " años");
        return info;

    }
}
