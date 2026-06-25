using UnityEngine;

public class Titlescreen : MonoBehaviour
{
    public GameObject container1;
    public GameObject container2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        container1.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Cutscene");
    }

    public void Settings()
    {
        container1.SetActive(true);
        Time.timeScale = 1f;
    }

    public void back()
    {
        container2.SetActive(true);
        container1.SetActive(false);
        Time.timeScale = 1f;
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
