using Unity.VisualScripting;
using UnityEngine;

public class Rat_combat : MonoBehaviour
{
    public static int RatHealth = 4;
    void Start()
    {
        
    }

    void Update()
    {
        if (RatHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
   
}
