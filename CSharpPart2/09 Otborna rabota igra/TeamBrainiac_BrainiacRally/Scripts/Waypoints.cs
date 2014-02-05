using UnityEngine;
using System.Collections;

public class Waypoints : MonoBehaviour 
{
	public static Waypoints start;

	// waypoint properties
	public Waypoints next;
	public bool isStart = false;
	
	void Awake()
	{
		if(!next) // waypoit is not connected to loop
		{
			Debug.LogWarning("This waypoint is not connected!");	
		}
		
		if(isStart) // first waypoint
		{
			start = this;	
		}
	}
	
	void OnDrawGizmos() 
	{
		// create object on screen - red cube as waypoint, and draw line between the waypoints
		Gizmos.color = Color.red;
		Gizmos.DrawCube(transform.position, new Vector3(0.5f, 0.5f, 0.5f));
		
		if(next)
		{
			Gizmos.color = Color.green;
			Gizmos.DrawLine(transform.position, next.transform.position);
		}
	}	
}
