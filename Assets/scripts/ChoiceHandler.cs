using Unity.VisualScripting;
using UnityEngine;

//public class ChoiceHandler : MonoBehaviour
//{
//    [SerializeField] public static GameObject Choice;
//    private int CurrentEnemies = 0;
//    private bool Ischoosing = false;

//    public GameObject[] enemies;

//    void Start()
//    {
//        Choice.SetActive(false);
//    }

//    void Update()
//    {
//        if (Input.GetKeyDown(KeyCode.Space) && !choosingTarget)
//        {
//            StartTargetSelection();

//            if (choosingTarget)
//            {
//                HandleTargetSelection();
//            }
//        }
//    }
//    // TARGET SELECTION MODE


//void StartTargetSelection()
//{
//    choosingTarget = true;

//    CurrentEnemies = 0;

//    Choice.SetActive(true);

//    MoveArrow();
//}
//void HandleTargetSelection()
//{
//    // MOVE RIGHT
//    if (Input.GetKeyDown(KeyCode.D))
//    {
//        CurrentEnemies++;

//        if (CurrentEnemies >= enemies.Length)
//            CurrentEnemies = 0;

//        MoveArrow();
//    }

//    // MOVE LEFT
//    if (Input.GetKeyDown(KeyCode.A))
//    {
//        CurrentEnemies--;

//        if (CurrentEnemies < 0)
//            CurrentEnemies = enemies.Length - 1;

//        MoveArrow();
//    }

//    // CONFIRM TARGET
//    if (Input.GetKeyDown(KeyCode.Return))
//    {
//        enemies[CurrentEnemies].//insert thingy here;

//        choosingTarget = false;

//        Choice.SetActive(false);
//    }
//}

//void MoveArrow()
//{
//    Vector3 enemyPos = enemies[CurrentEnemies].transform.position;

//    Choice.transform.position =
//        enemyPos + new Vector3(0, 2f, 0);
//}
//}
