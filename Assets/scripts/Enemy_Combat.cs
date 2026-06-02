using UnityEngine;

public class Enemy_combat : MonoBehaviour
{
    public static int EnemyHealth = 7;
    void Start()
    {
        
    }

    void Update()
    {
        if (EnemyHealth <= 0)
        {
            Destroy(gameObject);
        }   
    }
}
