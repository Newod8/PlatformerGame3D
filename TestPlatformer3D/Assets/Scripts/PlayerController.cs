using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] GameObject movementPerspective;
    [SerializeField] float playerSpeed;
    [SerializeField] float jumpHeight;

    private Rigidbody rigidBody;
    private Vector3 movementVector;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // MOVEMENT HANDLING ----------------------------------
        int horizontalInput = 0;
        int forwardInput = 0;
        float speed;
        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = playerSpeed * 1.5f;
        }
        else
        {
            speed = playerSpeed;
        }
        if (Input.GetKey(KeyCode.W))
        {
            forwardInput += 1;
        }
        if (Input.GetKey(KeyCode.A))
        {
            horizontalInput -= 1;
        }
        if (Input.GetKey(KeyCode.S))
        {
            forwardInput -= 1;
        }
        if (Input.GetKey(KeyCode.D))
        {
            horizontalInput += 1;
        }

        movementVector = movementPerspective.transform.forward * forwardInput + movementPerspective.transform.right * horizontalInput;
        movementVector.y = 0;

        rigidBody.linearVelocity += movementVector.normalized * speed * Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidBody.linearVelocity += new Vector3(0, jumpHeight, 0);
        }
        
        // ----------------------------------------------------

    }
}
