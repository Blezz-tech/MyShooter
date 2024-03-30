using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyMove : MonoBehaviour
{
    public float rotationSpeed = 10;

    void Update()
    {
        transform.Rotate(rotationSpeed * Time.deltaTime, rotationSpeed * Time.deltaTime, rotationSpeed * Time.deltaTime);
    }
}
