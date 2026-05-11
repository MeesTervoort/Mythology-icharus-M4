using Unity.VisualScripting;
using UnityEngine;

public class battleHandler : MonoBehaviour
{
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
    }

    private void SpawnEnemy(bool isRat)
    {
        Vector3 position;
        if (isRat)
        {
            position = new Vector3(7.5f, 0.5f, 0);
            Instantiate(Rat, position, Quaternion.identity);
        }
        else
        {
            position = new Vector3(4, 2, 0);
            Instantiate(enemy, position, Quaternion.identity);
        }
    }
    private void SpawnPlayer()
    {
        Vector3 position = new Vector3(-4, 2, 0);
        Instantiate(character, position, Quaternion.identity);
     }
    private void Wincondition()
    {
        if (Enemy_combat.EnemyHealth <= 0 && Rat_combat.RatHealth <= 0)
        {
            WinUI.SetActive(true);
        }
    }
}
