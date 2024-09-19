using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_5 : MonoBehaviour
{
    [SerializeField] float radio;
    float circulo;
    string moneda;

    float cantidad = 1;
    string info;

    // Start is called before the first frame update
    void Start()
    {
        resultadoCirculo();
        Convertir(circulo, moneda);
        Debug.Log(info);
        Debug.Log("Para convertir de dolar a euro, escriba: dolar en el apartado: moneda");

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    float resultadoCirculo()
    {
        circulo = (radio * radio) * 3.14f;
        return circulo;
        
    }

    string Convertir(float circulo, string moneda)
    {
        if (moneda == "euro")
        {

            circulo /= 1.11f;
            moneda = "dolares";

        }
        else if (moneda == "dolar")
        {

            circulo = circulo * 1.11f;
            moneda = "euros";

        }


        info = ("Tienes " + circulo + " " + moneda);
        return info;
    }
}
