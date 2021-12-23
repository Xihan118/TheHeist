using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickToTarget : MonoBehaviour
{
    public float offset;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        Transform Target = GameObject.FindGameObjectWithTag("Player").transform;
        Vector3 TargetPosition = new Vector3(Target.position.x + offset, transform.position.y, Target.position.z);
        transform.position = TargetPosition;
    }
}
