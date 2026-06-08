using UnityEngine;

public class ThirdPersonCam : MonoBehaviour
{
 
    public Transform Orientation;
    public Transform Player;
    public Transform PlayerObj;
    public Rigidbody rb;
 
    public float RotationSpeed;
 
    private void Start()
    {
        
    }
 
    void Update()
    {
        Vector3 viewdir = Player.position - new Vector3(transform.position.x, Player.position.y, transform.position.z);
        Orientation.forward = viewdir.normalized;
 
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 inputDir = Orientation.forward * verticalInput + Orientation.right * horizontalInput;
 
        if (inputDir != Vector3.zero)
            PlayerObj.forward = Vector3.Slerp(PlayerObj.forward, inputDir.normalized, Time.deltaTime * RotationSpeed);
    }

}
 