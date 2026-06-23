using UnityEngine;

public class Titlescreen : MonoBehaviour
{
    public GameObject container1;
    public GameObject container2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Main");
    }
    public void settings()
    {
        container1.SetActive(true);
        container2.SetActive(false);
        Time.timeScale = 1f;
    }
    public void back()
    {
        container1.SetActive(false);
        container2.SetActive(true);
        Time.timeScale = 1f;
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
