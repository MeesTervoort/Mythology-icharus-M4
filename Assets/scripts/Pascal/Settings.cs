using UnityEngine;

public class Settings : MonoBehaviour
{
    public GameObject container;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SettingsButton()
    {
        container.SetActive(true);
        Time.timeScale = 0f;
    }

    public void ExitButton()
    {
        container.SetActive(false);
        Time.timeScale = 1f; 
    }
}
