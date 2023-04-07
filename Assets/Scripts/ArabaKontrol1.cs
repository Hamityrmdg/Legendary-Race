using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArabaKontrol1 : MonoBehaviour
{
    public WheelCollider onSolCol;
    public WheelCollider onSagCol;
    public WheelCollider arkaSolCol;
    public WheelCollider arkaSagCol;

    public GameObject onSol;
    public GameObject onSag;
    public GameObject arkaSol;
    public GameObject arkaSag;

    public float maxMotorGucu;
    public float maxDonusAcisi;
    public float motor;
    public float frenGuc;

    public float hiz_ayari;
    public bool mars;
    public float speed;
    public float maxSpeed;
    private Rigidbody _rb;



    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        ArabaTeker();
    }
    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.O)) mars = !mars;

        if (mars)
        {
            speed = carSpeed()* hiz_ayari;
            motor = maxMotorGucu * Input.GetAxis("1.V");
            float donus = maxDonusAcisi * Input.GetAxis("1.H");

            float ElfrenTork = frenGuc * Mathf.Abs(Input.GetAxis("Jump2"));


            onSolCol.steerAngle = onSagCol.steerAngle = donus;

            if (ElfrenTork < 0.05)
            {
                arkaSagCol.motorTorque = motor;
                arkaSolCol.motorTorque = motor;
                arkaSagCol.brakeTorque = 0;
                arkaSolCol.brakeTorque = 0;
            }
            else
            {
                arkaSagCol.brakeTorque = ElfrenTork;
                arkaSolCol.brakeTorque = ElfrenTork;
            }

        }





    }
    void ArabaTeker()
    {
        Quaternion rot;
        Vector3 pos;
        onSagCol.GetWorldPose(out pos, out rot);
        onSag.transform.position = pos;
        onSag.transform.rotation = rot;

        onSolCol.GetWorldPose(out pos, out rot);
        onSol.transform.position = pos;
        onSol.transform.rotation = rot;

        arkaSolCol.GetWorldPose(out pos, out rot);
        arkaSol.transform.position = pos;
        arkaSol.transform.rotation = rot;

        arkaSagCol.GetWorldPose(out pos, out rot);
        arkaSag.transform.position = pos;
        arkaSag.transform.rotation = rot;
    }
    public float carSpeed()
    {
        float speed = _rb.velocity.magnitude;
        speed *= 3.6f;
        if (speed > maxSpeed)
            _rb.velocity = (maxSpeed / 3.6f) * _rb.velocity.normalized;

        return speed;

    }

}
