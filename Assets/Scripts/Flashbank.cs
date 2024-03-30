using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashbank : MonoBehaviour
{
    public Transform mycamera;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        transform.rotation = mycamera.rotation;
    }
}