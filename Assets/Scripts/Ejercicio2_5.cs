using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_5 : MonoBehaviour
{
    int vidasPlayer1 = 10;
    int vidasPlayer2 = 20;
    int vidasPlayer3 = 30;
    int vidasPlayer4 = 40;

    // Start is called before the first frame update
    void Start()
    {
        int vidasRobadas = vidasPlayer2;

        Debug.Log("vidas player 1 " + vidasPlayer1);
        Debug.Log("vidas player 2 " + vidasPlayer2);
        Debug.Log("vidas player 3 " + vidasPlayer3);
        Debug.Log("vidas player 4 " + vidasPlayer4);

        vidasPlayer2 = vidasPlayer3; 
        Debug.Log("vidas player 2 " + vidasPlayer2);
        Debug.Log("vidas player 3 " + vidasPlayer3);

        vidasPlayer3 = vidasPlayer1;
        Debug.Log("vidas player 3 " + vidasPlayer3);
        Debug.Log("vidas player 1 " + vidasPlayer1);

        vidasPlayer1 = vidasPlayer4;
        Debug.Log("vidas player 1 " + vidasPlayer1);
        Debug.Log("vidas player 4 " + vidasPlayer4);

        
        vidasPlayer4 = vidasRobadas;
        Debug.Log("vidas player 4 " + vidasPlayer4);
        Debug.Log("vidas player 2 " + vidasRobadas);
        
        Debug.Log("Los resultados son:");

        Debug.Log("vidas player 1 " + vidasPlayer1);
        Debug.Log("vidas player 2 " + vidasPlayer2);
        Debug.Log("vidas player 3 " + vidasPlayer3);
        Debug.Log("vidas player 4 " + vidasPlayer4);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
