using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_7 : MonoBehaviour
{
    int oro = 0;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(oro);

        oro = 7 * 14400;

        Debug.Log("Tras 4 horas tienes " + oro + " De oro");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
