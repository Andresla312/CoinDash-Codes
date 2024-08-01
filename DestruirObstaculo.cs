using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirObstaculo : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        // Destruye el objeto después de 4 segundos.
        Destroy(gameObject,4);
    }
}
