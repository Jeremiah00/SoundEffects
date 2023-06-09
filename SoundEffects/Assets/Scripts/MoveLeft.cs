using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    // Start is called before the first frame update
    private float speed = 30;
    private PlayController playerControllerScript;
    private float leftbound = -15;
    
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerControllerScript.gameOver == false)
        {
            if (playerControllerScript.doubleSpeed)
            {
                transform.Translate(Vector3.left * Time.deltaTime * (speed * 2));
            }
            else
            {
                transform.Translate(Vector3.left * Time.deltaTime * speed);
            }
        }

        if (transform.position.x < leftbound && gameObject.CompareTag("Obstacle"))
            Destroy(gameObject);
    }
}
