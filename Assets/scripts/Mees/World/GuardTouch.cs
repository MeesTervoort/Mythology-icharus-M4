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
            Debug.Log("ya got touched" + Player.Health);
            Player.Health -= 1;
            if (Player.Health <= 0)
            {
                Die();
            }
        }
    }

    public void Die()
    {
        SceneManager.LoadScene("DeathScreen");
    }
}

        
    

