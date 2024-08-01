using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciarMonedas : MonoBehaviour
{
    public GameObject monedaPrefab;
    GameObject monedaInstanciada;
    public float tiempoDeEspera = 5f;
    private float tiempoTranscurrido = 0;

    // Update is called once per frame
    void Update()
    {
        /*
         * La variable timepoTranscurrido incrementa por el valor de Time.deltaTime 
         * para llevar un seguimiento del timepo acumulado en el proceso.
         * (En Unity, Time.deltaTime representa el tiempo transcurrido desde el último frame).
        */
        tiempoTranscurrido += Time.deltaTime;

        // Condición que revisa si timepoTranscurrido es mayor o igual que tiempoDeEspera, entonces instancia el objeto. 
        if (tiempoTranscurrido >= tiempoDeEspera)
        {
            // Arreglo con posiciones especificas en el eje x.
            float[] posicionesX = { -2.2f, 0f, 2.2f };

            /* 
             * Variable a la que se le asigna un valor aleatorio del arreglo posicionesX
             * Random.Range(0, posicionesX.Length) genera un índice aleatorio dentro del rango de la longitud del arreglo.
             * El valor correspondiente a ese índice se le asigna a posX
             */
            float posX = posicionesX[Random.Range(0, posicionesX.Length)];

            /*
             * Le asignamos a la variable monedaInstanciada la instanciación de objetos,
             * Que recibe el objeto original, la posición y la rotación.
             */ 
            monedaInstanciada = Instantiate(monedaPrefab, new Vector3(posX, transform.position.y, transform.position.z), Quaternion.Euler(0,90,0));
            monedaInstanciada.transform.localScale = new Vector3 (44.2f, 44.2f, 44.2f); // Escalamos la monedaInstanciada.
            monedaInstanciada.AddComponent<Rigidbody>(); // Agregamos el componente Rigidbody a la monedaInstanciada.
            monedaInstanciada.AddComponent<BoxCollider>(); // Agregamos el componente BoxCollider a la monedaInstanciada.

            tiempoTranscurrido = 0f; // Reseteamos el tiempoTranscurrido.
        }
        Destroy(monedaInstanciada,4f); // Destruye el objeto después de 4 segundos
    }
}