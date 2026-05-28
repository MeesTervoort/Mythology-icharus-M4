using UnityEngine;

public class PaseMenu : MonoBehaviour
{
   public GameObject container;
        void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            container.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    public void ResumeButton()
    {
        container.SetActive(false);
        Time.timeScale = 1f;
    }

    public void MainMenuButton()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1f; 
    }
}
