using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Colisiones : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Condición que revisa si el nombre del objeto es igual a "MarioCoin(Clone)"
        if (other.gameObject.name == "MarioCoin(Clone)")
        {
            Destroy(other.gameObject); // Destruye el objeto 
            Marcador.contador += 10; // Se suman 10 puntos al contador del marcador. 
        }

        // Condición que revisa si el nombre del objeto es igual a "Obstaculo 1(Clone)"
        if (other.gameObject.name == "Obstaculo 1(Clone)")
        {
            SceneManager.LoadScene(1); // Cambia a la escena "GameOver"
        }
    }
}