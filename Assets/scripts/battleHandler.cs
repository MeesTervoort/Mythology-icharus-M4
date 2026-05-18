using Unity.VisualScripting;
using UnityEngine;

public class battleHandler : MonoBehaviour
{
    [SerializeField] public static GameObject Choice_arrow;
    [SerializeField] public Transform character;
    [SerializeField] public Transform enemy;
    [SerializeField] public Transform Rat;
    public GameObject WinUI;

    void Start()
    {
        SpawnPlayer();
        SpawnEnemy(true);
        SpawnEnemy(false);
    }

    void Update()
    {
        Wincondition();

        if (Player_combat.CombatHealth <= 0)
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
            Rat_combat.EnemyHealth--;
            Debug.Log("Rat health: " + Rat_combat.EnemyHealth);
        }
    }

    private void SpawnEnemy(bool isRat)
    {
        Vector3 position;
        if (isRat)
        {
            position = new Vector3(7, 1, 0);
            Instantiate(Rat, position, Quaternion.identity);
        }
        else
        {
            position = new Vector3(3, 2, 0);
            Instantiate(enemy, position, Quaternion.identity);
        }
    }
    private void SpawnPlayer()
    {
        Vector3 position = new Vector3(-5, 2, 0);
        Instantiate(character, position, Quaternion.identity);
     }
    private void Wincondition()
    {
        if (Enemy_combat.EnemyHealth <= 0 && Rat_combat.EnemyHealth <= 0)
        {
            WinUI.SetActive(true);
        }
    }
}
