using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    public float rotationSpeed; // Velocidade de rotação

    void Update()
    {
        // Rotaciona o objeto ao redor do eixo Z
        transform.Rotate(Vector3.forward, rotationSpeed * Time.deltaTime);
    }
}
