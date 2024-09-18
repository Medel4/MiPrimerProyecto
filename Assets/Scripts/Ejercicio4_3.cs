using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using UnityEngine;
using UnityEngine.UIElements;

public class Ejercicio4_3 : MonoBehaviour
{
    float cantidad = 1;
    [SerializeField] string moneda = "euro";
    string info;

    // Start is called before the first frame update
    void Start()
    {
        Convertir(cantidad, moneda);
        Debug.Log(info);
        Debug.Log("Para convertir de dolar a euro, escriba: dolar en el apartado: moneda");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    string Convertir(float cantidad, string moneda)
    {
        if (moneda == "euro")
        {

            cantidad /= 1.11f;
            moneda = "dolares";

        }
        else if (moneda == "dolar")
        {

            cantidad = cantidad * 1.11f;
            moneda = "euros";

        }


        info = ("Tienes " + cantidad + " " + moneda);
        return info;
    }
}
