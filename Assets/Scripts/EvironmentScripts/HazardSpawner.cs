using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HazardSpawner : MonoBehaviour
{
    public Transform[] spawns;
    public GameObject hazard;

    [SerializeField] float spawnTimer;
    // Start is called before the first frame update
    void Start()
    {
        spawnTimer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(spawnTimer >= 2)
        {
            int randomSpawn = Random.Range(0, spawns.Length);
            Instantiate(hazard, spawns[randomSpawn].transform.position, Quaternion.identity);
            spawnTimer = 0;
        }
        spawnTimer += Time.deltaTime;
    }
}
