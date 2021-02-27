using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HazardBehaviour : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            StartCoroutine(Death());
            //collision.gameObject.GetComponent<PlayerBehaviour>().ResetPosition();
        }
        else if(collision.gameObject.CompareTag("DeathPlane"))
        {
            Destroy(gameObject);
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
