using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float fireForce = 100f;
    public Vector3 fireDirection;
    public GameObject explosionPrefab;
    public string wallTag = "Wall";
    private Rigidbody _rb;
    
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _rb.AddForce(fireDirection * fireForce, ForceMode.Acceleration);
    }
    



    public void OnCollisionEnter(Collision other)
    {
        if (!other.gameObject.CompareTag(wallTag)) return;
        Instantiate(explosionPrefab, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
