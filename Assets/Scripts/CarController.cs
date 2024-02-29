using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    [SerializeField] private float speed = 15f;       //Velocidade de aceleração
    [SerializeField] private float turnSpeed = 80f;   //Velocidade de rotação
    float forwardInput;
    float horizontalInput;
    [SerializeField] private Vector3 verticalaxis;

    void Update()
    {
        movimento();

    }

    private void movimento()
    {
        verticalaxis = transform.localPosition * 0;

        forwardInput = Input.GetAxis("Vertical");       //recebe a tecla para andar para a frente
        horizontalInput = Input.GetAxis("Horizontal");  //recebe a tecla para virar o carro
        

        transform.Translate(Vector3.forward * speed * Time.deltaTime * forwardInput);

        if (forwardInput < 0)
        {
            horizontalInput = -horizontalInput;
        }

        if (forwardInput != 0)
        {
            transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime * horizontalInput);    //Vira o carro
        }

    }
}
