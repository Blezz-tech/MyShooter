using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballSource : MonoBehaviour
{
    public Transform targetPoint;

    void Start()
    {
        
    }

    void Update()
    {
        transform.LookAt(targetPoint.position);
    }
}
