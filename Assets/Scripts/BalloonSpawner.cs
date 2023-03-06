using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonSpawner : MonoBehaviour
{
    public Bird BirdScript;
    public GameObject Balloon;
    public float Height;
    public float Time;
    private void Start()
    {
        StartCoroutine(SpawnObject(Time));
    }
    public IEnumerator SpawnObject(float Time)
    {
        while (!BirdScript.oldumu)
        {
            Instantiate(Balloon, new Vector3(3, Random.Range(-Height, Height), 0), Quaternion.identity);
            yield return new WaitForSeconds(Time);
        }

    }
    
}
