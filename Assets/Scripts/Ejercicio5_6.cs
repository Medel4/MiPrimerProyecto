using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_6 : MonoBehaviour
{
    [SerializeField] int num;
    // Start is called before the first frame update
    void Start()
    {

        if (num % 10 == 0)
        {

            Debug.Log("Has subido 10 niveles");

        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
