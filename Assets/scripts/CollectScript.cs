using UnityEngine;
using TMPro;

public class CollectScript : MonoBehaviour
{

    public float respawnTime = 3f;
    public TextMeshProUGUI feedbackText;
    public TextMeshProUGUI coinsText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
        
            gameObject.SetActive(false);
            // we willen de coin even onzichtbaar maken
            Invoke(nameof(Respawn), 3f);
        }
    }

    void Respawn()
    {
        // We maken het gameobject weer zichtbaar
        gameObject.SetActive(true);
    }
}
