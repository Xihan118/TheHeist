using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDetection : MonoBehaviour
{
    public EnemyController []EnemyControllers;
    public float detectionTime = 1;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") {
            StartCoroutine("DetectNow");
        }
    }

    public IEnumerator DetectNow() {
        yield return new WaitForSeconds(detectionTime);
        foreach (EnemyController enemyController in EnemyControllers)
        {
            enemyController.TriggerDetection = true;
        }

    }
}
