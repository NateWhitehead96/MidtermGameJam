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
                StartCoroutine(Death());
                //other.gameObject.GetComponent<PlayerBehaviour>().ResetPosition();
            }
            
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (collision.gameObject.GetComponent<PlayerBehaviour>().myColor != objectColor) // if the player is not the right color send him back to spawn
            {
                StartCoroutine(Death());
                //collision.gameObject.GetComponent<PlayerBehaviour>().ResetPosition();
            }

        }
    }

    IEnumerator Death()
    {
        FindObjectOfType<PlayerBehaviour>().deathEffect.Play();
        FindObjectOfType<PlayerBehaviour>().dying = true;
        yield return new WaitForSeconds(1.5f);
        FindObjectOfType<PlayerBehaviour>().ResetPosition();
    }
}
