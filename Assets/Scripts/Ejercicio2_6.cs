using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_6 : MonoBehaviour
{
    int puntuacion1 = 5, puntuacion2 = 10, puntuacion3 = 15;

    // Start is called before the first frame update
    void Start()
    {



        Debug.Log(puntuacion1);
        Debug.Log(puntuacion2);
        Debug.Log(puntuacion3);

        float media = (puntuacion1 + puntuacion2 + puntuacion3) / 3;

        Debug.Log("La media es " + media);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
