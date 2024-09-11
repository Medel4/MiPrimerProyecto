using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio1 : MonoBehaviour
{

    public string nombre = "Yago";



    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello Wolrd!");
        Debug.Log("Este es el primer videojuego de " + nombre);
        Debug.Log("Estoy aprendiendo C#");

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Ha pasado un frame");
        // Se repite porque está en el Update
    }
}
