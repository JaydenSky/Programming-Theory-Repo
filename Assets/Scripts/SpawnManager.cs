using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] capsules;

    private float xRange = 14;
    private float zRange = 5;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnCapsule", 2, 2);
    }

    void SpawnCapsule()
    {
        int capsuleIndex = Random.Range(0, capsules.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-xRange, xRange), 0.5f, Random.Range(-zRange, zRange));

        Instantiate(capsules[capsuleIndex], spawnPos, capsules[capsuleIndex].transform.rotation);
    }
}
