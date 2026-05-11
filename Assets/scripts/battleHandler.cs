using UnityEngine;

public class battleHandler : MonoBehaviour
{
    [SerializeField] public Transform character;
    [SerializeField] public Transform enemy;
    [SerializeField] public Transform Rat;

    void Start()
    {
        SpawnPlayer();
        SpawnEnemy(true);
        SpawnEnemy(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

        }
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
    
}
