using UnityEngine;
using TMPro;

public class UIScript : MonoBehaviour
{
    public TextMeshProUGUI SpeedText;
    public TextMeshProUGUI JumpText;
    public TextMeshProUGUI StrengthText;
    void Start()
    {
        
    }

    void Update()
    {
        SpeedText.text = Player.WalkSpeed.ToString();
        JumpText.text = Player.jumpForce.ToString();
        StrengthText.text = Player.Strength.ToString();
    }
}
