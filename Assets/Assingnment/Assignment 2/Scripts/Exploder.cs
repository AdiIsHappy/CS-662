using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exploder : MonoBehaviour
{
    public List<GameObject> explosionParticles;
    public float particleLifeSpan = 3f;
    public int spawnCount = 10;
    // Start is called before the first frame update
    private void Start()
    {
        for (int i = 0; i < spawnCount; i++)
        {
            int randomIndex = Random.Range(0, explosionParticles.Count);
            GameObject particle = Instantiate(explosionParticles[randomIndex], transform.position, Quaternion.identity);
            LifeSpan ls = particle.AddComponent<LifeSpan>();
            ls.randomiseLifeSpan=true;
            ls.lifeSpan = particleLifeSpan;
            Rigidbody rb = particle.AddComponent<Rigidbody>();
            rb.AddExplosionForce(100, transform.position, 2);
        }
        Destroy(gameObject);
    }
    
}
