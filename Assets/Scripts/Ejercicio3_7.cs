using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_7 : MonoBehaviour
{
    [SerializeField] float basexd;
    [SerializeField] float altura;
    float area;
    
    // Start is called before the first frame update
    void Start()
    {

        area = basexd * altura / 2;

        Debug.Log("El area es: " + area);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
