using UnityEngine;

public class Setting : MonoBehaviour
{
    public GameObject container;
    void Start()
    {
        container.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ResumeButton()
    {
        container.SetActive(false);
        Time.timeScale = 1f;
        Cursor.visible = false;
    }
    
}
