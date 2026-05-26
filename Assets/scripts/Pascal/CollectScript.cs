using UnityEngine;
using TMPro;

public class CollectScript : MonoBehaviour
{

    public float respawnTime = 3f;
    
    public int coinsToGive = 1;

    

    void OnTriggerEnter(Collider collision)
    {
        
        if(collision.gameObject.tag == "Player")
        {
            Player player = collision.gameObject.GetComponent<Player>();
            Player.Coins += coinsToGive;
            Destroy(gameObject);
        }
    }
}
