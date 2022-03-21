using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        { 
            GetComponent<MeshRenderer>().material.color = Color.red;
            // this.GetComponent<MeshRenderer>().material.color = Color.red;
            // GetComponent<MeshRenderer>().material.color = Color.red;
            //
            // Are the same

            gameObject.tag = "Hit";
            // this.gameObject.tag = "Hit";
            // gameObject.tag = "Hit";
            //
            // Are the same
        }
    }
}
