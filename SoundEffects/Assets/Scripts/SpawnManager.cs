using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] obstaclePrefabs;
    private Vector3 spawnPos = new Vector3(25, 0, 0);
    private float startDelay = 2;
    private float repeatRate = 2;
    private PlayController playeControllerScript;
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
        playeControllerScript = GameObject.Find("Player").GetComponent<PlayController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObstacle()
    {
        int index = Random.RandomRange(0, obstaclePrefabs.Length);
        if (playeControllerScript.gameOver == false)
            Instantiate(obstaclePrefabs[index], spawnPos, obstaclePrefabs[index].transform.rotation);
    }
}
