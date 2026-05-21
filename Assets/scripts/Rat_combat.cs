using Unity.VisualScripting;
using UnityEngine;

public class Rat_combat : MonoBehaviour
{
    public static int EnemyHealth = 4;
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
