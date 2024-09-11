using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject bulletPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (bulletPrefab != null && Input.GetMouseButtonDown(0))
        {
            Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            Bullet bullet = bulletPrefab.GetComponent<Bullet>();
            bullet.fireDirection = new Vector3(
                    -2,
                    Random.Range(-0.2f, 1f),
                    Random.Range(-1f, 1f)
                );
            bullet.fireDirection.Normalize();
            //bullet.Fire();
            
        }
    }
}
