using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    // Parameter Configurations
    [SerializeField] List<Waypoint> path = new List<Waypoint>();
    [SerializeField] [Min(0)] float speed = 1f;


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
            Vector3 startPos = transform.position;
            Vector3 endPos = waypoint.transform.position;
            float travelPer = 0f;

            transform.LookAt(endPos);

            while (travelPer < 1f)
            {
                travelPer += Time.deltaTime * speed;
                transform.position = Vector3.Lerp(startPos, endPos, travelPer);
                yield return new WaitForEndOfFrame();
            }
        }
    }
}
