using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GuardTouch : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {
      
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Die();
        }
        
    }


    private void Die()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
    }



}

        
    

