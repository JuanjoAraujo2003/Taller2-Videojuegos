using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public float speed = 5f;
    public float rotationSpeed = 150f; 

    void Update()
    {
        
        float horizontalMovement = Input.GetAxis("Vertical");
        float verticalMovement = Input.GetAxis("Horizontal");

        Vector3 movement = new Vector3(horizontalMovement, 0f, verticalMovement);
      
        transform.Translate(movement * speed * Time.deltaTime);
      
        float lateralRotation = Input.GetAxis("Mouse X");
        
        float rotationAmount = lateralRotation * rotationSpeed * Time.deltaTime;

        transform.Rotate(Vector3.up, rotationAmount);
    }
}
