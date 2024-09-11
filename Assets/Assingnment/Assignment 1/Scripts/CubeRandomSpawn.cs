using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRandomSpawn : MonoBehaviour
{
    [SerializeField] GameObject cube;

    [SerializeField] private int count;
    [SerializeField] private float floorLength;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < count; i++)
        {
            Instantiate(cube, new Vector3(Random.Range(-floorLength, floorLength), Random.Range(1, floorLength), Random.Range(-floorLength, floorLength)), Quaternion.identity);
        }
    }
}
