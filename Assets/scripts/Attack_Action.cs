using UnityEngine;

public class Attack_Action : MonoBehaviour
{
    public GameObject PointA;
    public GameObject PointB;
    void Start()
    {
        ChoiceArrow(PointA);
    }

    void Update()
    {
        MoveArrow();
        Select();
    }

    private void ChoiceArrow(GameObject point)
    {
        Vector3 position = new Vector3(0, +2, 0);
        Instantiate(battleHandler.Choice_arrow, position, Quaternion.identity);
        MoveArrow();
        Select();

    }
    private void MoveArrow()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            battleHandler.Choice_arrow.transform.position = PointA.transform.position;
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            battleHandler.Choice_arrow.transform.position = PointB.transform.position;
        }
    }
    private void Select()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Destroy(battleHandler.Choice_arrow);
            battleHandler.AbilityUi.SetActive(false);
            if (battleHandler.Choice_arrow.transform.position == PointA.transform.position)
            {
                Enemy_combat.EnemyHealth -= 2;
                Debug.Log("Enemy Health: " + Enemy_combat.EnemyHealth);
            }
            else if (battleHandler.Choice_arrow.transform.position == PointB.transform.position)
            {
                Rat_combat.EnemyHealth -= 2;
                Debug.Log("Enemy Health: " + Rat_combat.EnemyHealth);
            }
        }
    }
}
