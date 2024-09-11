using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeSpan : MonoBehaviour
{
    public float lifeSpan = 3f;
    public bool randomiseLifeSpan = true;


    private void Start()
    {
        if (randomiseLifeSpan)
        {
            lifeSpan = UnityEngine.Random.Range(lifeSpan/2, lifeSpan * 2);
        }
    }

    // Update is called once per frame
    void Update()
    {
        lifeSpan -= Time.deltaTime;
        if (lifeSpan <= 0)
        {
            Destroy(gameObject);
        }
    }
}
