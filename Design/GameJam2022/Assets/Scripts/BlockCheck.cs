using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockCheck : MonoBehaviour
{
    public float distance;

    /*
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "block_corupted_file")
        {
            Debug.Log("Player is on corrupted block");

        }
        else if (collision.gameObject.name == "block_grass_file")
            Debug.Log("Player is on grass block");
    }
    */

    // Start is called before the first frame update
    void Start()
    {
        distance += 1;
    }

    // Update is called once per frame
    void Update()
    {
        
        RaycastHit hit;
        Ray blockCheckRay = new Ray(transform.position, Vector3.down);
        if (Physics.Raycast(blockCheckRay, out hit, distance))
        {
            if (hit.collider.name == "block_corupted_file")
            
                Debug.Log("Player is on corrupted block");
            
            else if (hit.collider.name == "block_grass_file")
                Debug.Log("Player is on grass block");
        }
    }
}
