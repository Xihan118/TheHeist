using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public Transform Target;

    void Start()
    {

    }

    
    void Update()
    {
        if (Target == null) {
            Target = GameObject.FindGameObjectWithTag("Player").transform;
        }
        Vector3 targetTransform = new Vector3(Target.position.x, transform.position.y, Target.position.z);
        transform.LookAt(targetTransform);    
    }
}
