using UnityEngine;

public class ChooseMenu : MonoBehaviour
{
    public GameObject container;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Player.Coins > 0)
        {
            container.SetActive(true);
            Time.timeScale = 0f;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }

     public void SpeedButton()
    {
        Player.Coins -= 1;
        Player.WalkSpeed += 1f;
        container.SetActive(false);
        Time.timeScale = 1f;
    }
     public void JumpButton()
    {
        Player.Coins -= 1;
        Player.jumpForce += 1f;
        container.SetActive(false);
        Time.timeScale = 1f;
    }
     public void StrengthButton()
    {
        Player.Coins -= 1;
        Player.Strength += 2f;
        container.SetActive(false);
        Time.timeScale = 1f;
    }
}
