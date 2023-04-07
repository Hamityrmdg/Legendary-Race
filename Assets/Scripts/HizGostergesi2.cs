using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HizGostergesi2 : MonoBehaviour
{
    public ArabaKontrol2 AK2;

    private const float minSpeedAci = 190.0f;
    private const float maxSpeedAci = -70.0f;

    private Transform ibreTransform;
    public float speed;
    public float maxSpeed;

    public GameObject ibre;

    private void Awake()
    {
        ibreTransform = ibre.transform;

    }
    private void FixedUpdate()
    {
        speed = AK2.speed;
        maxSpeed = AK2.maxSpeed;

        if (speed > maxSpeed) speed = maxSpeed;

        ibreTransform.eulerAngles = new Vector3(0, 0, GetSpeedRotation());
    }
    private float GetSpeedRotation()
    {
        float toplamDonusAcý = minSpeedAci - maxSpeedAci;
        float speedNormalized = speed / maxSpeed;

        return minSpeedAci - speedNormalized * toplamDonusAcý;
    }
}
