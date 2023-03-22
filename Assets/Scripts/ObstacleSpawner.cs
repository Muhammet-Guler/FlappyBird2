using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public Bird BirdScript;
    public GameObject Engeller;
    public float height;
    public float time;
    private void Start()
    {
        StartCoroutine(SpawnObject(time));
    }
    public IEnumerator SpawnObject(float time)
    {
        while (!BirdScript.oldumu)
        {
            Instantiate(Engeller, new Vector3(6, Random.Range(-height, height), 0), Quaternion.identity);
            yield return new WaitForSeconds(time);
        }

    }

}