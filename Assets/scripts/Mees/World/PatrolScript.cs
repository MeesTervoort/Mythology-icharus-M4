using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.AI;
using Unity.VisualScripting;

public enum EnemyState
{
    Patrolling,
    Following
}

public class PatrolScript : MonoBehaviour
{
    private static readonly int IsWalking = Animator.StringToHash("IsWalking");


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
    private Animator animator;
    private int currentWaypointIndex = 0;
    private bool waiting = false;
    private EnemyState state = EnemyState.Patrolling;
    private float timeSinceLostPlayer;

    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
    }

    private void Start()
    {
        GoToNextWayPoint();
    }

    private void Update()
    {
        var distanceToPlayer = Vector3.Distance(Player.position, transform.position);

        switch (state)
        {
            case EnemyState.Patrolling:
                Patrol();
                if (distanceToPlayer <= detectionRange && CanSeePlayer())
                {
                    state = EnemyState.Following;
                }
                break;

            case EnemyState.Following:
                FollowPlayer();
                if (!CanSeePlayer())
                {
                    timeSinceLostPlayer += Time.deltaTime;
                    if(timeSinceLostPlayer >= losePlayerTime)
                    {
                        state = EnemyState.Patrolling;
                        GotoClosestPatrolPoint();
                    }
                }
                else
                {
                    timeSinceLostPlayer = 0f;
                }

                break;
        }


        Patrol();
        UpdateAnimations();


    }

    private void FollowPlayer()
    {
        agent.SetDestination(Player.position);

    }



    private void Patrol()
    {
        if (waiting) return;
        if (!agent.pathPending && agent.remainingDistance <= StopAtDistance)
        {
            StartCoroutine(WaitAtWayPoint());
        }
    }

    private IEnumerator WaitAtWayPoint()
    {
        waiting = true;
        agent.isStopped = true;

        yield return new WaitForSeconds(patrolWaitTime);

        agent.isStopped = false;
        GoToNextWayPoint();
        waiting = false;
    }

    private void GoToNextWayPoint()
    {
        if (waypoints.Length == 0) return;

        agent.SetDestination(waypoints[currentWaypointIndex].position);
        currentWaypointIndex = (currentWaypointIndex + 1) % waypoints.Length;
    }

    private void GotoClosestPatrolPoint()
    {
        if (waypoints.Length == 0) return;
        var closestIndex = 0;
        var closestDistance = float.MaxValue;

        for (var i = 0; i < waypoints.Length; i++)
        {
            var distance = Vector3.Distance(transform.position, waypoints[i].position);
            if (distance < closestDistance)
            {
                closestDistance = distance;
                closestIndex = i;
            }
        }

        currentWaypointIndex = closestIndex;
        agent.SetDestination(waypoints[currentWaypointIndex].position);
    }

    private void UpdateAnimations()
    {
        var isMoving = agent.velocity.sqrMagnitude > 0.01f;
        animator.SetBool("IsWalking", isMoving);
    }

    private bool CanSeePlayer()
    {
        return IsFacingPlayer() && HasClearPathToPlayer();
    }

    private bool IsFacingPlayer()
    {
        Vector3 dirToPlayer = (Player.position - transform.position).normalized;
        return Vector3.Angle(transform.forward, dirToPlayer) < viewAngle / 2f;
    }

    private bool HasClearPathToPlayer()
    {
        var dirToPlayer = (Player.position - transform.position);
        if (Physics.Raycast(transform.position, dirToPlayer.normalized, out RaycastHit hit, dirToPlayer.magnitude))
        {
            return hit.transform == Player;
        }
        return true;
    }
}

       









    //public Transform[] waypoints;
    //private int currentWaypointIndex = 0;
    //private float speed = 2f;

//private float waitTime = 1f;
//private float waitTimer = 0f;
//private bool waiting = false;

//private bool playerSpotted = false;
//[SerializeField] public Transform Player;


//void Update()
//{
//    if (playerSpotted == false)
//    {
//        if (waiting)
//        {
//            waitTimer += Time.deltaTime;
//            if (waitTimer < waitTime)
//                return;
//            waiting = false;
//        }
//        Transform wp = waypoints[currentWaypointIndex];
//        if (Vector3.Distance(transform.position, wp.position) < 0.1f)
//        {
//            transform.position = wp.position;
//            waitTimer = 0f;
//            waiting = true;

//            currentWaypointIndex = (currentWaypointIndex + 1) % waypoints.Length;
//        }
//        else
//        {
//            transform.position = Vector3.MoveTowards(transform.position, wp.position, speed * Time.deltaTime);
//            transform.LookAt(wp.position);
//        }

//        if (CompareTag("Player"))
//        {
//            playerSpotted = true;
//            if (Player != null)
//            {
//                Vector3 direction = (Player.position - transform.position).normalized;
//                transform.position += direction * speed * Time.deltaTime;
//            }
//        }
//    }




//}