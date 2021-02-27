using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SpikeyBehaviour : MonoBehaviour
{
    public Transform player;
    private NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(player.position);
        transform.rotation = Quaternion.Euler(-90, 0, 0);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            StartCoroutine(Death());
            //collision.gameObject.GetComponent<PlayerBehaviour>().ResetPosition();
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
