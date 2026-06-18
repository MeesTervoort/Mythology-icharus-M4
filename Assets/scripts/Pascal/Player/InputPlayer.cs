using UnityEngine;
using UnityEngine.InputSystem;

public class InputPlayer : MonoBehaviour
{
    [SerializeField]private InputActionAsset input;
    [SerializeField]private string actionMapName = "Player";
    [SerializeField] private float walkSpeed = 5f;
    [SerializeField] private float turnSpeed = 150f;
    [SerializeField] private float jumpForce = 5f;
    private InputAction moveAction;
    private InputAction jumpAction;
    private InputAction sprintAction;
    private InputActionMap map; 

    private Rigidbody rb;
    private bool isGrounded = false;

    private void Awake()
    {
        map = input.FindActionMap(actionMapName);
        moveAction = map.FindAction("Move");
        jumpAction = map.FindAction("Jump");
        sprintAction = map.FindAction("Sprint");
        rb = GetComponent<Rigidbody>();
    }

    void OnEnable()
    {
        map.Enable();
    }

    void OnDisable()
    {
        map.Disable();
    }

    void Update()
    {

        Vector2 moveInput = moveAction.ReadValue<Vector2>();

         //bepalen wat de snelheid is
        float speed = walkSpeed * moveInput.y;

        //sprinten
        if (sprintAction.IsPressed())
            speed *= 2f;

        //bewegen van de speler
        Vector3 movement = transform.forward * speed * Time.deltaTime;
        transform.Translate(movement, Space.World);

        //draaien van de speler
        float angle = moveInput.x * turnSpeed * Time.deltaTime;
        transform.Rotate(0f, angle, 0f, Space.World);


        // Springen
        if (jumpAction.WasPressedThisFrame() && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }


        Vector2 JoystickInput = moveAction.ReadValue<Vector2>();
        Debug.Log("Move: " + JoystickInput.x);
        Debug.Log("Move: " + JoystickInput.y);

        if(jumpAction.WasPressedThisFrame())
        {
            Debug.Log("Jump!");
        }
        if(jumpAction.WasReleasedThisFrame())
        {
            Debug.Log("Stop Jumping!");
        }
        if(sprintAction.IsInProgress())
        {
            Debug.Log("Sprint holding");
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
            isGrounded = true;
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
            isGrounded = false;
    }
}

