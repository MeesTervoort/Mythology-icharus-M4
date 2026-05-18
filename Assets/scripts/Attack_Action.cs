using UnityEngine;

public class Attack_Action : MonoBehaviour
{
    public GameObject PointA;
    public GameObject PointB;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void ChoiceArrow()
    {
        Vector3 position = new Vector3(3, 3f, 0);
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
            if (battleHandler.Choice_arrow.transform.position == PointA.transform.position)
            {
                
            }
            else if (battleHandler.Choice_arrow.transform.position == PointB.transform.position)
            {
                
            }
        }
    }
}
