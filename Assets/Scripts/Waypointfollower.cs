using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypointfollower : MonoBehaviour
{

    public GameObject[] waypoints;
    int currentWaypointIndex;
    public SetState state;

    public float speed = .1f;
    

    void Start()
    {
    }

    void Update()
    {
        if (state.isDiavoloMoving) { 
            if (Vector3.Distance(transform.position, waypoints[currentWaypointIndex].transform.position) < .1f){
                currentWaypointIndex++;
                if(currentWaypointIndex >= waypoints.Length){
                    currentWaypointIndex = 0;
                }
            }
            transform.position = Vector3.MoveTowards(transform.position, waypoints[currentWaypointIndex].transform.position, speed * Time.deltaTime );
        }
    }

    public void walk(){
        FindObjectOfType<AudioMenager>().Play("Walk");

    }
}
