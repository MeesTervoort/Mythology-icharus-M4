using UnityEngine;
using TMPro;

public class UIScript : MonoBehaviour
{
     public TextMeshProUGUI healthText;

    public TextMeshProUGUI coinsText;

    void Start()

        {

            healthText = GameObject.FindWithTag("HealthText").GetComponent<TextMeshProUGUI>();

            coinsText = GameObject.FindWithTag("CoinText").GetComponent<TextMeshProUGUI>();

        }

        void Update()

        {

            healthText.text = Player.Health.ToString();

            coinsText.text = Player.Coins.ToString();

        }

}

