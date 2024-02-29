using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public float verticalInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Movimento();
    }

    private void Movimento()
    {   
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");

        // rotate the plain backward and forward
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime * verticalInput);

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
