using UnityEngine;
using TMPro;

public class CollectScript : MonoBehaviour
{

    public float respawnTime = 3f;
    public TextMeshProUGUI feedbackText;
    public TextMeshProUGUI feathersText;
    public int FeathersToGive = 1;
    public int coinsToGive = 1;

    private void Start()
    {
        feathersText = GameObject.FindWithTag("FeatherText").GetComponent<TextMeshProUGUI>();
    }
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collision)
    {
        
        if(collision.gameObject.tag == "Player")
        {
            Player player = collision.gameObject.GetComponent<Player>();
            Player.Feathers += FeathersToGive;
            Player.Coins += coinsToGive;
            feathersText.text = Player.Feathers.ToString();
            Destroy(gameObject);
        }
    }
}
