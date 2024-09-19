using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_4 : MonoBehaviour
{

    float info;
    [SerializeField] float kmh;
    float ms;

    // Start is called before the first frame update
    void Start()
    {
        Convertir(kmh, ms);
        Debug.Log(info);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    float Convertir(float kmh, float ms)
    {

        ms = kmh * 1000 / 3600;
        Debug.Log(kmh + " KM/H son " + ms + " M/S");

        return info;
    }
}
