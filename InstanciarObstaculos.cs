using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciarObstaculos : MonoBehaviour
{
    public GameObject obstaculoPrefab;
    public float tiempoDeEspera = 2f;
    private float tiempoTranscurrido = 0;

    // Update is called once per frame
    void Update()
    {
        /*
         * La variable timepoTranscurrido incrementa por el valor de Time.deltaTime 
         * para llevar un seguimiento del timepo acumulado en el proceso.
         * (En Unity, Time.deltaTime representa el tiempo transcurrido desde el �ltimo frame).
        */
        tiempoTranscurrido += Time.deltaTime;

        // Condici�n que revisa si timepoTranscurrido es mayor o igual que tiempoDeEspera, entonces instancia el objeto.
        if (tiempoTranscurrido >= tiempoDeEspera)
        {
            // Lista con posiciones especificas en el eje x.
            List<float> posicionesX = new List<float> { -2.2f, 0f, 2.2f };

            // N�mero aleatorio de instancias generadas a la vez (1 o 2).
            int numInstancias = Random.Range(1, posicionesX.Count);

            // Ciclo que genera el n�mero de instancias seg�n numInstancias. 
            for (int i = 0; i < numInstancias; i++)
            {
                int index = Random.Range(0, posicionesX.Count); // �ndice aleatorio en el rango que le dimos a la lista posicionesX.
                float posX = posicionesX[index]; // Obtenemos la posici�n generada en el �ndice.
                posicionesX.RemoveAt(index); // Eliminamos la posici�n utilizada de la lista.

                // Instanciaci�n de los objetos, recibe de par�metros el objeto, la posici�n y la rotaci�n. 
                Instantiate(obstaculoPrefab, new Vector3(posX, transform.position.y, transform.position.z), Quaternion.identity);
            }

            tiempoTranscurrido = 0f; // Resetea el tiempoTranscurrido.
        }
    }
}