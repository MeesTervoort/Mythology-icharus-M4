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
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (Player.Coins > 0)
        {
            container.SetActive(true);
            Time.timeScale = 0f;
        }
    }
     public void SpeedButton()
    {
        Player.Coins -= 1;
        Player.speed += 1f;
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
     public void HealthButton()
    {
        Player.Coins -= 1;
        Player.Health += 2;
        container.SetActive(false);
        Time.timeScale = 1f;
    }
}
