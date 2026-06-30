using UnityEngine;

public class GateOpen : MonoBehaviour
{
    public bool ShouldOpen = false;
    Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if(Player.Coins >= 3)
        {
            animator.SetInteger("Feathers", 3);
        }

        
    }

    public void OpenGate()
    {
        
    }
}
