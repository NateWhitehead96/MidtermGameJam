using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = new Vector3(0, 3, -10);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset;
        if(FindObjectOfType<PlayerBehaviour>().myColor == PlayerColor.RED)
        {
            Camera.main.backgroundColor = Color.red;
        }
        if (FindObjectOfType<PlayerBehaviour>().myColor == PlayerColor.YELLOW)
        {
            Camera.main.backgroundColor = Color.yellow;
        }
        if (FindObjectOfType<PlayerBehaviour>().myColor == PlayerColor.GREEN)
        {
            Camera.main.backgroundColor = Color.green;
        }
        if (FindObjectOfType<PlayerBehaviour>().myColor == PlayerColor.BLUE)
        {
            Camera.main.backgroundColor = Color.blue;
        }
    }
}
