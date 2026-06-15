using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class PatrolScript : MonoBehaviour
{

<<<<<<< HEAD

    [Header("references")]
    [SerializeField] private Transform Player;
    [SerializeField] private Transform[] waypoints;

    [Header("settings")]
    [SerializeField] private float patrolWaitTime = 2f;
    [SerializeField] private float StopAtDistance = 0.5f;
    [SerializeField] private float detectionRange = 5f;
    [SerializeField] private float viewAngle = 90f;
    [SerializeField] private float losePlayerTime = 3f;

    private NavMeshAgent agent;
    //private Animator animator;
=======
    public Transform[] waypoints;
>>>>>>> parent of b716d37 (Merge branch 'Mees' into Pascal)
    private int currentWaypointIndex = 0;
    private float speed = 2f;

    private float waitTime = 1f;
    private float waitTimer = 0f;
    private bool waiting = false;

    private bool playerSpotted = false;
    [SerializeField] Vector3 Player;


    void Update()
    {
<<<<<<< HEAD
        agent = GetComponent<NavMeshAgent>();
        //animator = GetComponent<Animator>();
    }

    private void Start()
    {
        GoToNextWayPoint();
    }

    private void Update()
    {
        var distanceToPlayer = Vector3.Distance(Player.position, transform.position);

        switch (state)
=======
        if (playerSpotted == false)
>>>>>>> parent of b716d37 (Merge branch 'Mees' into Pascal)
        {
            if (waiting)
            {
                waitTimer += Time.deltaTime;
                if (waitTimer < waitTime)
                    return;
                waiting = false;
            }
            Transform wp = waypoints[currentWaypointIndex];
            if (Vector3.Distance(transform.position, wp.position) < 0.1f)
            {
                transform.position = wp.position;
                waitTimer = 0f;
                waiting = true;

                currentWaypointIndex = (currentWaypointIndex + 1) % waypoints.Length;
            }
            else
            {
                transform.position = Vector3.MoveTowards(transform.position, wp.position, speed * Time.deltaTime);
                transform.LookAt(wp.position);
            }
        }

        
        

<<<<<<< HEAD
    private void UpdateAnimations()
    {
        var isMoving = agent.velocity.sqrMagnitude > 0.01f;
        //animator.SetBool("IsWalking", isMoving);
=======
>>>>>>> parent of b716d37 (Merge branch 'Mees' into Pascal)
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerSpotted = true;
            transform.position = Vector3.MoveTowards(transform.position, Player, speed * Time.deltaTime);
        }

    }
}
