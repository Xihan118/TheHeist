using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnemyController : MonoBehaviour
{
    public Transform Target;
    public bool TriggerDetection;
    public Animator anim;
    public float orientationOffset;

    public UnityEvent OnIdle;
    public UnityEvent OnDetected;

    public float rotationSpeed;

    void Start()
    {

    }

    
    void Update()
    {
        if (TriggerDetection)
        {
            OnDetected.Invoke();
            anim.SetBool("Triggered", true);
        }
        else {
            OnIdle.Invoke();
        }
    }
}

