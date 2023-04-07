using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniMapTakip2 : MonoBehaviour
{
    public Transform takipEt;
    void Start()
    {
        takipEt = GameObject.FindWithTag ("Player2").transform;
    }

    private void LateUpdate()
    {
        Vector3 yeniPoz = takipEt.position;
        yeniPoz.y = transform.position.y;
        transform.position = yeniPoz;

    }

}
