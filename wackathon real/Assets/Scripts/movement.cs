using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float speed = 2f; // Speed of movement
    private Vector3 targetPosition; // Target position (left side of the screen)

    void Start()
    {
        // Set the target position to the left side of the screen
        targetPosition = Camera.main.ViewportToWorldPoint(new Vector3(0, 0.5f, 10));
        // Set the initial position to the center of the screen
        transform.position = Camera.main.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 10));
    }

    void Update()
    {
        // Move the sprite towards the target position
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

        // If the sprite reaches the target position, disable the script to stop the movement
        if (transform.position == targetPosition)
        {
            enabled = false;
        }
    }
}
