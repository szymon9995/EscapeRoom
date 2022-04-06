using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Basic movemnt
    public float moveSpeed;
    public float maxVelocity;

    public Transform orientation;

    private float horizontalInput;
    private float verticalInput;

    private Vector3 moveDir;

    private Rigidbody rb;

    //Drag
    public float playerHeight;
    public float groundDrag;
    public LayerMask isGround; //Layer for ground is "IsGround"

    private float playerExtraH = 0.2f;
    private bool grounded;

    //Jumping
    public float jumpForce;
    public float jumpCooldown;
    public float airForce;

    private bool canJump;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
        canJump = true;
    }

    void Update()
    {
        CheckIsGrounded();
        ProcessInput();
        SpeedLimiter();
        HandleGrounded();
    }

    private void FixedUpdate()
    {
        MovePlayer();
    }

    private void ProcessInput()
    {
        //Get Vertical and Horizontal Input from keyboard
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");

        if(Input.GetKey(KeyCode.Space) && grounded && canJump)
        {
            canJump = false;

            Jump();

            Invoke(nameof(ResetJump), jumpCooldown);
        }
    }

    private void MovePlayer()
    {
        //Move where we are loking towards.
        moveDir = orientation.forward * verticalInput + orientation.right * horizontalInput;

        if(grounded)
            rb.AddForce(moveDir.normalized * moveSpeed, ForceMode.Force);
        else
            rb.AddForce(moveDir.normalized * moveSpeed * airForce, ForceMode.Force);

    }

    private void CheckIsGrounded()
    {
        //Checks if player is on ground
        grounded = Physics.Raycast(transform.position, Vector3.down, playerHeight * 0.5f + playerExtraH, isGround);
    }

    private void HandleGrounded()
    {
        //Add drag if player is on ground
        if(grounded)
        {
            rb.drag = groundDrag;
        }
        else
        {
            rb.drag = 0.0f;
        }
    }

    private void SpeedLimiter()
    {
        Vector3 vel = new Vector3(rb.velocity.x, 0, rb.velocity.z);

        if(vel.magnitude > maxVelocity)
        {
            Vector3 objVelocity = vel.normalized * maxVelocity;
            rb.velocity = new Vector3(objVelocity.x, rb.velocity.y, objVelocity.z);
        }
    }

    private void Jump()
    {
        //reset jump velocity
        rb.velocity = new Vector3(rb.velocity.x, 0, rb.velocity.z);

        rb.AddForce(transform.up * jumpForce, ForceMode.Impulse);
    }

    private void ResetJump()
    {
        canJump = true;
    }
}
