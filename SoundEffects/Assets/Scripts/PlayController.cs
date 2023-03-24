using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayController : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody playerRb;
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerRb.AddForce(Vector3.up * 1000);
        }
    }
}
