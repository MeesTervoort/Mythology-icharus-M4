using JetBrains.Annotations;
using Unity.Multiplayer.Center.Common;
using UnityEngine;
using UnityEngine.TextCore.Text;
using UnityEngine.UIElements;

public class Player_combat : MonoBehaviour
{
    public GameObject AbilityUi;
    public GameObject ItemUi;

    public static int CombatHealth;
    public static int CombatEnergy;
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
            Rat_combat.EnemyHealth -= 2;
            Debug.Log("Rat health: " + Rat_combat.EnemyHealth);
        }
    }

    
    
    private void Attack_action()
    {
        Enemy_combat.EnemyHealth -= 2;
        Rat_combat.EnemyHealth -= 2;
    }
    private void Ability_Action()
    {
        AbilityUi.SetActive(true);
    }
    private void Item_Action()
    {
        ItemUi.SetActive(true);
    }
    
    
}
