using UnityEngine;


public class DEATH : MonoBehaviour
{
    public GameObject container;
    void Start()
    {
        container.SetActive(false);
    }

    void Update()
    {
        if (Player.Health <= 0)
        {
            container.SetActive(true);
            Time.timeScale = 0f;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        
    }

    public void RespawnButton()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name); 
    }
}
