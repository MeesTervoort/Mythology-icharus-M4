using UnityEngine;

public class battleHandler : MonoBehaviour
{

    [SerializeField] public Transform character;
    [SerializeField] public Transform enemy;

    void Start()
    {
        Instantiate(character, new Vector3(-2, 1, 0), Quaternion.identity);
        Instantiate(character, new Vector3(2, 1, 0), Quaternion.identity);
    }

    void Update()
    {
        
    }
}
