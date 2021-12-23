using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoolDown : MonoBehaviour
{
    public EnemyController controller;
    public float shootTime;
    public float shootTimeDelay;

    void Start()
    {
        StartCoroutine("ShootTime");
    }

    void Update()
    {
        
    }

    public IEnumerator ShootTime() {
        yield return new WaitForSeconds(shootTime);
        controller.enabled = false;
        yield return new WaitForSeconds(shootTimeDelay);
        controller.enabled = true;
        StartCoroutine("ShootTime");
    }
}
