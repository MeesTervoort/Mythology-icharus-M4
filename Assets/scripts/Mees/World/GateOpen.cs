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
        animator.SetInteger("Feathers", Player.Feathers);

    }

    
}
