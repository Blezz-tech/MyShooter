using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    public List<Transform> patrolPoints;
    public PlayerController player;

    private NavMeshAgent _navMeshAgent;
    private bool _isPlayerNoticed;

    // Start is called before the first frame update
    void Start()
    {
        InitComponentLinks();
        PickNewPatrolPoint();
    }

    private void InitComponentLinks()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        var direction = player.transform.position - transform.position;

        RaycastHit hit;
        if (Physics.Raycast(transform.position + Vector3.up, direction, out hit))
        {
            if(hit.collider.gameObject == player.gameObject)
            {
                _isPlayerNoticed = true;
            }
            else
            {
                _isPlayerNoticed = false;
            }
        }
        else
        {
            _isPlayerNoticed = false;
        }

        PatrolUpdate();
    }

    private void PatrolUpdate()
    {
        if (_navMeshAgent.remainingDistance == 0)
        {
            PickNewPatrolPoint();
        }
    }

    private void PickNewPatrolPoint()
    {
        _navMeshAgent.destination = patrolPoints[Random.Range(0, patrolPoints.Count)].position;
    }
}
