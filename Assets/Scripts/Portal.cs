using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour
{
    public float minSpeed = 5f;
    public float maxSpeed = 360f;
    public float aceleration = 5f;
    public float rotationSpeed = 10f;


    private void Start()
    {
        transform.Rotate(0, 0, 0);
    }

    void Update()
    {
        if (rotationSpeed > maxSpeed)
        {
            aceleration *= -1;
        } 
        else if (rotationSpeed < minSpeed)
        {
            aceleration *= -1;

        }
        rotationSpeed += aceleration * Time.deltaTime;

        transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);



    }

}
