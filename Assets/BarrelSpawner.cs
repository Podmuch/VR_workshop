using UnityEngine;
using System.Collections;

public class BarrelSpawner : MonoBehaviour
{
    public Transform BarrelPrefab;

    public float SpawnInterval;

    void Start()
    {
        StartCoroutine(SpawingCoroutine());
    }

    IEnumerator SpawingCoroutine()
    {
        while(true)
        {
            Transform newBarrel = Instantiate<Transform>(BarrelPrefab);
            newBarrel.position = new Vector3(Random.Range(0, 25), 15, Random.Range(-10,15));
            yield return new WaitForSeconds(SpawnInterval);
        }
    }
}
