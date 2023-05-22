using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float thrust;
    [SerializeField] float torque;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        ProcessRotation();
        ProcessThrust();
    }
    private void ProcessThrust()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddRelativeForce(0, thrust * Time.deltaTime, 0);
        }
    }

    private void ProcessRotation()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            ApplyRotation(torque);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            ApplyRotation(-torque);
        }
    }
    private void ApplyRotation(float relativeTorque)
    {
        rb.AddRelativeTorque(0, 0, relativeTorque * Time.deltaTime);
    }
}
