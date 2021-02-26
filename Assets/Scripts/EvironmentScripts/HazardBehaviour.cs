using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HazardBehaviour : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<PlayerBehaviour>().ResetPosition();
        }
        else if(collision.gameObject.CompareTag("DeathPlane"))
        {
            Destroy(gameObject);
        }
    }
}
