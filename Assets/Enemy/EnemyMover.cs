using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    // Parameter Configurations
    [SerializeField] List<Waypoint> path = new List<Waypoint>();
    [SerializeField] float waitInSeconds = 1f;


    // Cached References

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(PrintWaypointName());

    }

    IEnumerator PrintWaypointName()
    {
        foreach (Waypoint waypoint in path)
        {
            transform.position = waypoint.transform.position;
            yield return new WaitForSeconds(waitInSeconds);
        }
    }
}
