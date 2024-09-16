using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_3 : MonoBehaviour
{
    [SerializeField] int num1;
    float num2;
    float num3;
    // Start is called before the first frame update
    void Start()
    {
        num2 = num1 * 2;
        num3 = num1 * 3;
        Debug.Log(num2);
        Debug.Log(num3);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
