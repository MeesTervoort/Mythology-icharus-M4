using UnityEngine;
using UnityEngine.SceneManagement;

public class GuardTouch : MonoBehaviour
{
<<<<<<< HEAD
    void Start()
    {

    }

    void Update()
    {

    }

=======
>>>>>>> Development
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("ya got touched " + Player.Health);
            Player.Health -= 1;
            if (Player.Health <= 0)
            {
                Die();
            }
        }
    }

    public void Die()
    {
<<<<<<< HEAD
        SceneManager.LoadScene("DeathScreen");
=======
        UnityEngine.SceneManagement.SceneManager.LoadScene("DeathScreen");
        //UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
>>>>>>> Development
    }
}

        
    

