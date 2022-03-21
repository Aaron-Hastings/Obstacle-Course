using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float xSpeed = 2.0f;
    [SerializeField] float zSpeed = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        PrintInstructions();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void PrintInstructions()
    {
        Debug.Log("Welcome to the Game");
        Debug.Log("Use WASD or ARROW keys to Move");
        Debug.Log("Don't touch the walls");
        Debug.Log("Prepare to Die");
        Debug.Log("Wha-ha-ha-ha");
    }

    void MovePlayer()
    {
        float xStep = Time.deltaTime * Input.GetAxis("Horizontal") * xSpeed;
        float zStep = Time.deltaTime * Input.GetAxis("Vertical") * zSpeed;
        transform.Translate(xStep, 0.0f, zStep); // Add to existing position
    }
}
