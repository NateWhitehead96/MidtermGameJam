using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossBehaviour : MonoBehaviour
{
    public Transform player;
    [SerializeField] float speed;
    private Vector3 offset;

    private void Start()
    {
        offset = new Vector3(0, 1.8f, 0);
    }
    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < 100)
        {
            transform.position = Vector3.MoveTowards(transform.position, player.position + offset, speed * Time.deltaTime);

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player")) // if caught by the boss reset the level
        {
            StartCoroutine(Death());
            //SceneManager.LoadScene("BossLevel");
        }
    }
    IEnumerator Death()
    {
        FindObjectOfType<PlayerBehaviour>().deathEffect.Play();
        FindObjectOfType<PlayerBehaviour>().dying = true;
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene("BossLevel");
    }
}
