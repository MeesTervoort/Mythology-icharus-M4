using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField]private InputActionAsset input;
    [SerializeField]private string actionMapName = "Player";
    [SerializeField] public static float WalkSpeed = 5f;
    [SerializeField] private float turnSpeed = 150f;
    [SerializeField] public static float jumpForce = 5f;
    [SerializeField] public static float Strength = 5f;
    public UnityEngine.UI.Image healthImage;


    private InputAction moveAction;
    private InputAction jumpAction;
    private InputAction sprintAction;
    private InputActionMap map; 
    private Animator animator;

    private Rigidbody rb;
    private bool isGrounded = false;
    
    public static int Coins = 0;
    public static int Health = 10;
    public static int Feathers = 0;

    private void Awake()
    {
        map = input.FindActionMap(actionMapName);
        moveAction = map.FindAction("Move");
        jumpAction = map.FindAction("Jump");
        sprintAction = map.FindAction("Sprint");
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    void OnEnable()
    {
        map.Enable();
    }

    void OnDisable()
    {
        map.Disable();
    }

    void Start()
    {
        
    }

    void Update()
    {

        Vector2 moveInput = moveAction.ReadValue<Vector2>();

         //bepalen wat de snelheid is
        float speed = WalkSpeed * moveInput.y;

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
            animator.SetTrigger("Jump");
        }

        animator.SetFloat("Speed", speed);
        animator.SetBool("Grounded", isGrounded);


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

        healthImage.fillAmount = Health / 10f;

       
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
            isGrounded = true;

        if (collision.gameObject.CompareTag("Enemy"))
        {
            Health -= 2;
            Debug.Log("Player Health: " + Health);
        }
        
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
            isGrounded = false;
    }
}
