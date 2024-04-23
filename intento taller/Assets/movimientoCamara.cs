using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguimientoCamara : MonoBehaviour
{
    public Transform objetivo; 
    public Vector3 offset = new Vector3(0f, 5f, -10f); 

    void Update()
    {
        
        if (objetivo != null)
        {
            
            Vector3 posicionDeseada = objetivo.position + offset;
            
            transform.position = Vector3.Lerp(transform.position, posicionDeseada, Time.deltaTime * 5f);
        }
    }
}
