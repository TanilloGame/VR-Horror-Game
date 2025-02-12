using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Move : MonoBehaviour
{
    [SerializeField] private NavMeshAgent agent;
    [SerializeField] private GameObject target;
    [SerializeField] private List<Transform> targetsList;
    [SerializeField] private int index;
    [SerializeField] private int distanceRemaining;

    private void Start()
    {
        index = 0;
        agent.SetDestination(targetsList[index].position);
    }

    void Update()
    {
        if (agent.remainingDistance < distanceRemaining)
        {
            index = Random.Range(0,targetsList.Count);
            // if (index == targetsList.Count)
            // {
            //     index = 0;
            // }
            agent.SetDestination(targetsList[index].position);
        }
    }
}
