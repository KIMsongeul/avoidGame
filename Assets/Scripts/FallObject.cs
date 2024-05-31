using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class FallObject : MonoBehaviour
{
    public GameObject obj;
    
    
    IEnumerator CreateObj()
    {
        while (true)
        {
            createObject();
            yield return new WaitForSeconds(0.2f);
        }
    }

    private void Start()
    {
        StartCoroutine(CreateObj());
    }

    void createObject()
    {
        Vector3 pos = Camera.main.ViewportToWorldPoint //화면 안에서만 생성됨
            (new Vector3(UnityEngine.Random.Range(0.0f, 1.0f), 1.0f, 0));
        pos.z = 0.0f; //오브젝트의 z값이 카메라보다 낮으면 게임창에서 보이지않는 문제 해결
        Instantiate(obj, pos, quaternion.identity);
    }
}
