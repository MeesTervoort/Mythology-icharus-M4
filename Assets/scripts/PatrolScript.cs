using UnityEngine;

public class PatrolScript : MonoBehaviour
{
    public Transform[] waypoints;
    public int currentWaypointIndex = 0;
    private float speed = 2f;

    private float waitTime = 2f;
    private float waitCounter = 0f;
    private bool isWaiting = false;
    void Start()
    {
        
    }

    void Update()
    {
        Transform wp = waypoints[currentWaypointIndex];
        if (Vector3.Distance(transform.position, wp.position) < 0.1f)
        {
            currentWaypointIndex = (currentWaypointIndex + 1) % waypoints.Length;
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, wp.position, speed * Time.deltaTime);
        }



        if (isWaiting)
        {
            waitCounter += Time.deltaTime;
            if (waitCounter >= waitTime)
                return;
            isWaiting = false;


        }
    }
}
