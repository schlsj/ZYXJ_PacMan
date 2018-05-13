using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MonsterAI : MonoBehaviour
{
    public GameObject WayPointParent;
    private Transform[] arrWayPoint;

	// Use this for initialization
	void Start ()
	{
	    arrWayPoint = WayPointParent.GetComponentsInChildren<Transform>();
	    StartCoroutine(Patrol(0.6f));
	}
	

    IEnumerator Patrol(float segment)
    {
        while (enabled)
        {
            if (GetComponent<NavMeshAgent>().velocity.sqrMagnitude < 0.1f)
            {
                UpdateTarget();
            }
            yield return new WaitForSeconds(Random.Range(segment - segment / 2, segment + segment / 2));
        }
        
    }

    void UpdateTarget()
    {
        int index = Random.Range(0, arrWayPoint.Length);
        GetComponent<NavMeshAgent>().SetDestination(arrWayPoint[index].position);
    }
}
