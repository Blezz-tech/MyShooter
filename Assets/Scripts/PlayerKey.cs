using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerKey : MonoBehaviour
{
    public bool isHasKey = false;
    public float distance = 1f;
    public Transform objectKey;

    void Update()
    {
        if ( !isHasKey &&
            Mathf.Pow(transform.position.x - objectKey.position.x, 2) +
            Mathf.Pow(transform.position.y - objectKey.position.y, 2) < Mathf.Pow(distance, 2))
        {
            Destroy(objectKey.gameObject);
            isHasKey = true;
        }
    }
}
