using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField]private InputActionAsset inputAsset;
    [SerializeField]private string actionMapName = "Player";
    [SerializeField] public static float WalkSpeed = 5f;
    [SerializeField] private float rotationSpeed = 150f;
    [SerializeField] public static float jumpForce = 5f;
    [SerializeField] public float gravity = -20f;


    private InputAction moveAction;
    private InputAction jumpAction;
    private InputAction sprintAction;

    private CharacterController characterController;
    private Animator animator;
    private InputActionMap map; 
    private float verticalVelocity;

    public Image healthBar;
    public static int Feathers = 0;
    public static int Coins = 0;
    public static int Health = 10;
    public static int Strength = 5;

    private void Awake()
    {
        characterController = GetComponent<CharacterController>();
        animator = GetComponentInChildren<Animator>();

        map = inputAsset.FindActionMap(actionMapName);
        moveAction = map.FindAction("Move");
        jumpAction = map.FindAction("Jump");
        sprintAction = map.FindAction("Sprint");
        //rb = GetComponent<Rigidbody>();
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

        Vector2 movementInput = moveAction.ReadValue<Vector2>();

         //bepalen wat de snelheid is
        float speed =  movementInput.y * WalkSpeed;

        //sprinten
        if (sprintAction.IsPressed())
            speed *= 2f;

        //bewegen van de speler
        Vector3 move = transform.forward * speed * Time.deltaTime;

        //draaien van de speler
         transform.Rotate(Vector3.up * movementInput.x * rotationSpeed * Time.deltaTime);

        
        // Springen Zwaartekracht toepassen
        if (characterController.isGrounded)
        {
            verticalVelocity = -10f; // kleine downward force om grounded te blijven

            if (jumpAction.WasPressedThisFrame())
            {
                // Sprong-formule: v = sqrt(2 * |g| * h)
                verticalVelocity = Mathf.Sqrt(2f * Mathf.Abs(gravity) * jumpForce);
                animator.SetTrigger("Jumptrigger");
                Debug.Log("Jump!");
            }
        }
        else
        {
            // Niet op de grond: zwaartekracht toepassen
            verticalVelocity += gravity * Time.deltaTime;
        }

        move.y = verticalVelocity * Time.deltaTime;

        healthBar.fillAmount = Health / 10f;

        characterController.Move(move);

        animator.SetFloat("speed", speed);
        animator.SetBool("IsGrounded", characterController.isGrounded);
    }

}
