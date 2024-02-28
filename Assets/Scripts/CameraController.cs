using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = player.transform.position;
        transform.Translate(0, 3, -10);
        transform.rotation = Quaternion.Euler(40.0f, 0.0f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        // Set the camera's position to the player's position
        transform.position = player.transform.position;

        // Move the camera back
        transform.Translate(0, 3, -10);
    }
}
