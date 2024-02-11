using System.Collections;
using UnityEngine;
using UnityEngine.AI;

public class RandomMovement : MonoBehaviour
{
    public NavMeshAgent agent;
    public float range;
    public Transform centrePoint;

    private float waitTime = 2.0f;
    private bool waiting = false;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.speed = 1.0f;  // Set the desired movement speed here
    }

    void Update()
    {
        if (waiting)
        {
            // Decrease the wait time
            waitTime -= Time.deltaTime;

            // Check if the wait time has elapsed
            if (waitTime <= 0)
            {
                waiting = false;
                waitTime = 3.0f;  // Reset wait time for the next iteration
            }
        }
        else if (agent.remainingDistance <= agent.stoppingDistance)
        {
            Vector3 point;
            if (RandomPoint(centrePoint.position, range, out point))
            {
                Debug.DrawRay(point, Vector3.up, Color.blue, 2.0f);
                agent.SetDestination(point);
                waiting = true;  // Set the flag to start waiting
            }
        }
    }

    bool RandomPoint(Vector3 center, float range, out Vector3 result)
    {
        Vector3 randomPoint = center + Random.insideUnitSphere * range;
        NavMeshHit hit;

        if (NavMesh.SamplePosition(randomPoint, out hit, 2.0f, NavMesh.AllAreas))
        {
            result = hit.position;
            return true;
        }

        result = Vector3.zero;
        return false;
    }
}
