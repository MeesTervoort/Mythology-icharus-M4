using UnityEngine;

public class GateOpen : MonoBehaviour
{
    [SerializeField] private bool ShouldOpen = false;
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

        if (ShouldOpen)
        {
            OpenGate();
        }
    }

    public void OpenGate()
    {
        animator.SetTrigger("Open");
    }
}
