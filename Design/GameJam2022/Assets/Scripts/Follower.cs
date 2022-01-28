using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follower : MonoBehaviour
{
    private GameObject wayPoint;
    private Vector3 wayPointPosition;

    public float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        wayPoint = GameObject.Find("wayPoint");
    }

    // Update is called once per frame
    void Update()
    {
        wayPointPosition = new Vector3(wayPoint.transform.position.x, wayPoint.transform.position.y, wayPoint.transform.position.z);
        transform.position = Vector3.MoveTowards(transform.position, wayPointPosition, speed * Time.deltaTime);
    }
}
