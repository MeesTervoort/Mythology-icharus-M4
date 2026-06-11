using UnityEngine;
using TMPro;

public class UIScript : MonoBehaviour
{
    public TextMeshProUGUI CoinText;
    public TextMeshProUGUI HealthText;
    void Start()
    {
        
    }

    void Update()
    {
        CoinText.text = Player.Coins.ToString();
        HealthText.text = Player.Health.ToString();
    }
}
