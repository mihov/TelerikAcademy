using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemyMovement : MonoBehaviour 
{
	public bool raceStarted			= false; // add "static" if set this bit in other method
	
	public float aiSpeed				 	= 10.5f; // enemy speed
	public float aiTurnSpeed				= 2.0f;	 // enemy turn speed
	public float resetAISpeed				= 0.0f;
	public float resetAITurnSpeed			= 0.0f;
	
	public GameObject waypointController;

	public List<Transform> waypoints; // initialized in method GetWaypoints()

	public int currentWaypoint				= 0;
	public float currentSpeed;
	public Vector3 currentWaypointPosition;
	
	// Use this for initialization
	void Start () 
	{
		GetWaypoints();
		resetAISpeed = aiSpeed;
		resetAITurnSpeed = aiTurnSpeed;
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		if(raceStarted)
		{
			MoveTowardWaypoints();	
		}
	}

	// collect all waypoints in list 'waypoints'
	void GetWaypoints()
	{
		// array ot potential waypoints
		Transform[] potentialWaypoints = waypointController.GetComponentsInChildren<Transform>();
		
		waypoints = new List<Transform>();
		
		foreach(Transform potentialWaypoint in potentialWaypoints)
		{
			if(potentialWaypoint != waypointController.transform)
			{
				waypoints.Add(potentialWaypoint);	
			}
		}
	}
	
	void MoveTowardWaypoints()
	{
		// position x,y,z of current waypoint
		float currentWaypointX = waypoints[currentWaypoint].position.x;
		float currentWaypointY = transform.position.y;
		float currentWaypointZ = waypoints[currentWaypoint].position.z;

		// distance between enemy and current waypoint
		Vector3 relativeWaypointPosition = transform.InverseTransformPoint (new Vector3(currentWaypointX, currentWaypointY, currentWaypointZ));
		currentWaypointPosition = new Vector3(currentWaypointX, currentWaypointY, currentWaypointZ);

		// turn toward next waypoint
		Quaternion toRotation = Quaternion.LookRotation(currentWaypointPosition - transform.position);
		transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, aiTurnSpeed);
		
		rigidbody.AddRelativeForce(0, 0, aiSpeed);

		// search next waypoint
		if(relativeWaypointPosition.sqrMagnitude < 15.0f)
		{
			currentWaypoint++;			
			if(currentWaypoint >= waypoints.Count)
			{
				currentWaypoint = 0;	
			}
		}


		currentSpeed = Mathf.Abs(transform.InverseTransformDirection(rigidbody.velocity).z);
		
		float maxAngularDrag			 	= 2.5f;
		float currentAngularDrag 			= 1.0f;
		float aDragLerpTime					= currentSpeed * 0.1f;
		
		float maxDrag			 			= 1.0f;
		float currentDrag 					= 3.5f; 					// change that to fix problem in turning
		float dragLerpTime					= currentSpeed * 0.1f;
		
		float myAngularDrag	= Mathf.Lerp(currentAngularDrag, maxAngularDrag, aDragLerpTime);
		float myDrag		= Mathf.Lerp(currentDrag, maxDrag, dragLerpTime);
		
		rigidbody.angularDrag = myAngularDrag;
		rigidbody.drag = myDrag; 
	}
}
