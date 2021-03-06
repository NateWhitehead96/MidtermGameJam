using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerBallBehaviour : MonoBehaviour
{
    public Transform Spawn;
    private Rigidbody rigidbody;
    private MeshRenderer mesh;
    //private Animator animator;
    public PlayerColor myColor;
    public Material[] colorMaterials;
    [SerializeField] bool isJumping = false;
    [SerializeField] float jumpPower;
    [SerializeField] float moveSpeed;
    [SerializeField] Vector2 moveVector;
    // Start is called before the first frame update

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
        mesh = GetComponent<MeshRenderer>();
        //animator = GetComponent<Animator>();
        isJumping = false;
        myColor = FindObjectOfType<PlayerBehaviour>().myColor;
    }
    void Start()
    {
        myColor = FindObjectOfType<PlayerBehaviour>().myColor;
        if (myColor == PlayerColor.RED)
        {
            mesh.material = colorMaterials[0];
        }
        if (myColor == PlayerColor.YELLOW)
        {
            mesh.material = colorMaterials[1];
        }
        if (myColor == PlayerColor.GREEN)
        {
            mesh.material = colorMaterials[2];
        }
        if (myColor == PlayerColor.BLUE)
        {
            mesh.material = colorMaterials[3];
        }
    }

    public void OnMove(InputValue value)
    {
        moveVector = value.Get<Vector2>();
        print("working");
    }

    public void OnJump(InputValue pressed)
    {

        if (pressed.isPressed)
        {
            isJumping = true;
            //animator.SetBool("Jumping", true);
        }
        rigidbody.AddForce(Vector3.up * jumpPower);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isJumping = false;
            //animator.SetBool("Jumping", false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x + moveVector.x * moveSpeed * Time.deltaTime, transform.position.y, transform.position.z + moveVector.y * moveSpeed * Time.deltaTime);

    }

    public void SetPlayerColor(PlayerColor newColor)
    {
        if (newColor == PlayerColor.RED)
        {
            myColor = newColor;
            mesh.material = colorMaterials[0];
        }
        if (newColor == PlayerColor.YELLOW)
        {
            myColor = newColor;
            mesh.material = colorMaterials[1];
        }
        if (newColor == PlayerColor.GREEN)
        {
            myColor = newColor;
            mesh.material = colorMaterials[2];
        }
        if (newColor == PlayerColor.BLUE)
        {
            myColor = newColor;
            mesh.material = colorMaterials[3];
        }
    }

    public void ResetPosition()
    {
        transform.position = Spawn.position;
    }
}
