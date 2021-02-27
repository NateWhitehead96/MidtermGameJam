using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkOverScript : MonoBehaviour
{
    public PlayerColor objectColor;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            if(other.gameObject.GetComponent<PlayerBehaviour>().myColor != objectColor) // if the player is not the right color send him back to spawn
            {
                other.gameObject.GetComponent<PlayerBehaviour>().ResetPosition();
            }
            
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (collision.gameObject.GetComponent<PlayerBehaviour>().myColor != objectColor) // if the player is not the right color send him back to spawn
            {
                collision.gameObject.GetComponent<PlayerBehaviour>().ResetPosition();
            }

        }
    }
}
