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
        PrintWaypointName();
    }

    void PrintWaypointName()
    {
        foreach (Waypoint waypoint in path)
        {
            Debug.Log(waypoint.name);

        }
    }
}
