using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    public int hits = 0;

    private void OnCollisionEnter(Collision other)
    {
        if (!other.gameObject.CompareTag("Hit"))
        {
            hits++;
            Debug.Log("You've bumped into this many things: " + hits);
        }
    }
}
