using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 5.0f;
    void Start()
    {
        
    }

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveX, 0f, moveY);

        transform.Translate(movement * speed * Time.deltaTime);
    }    
}
