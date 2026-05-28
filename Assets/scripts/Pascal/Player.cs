using UnityEngine;


public class Player : MonoBehaviour
{
    public static float speed = 5f;
    public static float jumpForce = 5f;
    public static int Coins = 0;
    public static int Health = 10;

    private Rigidbody rb;
    private bool isGrounded;
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    void Update()
    {
        
        
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");


        Vector3 movement = new Vector3(moveX, 0f, moveY);

        transform.Translate(movement * speed * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
            {
                rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
                isGrounded = false;
            }
    }

            void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.CompareTag("Ground"))
            {
                isGrounded = true;
            } 
        }
}
