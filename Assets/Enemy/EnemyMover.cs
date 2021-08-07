using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    // Parameter Configurations
    [SerializeField] List<Waypoint> path = new List<Waypoint>();


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
            Debug.Log(waypoint.name);
            yield return new WaitForSeconds(1f);
        }
    }
}
