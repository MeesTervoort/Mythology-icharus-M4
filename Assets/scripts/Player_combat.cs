using UnityEngine;

public class Player_combat : MonoBehaviour
{
    public int CombatHealth;
    public int CombatEnergy;
    void Start()
    {
        CombatHealth = 10;
        CombatEnergy = 5;
        //CombatHealth = Health;
        //CombatEnergy = Energy;
    }

    void Update()
    {
        if (CombatHealth <= 0)
        {
            Debug.Log("Player is dead");
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            Enemy_combat.EnemyHealth--;
            Debug.Log("Enemy health: " + Enemy_combat.EnemyHealth);
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            Rat_combat.RatHealth--;
            Debug.Log("Rat health: " + Rat_combat.RatHealth);
        }
    }
}
