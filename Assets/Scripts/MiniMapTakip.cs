using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniMapTakip : MonoBehaviour
{
    public Transform takipEt2;
    void Start()
    {
        takipEt2 = GameObject.FindWithTag ("Player").transform;
    }

    private void LateUpdate()
    {
        Vector3 yeniPoz2 = takipEt2.position;
        yeniPoz2.y = transform.position.y;
        transform.position = yeniPoz2;

    }

}
