using Palmmedia.ReportGenerator.Core.Reporting.Builders.Rendering;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_6 : MonoBehaviour
{
    [SerializeField] float kmh;
    float ms;



    // Start is called before the first frame update
    void Start()
    {

        ms = kmh * 1000 / 3600;
        Debug.Log(kmh + " KM/H son " + ms + " M/S");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
