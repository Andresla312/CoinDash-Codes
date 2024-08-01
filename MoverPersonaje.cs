using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class MoverPersonaje : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        // Condici�n que revisa si la tecla de flecha derecha ha sido liberada. 
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            // Condici�n que revisa la posici�n del objeto en x, si es menor a 2.2f. 
            if (transform.position.x < 2.2f)
            {
                transform.position += new Vector3(2.2f, 0, 0); // El personaje se mueve 2.2 en x.
            }
         
        }
        // Condici�n que revisa si la tecla de flecha izquierda ha sido liberada.
        else if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            // Condici�n que revisa la posici�n del objeto en x, si es mayor a -2.2f.
            if (transform.position.x > -2.2f)
            {
                transform.position += new Vector3(-2.2f, 0, 0); // El personaje se mueve -2.2 en x.
            }   
        }
    }
}