using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_8 : MonoBehaviour
{
    float vida = 100f;
    float venenoInicial = 0.03f;
    float veneno = 0.03f;
    float vidaInicial = 0;
    int vecesVidaQuitada = 0;

    // Start is called before the first frame update
    void Start()
    {
        
        vidaInicial = vida;
        
    }

    // Update is called once per frame
    void Update()
    {

        if (vecesVidaQuitada <=4)
        {

            Debug.Log("Su vida es de " + vida);
            vida -= (vidaInicial * veneno);
            veneno = veneno + venenoInicial;
            vecesVidaQuitada++;

        }
        


        
    }
}
