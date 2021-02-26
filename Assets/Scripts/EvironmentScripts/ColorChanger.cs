using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    public PlayerColor objectColor;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (other.gameObject.GetComponent<PlayerBehaviour>().myColor != objectColor) // if the player is not the right color change his color
            {
                other.gameObject.GetComponent<PlayerBehaviour>().SetPlayerColor(objectColor);
            }
        }
    }
}
