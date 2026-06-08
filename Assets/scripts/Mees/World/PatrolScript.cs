using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class PatrolScript : MonoBehaviour
{

    public Transform[] waypoints;
    private int currentWaypointIndex = 0;
    private float speed = 2f;

    private float waitTime = 1f;
    private float waitTimer = 0f;
    private bool waiting = false;

    private bool playerSpotted = false;
    [SerializeField] Vector3 Player;


    void Update()
    {
        if (playerSpotted == false)
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
