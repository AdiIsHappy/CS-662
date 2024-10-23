using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A1CubeController : MonoBehaviour
{
    public float movementForce;
    public float rotationTorque;
    public float jumpForce;
    private Rigidbody _rb;
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        _rb.AddForce(transform.forward * (Input.GetAxis("Vertical") * movementForce * Time.deltaTime * 100));
        _rb.AddTorque(Vector3.up * (Input.GetAxis("Horizontal") * rotationTorque * Time.deltaTime * 100));
        if (Input.GetButtonDown("Jump") && _rb.linearVelocity.y == 0)
        {
            _rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}
