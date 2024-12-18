using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public GameObject Monster;
    public GameObject Target;
    public float Speed;

    public Transform TargetRotation;

    void Start()
    {
        
    }

   
    void Update()
    {
        Target.transform.position = Vector3.MoveTowards(Target.transform.position, Monster.transform.position, Speed);

        transform.LookAt(TargetRotation);
    }
}
