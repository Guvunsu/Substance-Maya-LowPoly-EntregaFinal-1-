using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnAround : MonoBehaviour
{


    public float rotationSpeed = 100f; // Velocidad de rotaci�n
    private bool isTurning = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) // Cambia la tecla seg�n lo necesites
        {
            isTurning = !isTurning; // Cambia el estado de giro
        }

        if (isTurning)
        {
            // Rota el objeto alrededor de su eje Y
            transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
        }
    }
}

