using UnityEngine;

public class CharacterBattle : MonoBehaviour
{
    public void Setup(bool isPlayerTeam)
    {
        if (isPlayerTeam)
        {
            transform.position = new Vector3(-2, 1, 0);
        }
        else
        {
            transform.position = new Vector3(2, 1, 0);
        }
    }

    public Vector3 GetPosition()
    {
        return transform.position;
    }

    public void Attack(CharacterBattle targetCharacterBattle)
    {
        Vector3 attackdir = (targetCharacterBattle.GetPosition() - GetPosition()).normalized;
        Debug.Log("Attack");
    }
}
