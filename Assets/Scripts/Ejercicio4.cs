using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4 : MonoBehaviour
{
    [SerializeField] float radio;
    [SerializeField] float basexd;
    [SerializeField] float altura;
    [SerializeField] float lado;

    float circulo;
    float triangulo;
    float cuadrado;
    // Start is called before the first frame update
    void Start()
    {

        resultadoCirculo();
        resultadoCuadrado();
        resultadoTriangulo();
        

        Debug.Log("EL area del circulo es " +  circulo);
        Debug.Log("EL area del triangulo es " +  triangulo);
        Debug.Log("EL area del cuadrado es " +  cuadrado);



    }

    // Update is called once per frame
    void Update()
    {
        
    }

    float resultadoCirculo ()         
    {
        circulo = (radio * radio) * 3.14f;
        return circulo; 
    }
    float resultadoTriangulo()
    {
        triangulo = (basexd * altura) / 2;
        return triangulo;
    }
    float resultadoCuadrado()
    {
        cuadrado = lado * lado;
        return cuadrado;
    }
}
