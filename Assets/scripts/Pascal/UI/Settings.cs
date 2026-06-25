using UnityEngine;

public class Setting : MonoBehaviour
{
    
    public GameObject container;
    public GameObject container2;
    void Start()
    {
        container.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EnterButton()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        container.SetActive(true);
        Time.timeScale = 0f;
    }

    public void ExitButton()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        container.SetActive(false);
        container2.SetActive(true);
        Time.timeScale = 1f;
    }
    public void BrightnessButton()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        container.SetActive(false);
        Time.timeScale = 1f;
    }
    public void VolumeButton()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        container.SetActive(false);
        Time.timeScale = 1f;
    }
    
}
