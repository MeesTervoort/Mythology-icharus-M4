using UnityEngine;
using UnityEngine.SceneManagement;

public class GuardTouch : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {
        //if (Player.Health => 0)
        //{
        //    Die();
        //}
    }

    private void OnCollisionEnter(Collision collision)
    {
        Player.Health =- 2;
    }

    private void Die()
    {

            UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
    }



}

        
    

