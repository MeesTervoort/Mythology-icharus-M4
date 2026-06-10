using UnityEngine;
using TMPro;

public class UIScript : MonoBehaviour
{
    public TextMeshProUGUI CoinText;
    public TextMeshProUGUI StrengthText;
    public TextMeshProUGUI SpeedText;
    public TextMeshProUGUI JumpText;
    void Start()
    {
        
    }

    void Update()
    {
        CoinText.text = Player.Feathers.ToString();
        StrengthText.text = Player.Strength.ToString();
        SpeedText.text = Player.WalkSpeed.ToString();
        JumpText.text = Player.jumpForce.ToString();
    }
}
