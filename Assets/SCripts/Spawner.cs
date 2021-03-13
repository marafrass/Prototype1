using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject spawnVFX;

    [Header("Spawn")]
    public GameObject Enemy1Spawn1;

    public float Enemy1Spawn1Quant;

    public GameObject Enemy2Spawn1;

    public float Enemy2Spawn1Quant;

    public GameObject Enemy3Spawn1;

    public float Enemy3Spawn1Quant;

    [Header("SPAWN 2")]
    public GameObject Enemy1Spawn2;

    public float Enemy1Spawn2Quant;

    public GameObject Enemy2Spawn2;

    public float Enemy2Spawn2Quant;

    public GameObject Enemy3Spawn2;

    public float Enemy3Spawn2Quant;

    [Header("SPAWN 3")]
    public GameObject Enemy1Spawn3;

    public float Enemy1Spawn3Quant;

    public GameObject Enemy2Spawn3;

    public float Enemy2Spawn3Quant;

    public GameObject Enemy3Spawn3;

    public float Enemy3Spawn3Quant;

    [Header("SPAWN 4")]
    public GameObject Enemy1Spawn4;

    public float Enemy1Spawn4Quant;

    public GameObject Enemy2Spawn4;

    public float Enemy2Spawn4Quant;

    public GameObject Enemy3Spawn4;
  
    public float Enemy3Spawn4Quant;


    [Header("Spawn Locations (SpawnLoc1 must be assigned)")]
    public Transform SpawnLoc1;
    public Transform SpawnLoc2;
    public Transform SpawnLoc3;
    public Transform SpawnLoc4;

    public GameObject thisTrigger;

    private bool hasSpawned;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {

        ////////////////////////////////////////////////////////////////////////////
        // For spawnLoc1
        for (int i = 0; i < Enemy1Spawn1Quant; i++)
            {
            Vector3 origin = SpawnLoc1.transform.position;
            Vector3 range = transform.localScale / 3f;
            Vector3 randomRange = new Vector3(Random.Range(-range.x, range.x),
                                              -origin.y,
                                              Random.Range(-range.z, range.z));
            Vector3 randomCoordinate = origin + randomRange;

            Instantiate(Enemy1Spawn1, SpawnLoc1.transform.position, SpawnLoc1.transform.rotation);
                Instantiate(spawnVFX, SpawnLoc1.transform.position, SpawnLoc1.transform.rotation);
            }

            for (int i = 0; i < Enemy2Spawn1Quant; i++)
            {
            Vector3 origin = SpawnLoc1.transform.position;
            Vector3 range = transform.localScale / 3f;
            Vector3 randomRange = new Vector3(Random.Range(-range.x, range.x),
                                              -origin.y,
                                              Random.Range(-range.z, range.z));
            Vector3 randomCoordinate = origin + randomRange;

            Instantiate(Enemy2Spawn1, SpawnLoc1.transform.position, SpawnLoc1.transform.rotation);
                Instantiate(spawnVFX, SpawnLoc1.transform.position, SpawnLoc1.transform.rotation);
            }

        for (int i = 0; i < Enemy3Spawn1Quant; i++)
        {
            Vector3 origin = SpawnLoc1.transform.position;
            Vector3 range = transform.localScale / 3f;
            Vector3 randomRange = new Vector3(Random.Range(-range.x, range.x),
                                              -origin.y,
                                              Random.Range(-range.z, range.z));
            Vector3 randomCoordinate = origin + randomRange;

            Instantiate(Enemy3Spawn1, SpawnLoc1.transform.position, SpawnLoc1.transform.rotation);
            Instantiate(spawnVFX, SpawnLoc1.transform.position, SpawnLoc1.transform.rotation);
        }

        ////////////////////////////////////////////////////////////////////////////
        // For spawnLoc2
        if (SpawnLoc2 != null)
        {
            for (int i = 0; i < Enemy1Spawn2Quant; i++)
            {
                Vector3 origin = SpawnLoc2.transform.position;
                Vector3 range = transform.localScale / 3f;
                Vector3 randomRange = new Vector3(Random.Range(-range.x, range.x),
                                                  -origin.y,
                                                  Random.Range(-range.z, range.z));
                Vector3 randomCoordinate = origin + randomRange;

                Instantiate(Enemy1Spawn2, SpawnLoc2.transform.position, SpawnLoc2.transform.rotation);
                Instantiate(spawnVFX, SpawnLoc2.transform.position, SpawnLoc2.transform.rotation);
            }

            for (int i = 0; i < Enemy2Spawn2Quant; i++)
            {
                Vector3 origin = SpawnLoc2.transform.position;
                Vector3 range = transform.localScale / 3f;
                Vector3 randomRange = new Vector3(Random.Range(-range.x, range.x),
                                                  -origin.y,
                                                  Random.Range(-range.z, range.z));
                Vector3 randomCoordinate = origin + randomRange;

                Instantiate(Enemy2Spawn2, SpawnLoc2.transform.position, SpawnLoc2.transform.rotation);
                Instantiate(spawnVFX, SpawnLoc2.transform.position, SpawnLoc2.transform.rotation);
            }

            for (int i = 0; i < Enemy3Spawn2Quant; i++)
            {
                Vector3 origin = SpawnLoc2.transform.position;
                Vector3 range = transform.localScale / 3f;
                Vector3 randomRange = new Vector3(Random.Range(-range.x, range.x),
                                                  -origin.y,
                                                  Random.Range(-range.z, range.z));
                Vector3 randomCoordinate = origin + randomRange;

                Instantiate(Enemy3Spawn2, SpawnLoc2.transform.position, SpawnLoc2.transform.rotation);
                Instantiate(spawnVFX, SpawnLoc3.transform.position, SpawnLoc2.transform.rotation);
            }
        }

        ////////////////////////////////////////////////////////////////////////////
        // For spawnLoc3
        if (SpawnLoc3 != null)
        {
            for (int i = 0; i < Enemy1Spawn3Quant; i++)
            {
                Vector3 origin = SpawnLoc3.transform.position;
                Vector3 range = transform.localScale / 3f;
                Vector3 randomRange = new Vector3(Random.Range(-range.x, range.x),
                                                  -origin.y,
                                                  Random.Range(-range.z, range.z));
                Vector3 randomCoordinate = origin + randomRange;

                Instantiate(Enemy1Spawn3, SpawnLoc3.transform.position, SpawnLoc3.transform.rotation);
                Instantiate(spawnVFX, SpawnLoc3.transform.position, SpawnLoc3.transform.rotation);
            }

            for (int i = 0; i < Enemy2Spawn3Quant; i++)
            {
                Vector3 origin = SpawnLoc3.transform.position;
                Vector3 range = transform.localScale / 3f;
                Vector3 randomRange = new Vector3(Random.Range(-range.x, range.x),
                                                  -origin.y,
                                                  Random.Range(-range.z, range.z));
                Vector3 randomCoordinate = origin + randomRange;

                Instantiate(Enemy2Spawn3, SpawnLoc3.transform.position, SpawnLoc3.transform.rotation);
                Instantiate(spawnVFX, SpawnLoc3.transform.position, SpawnLoc3.transform.rotation);
            }

            for (int i = 0; i < Enemy3Spawn3Quant; i++)
            {
                Vector3 origin = SpawnLoc3.transform.position;
                Vector3 range = transform.localScale / 3f;
                Vector3 randomRange = new Vector3(Random.Range(-range.x, range.x),
                                                  -origin.y,
                                                  Random.Range(-range.z, range.z));
                Vector3 randomCoordinate = origin + randomRange;

                Instantiate(Enemy3Spawn3, SpawnLoc3.transform.position, SpawnLoc3.transform.rotation);
                Instantiate(spawnVFX, SpawnLoc3.transform.position, SpawnLoc3.transform.rotation);
            }
        }
        ////////////////////////////////////////////////////////////////////////////
        // For spawnLoc4
        if (SpawnLoc4 != null)
        {
            for (int i = 0; i < Enemy1Spawn4Quant; i++)
            {
                Vector3 origin = SpawnLoc4.transform.position;
                Vector3 range = transform.localScale / 3f;
                Vector3 randomRange = new Vector3(Random.Range(-range.x, range.x),
                                                  -origin.y,
                                                  Random.Range(-range.z, range.z));
                Vector3 randomCoordinate = origin + randomRange;

                Instantiate(Enemy1Spawn4, SpawnLoc4.transform.position, SpawnLoc4.transform.rotation);
                Instantiate(spawnVFX, SpawnLoc4.transform.position, SpawnLoc4.transform.rotation);
            }

            for (int i = 0; i < Enemy2Spawn4Quant; i++)
            {
                Vector3 origin = SpawnLoc4.transform.position;
                Vector3 range = transform.localScale / 3f;
                Vector3 randomRange = new Vector3(Random.Range(-range.x, range.x),
                                                  -origin.y,
                                                  Random.Range(-range.z, range.z));
                Vector3 randomCoordinate = origin + randomRange;

                Instantiate(Enemy2Spawn4, SpawnLoc4.transform.position, SpawnLoc4.transform.rotation);
                Instantiate(spawnVFX, SpawnLoc4.transform.position, SpawnLoc4.transform.rotation);
            }

            for (int i = 0; i < Enemy3Spawn4Quant; i++)
            {
                Vector3 origin = SpawnLoc4.transform.position;
                Vector3 range = transform.localScale / 3f;
                Vector3 randomRange = new Vector3(Random.Range(-range.x, range.x),
                                                  -origin.y,
                                                  Random.Range(-range.z, range.z));
                Vector3 randomCoordinate = origin + randomRange;

                Instantiate(Enemy3Spawn4, SpawnLoc4.transform.position, SpawnLoc4.transform.rotation);
                Instantiate(spawnVFX, SpawnLoc4.transform.position, SpawnLoc4.transform.rotation);
            }
        }

        Destroy(thisTrigger);
        

    }
}
