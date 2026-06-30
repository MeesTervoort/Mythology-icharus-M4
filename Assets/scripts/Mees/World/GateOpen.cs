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
        if(Player.Coins <= 3)
        {
            ShouldOpen = true;
        }

        if (ShouldOpen == true)
        {
            OpenGate();
        }
    }

    public void OpenGate()
    {
        animator.SetBool("OpenGate", true);
    }
}
