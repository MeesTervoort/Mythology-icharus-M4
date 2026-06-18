using UnityEngine;
using TMPro;

public class CollectScript : MonoBehaviour
{

    public float respawnTime = 3f;
    public TextMeshProUGUI feedbackText;
    public TextMeshProUGUI coinsText;
    public int coinsToGive = 1;

    private void Start()
    {
        coinsText = GameObject.FindWithTag("CoinText").GetComponent<TextMeshProUGUI>();
    }
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collision)
    {
        
        if(collision.gameObject.tag == "Player")
        {
            Player player = collision.gameObject.GetComponent<Player>();
            Player.Coins += coinsToGive;
            coinsText.text = Player.Coins.ToString();
            Destroy(gameObject);
        }
    }
}
