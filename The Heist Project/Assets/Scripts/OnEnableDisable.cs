using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnEnableDisable : MonoBehaviour
{

    void Start()
    {

    }


    void Update()
    {

    }

    private void OnEnable()
    {
        StartCoroutine("disableObj");
    }

    IEnumerator disableObj() {
        yield return new WaitForSeconds(0.1f);
        gameObject.SetActive(false);
    }

}
