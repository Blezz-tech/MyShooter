using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class win : MonoBehaviour
{
    public PlayerHealth player;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("meow");
        player.PlayerIsDead("WIN !!!");
    }
}
