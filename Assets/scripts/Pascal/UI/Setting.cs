using UnityEngine;

public class Settings : MonoBehaviour
{
    public GameObject container;
    void Start()
    {
        Time.timeScale = 0f;
        container.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ExitButton()
    {
        container.SetActive(false);
        Time.timeScale = 1f;
        Cursor.visible = false;
    }
    public void BrightnessButton()
    {
        container.SetActive(false);
        Time.timeScale = 1f;
        Cursor.visible = false;
    }
    public void VolumeButton()
    {
        container.SetActive(false);
        Time.timeScale = 1f;
        Cursor.visible = false;
    }

}
