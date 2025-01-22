using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public float radiusDistance =2f; 
    public Transform playerTransform;
    public Vector3 distanceVec = Vector3.zero;

    private void Update()
    {
        FindDistanceVector();
        IsPlayerWithinRadius();
    }
    private void FindDistanceVector()
    {
        distanceVec = this.transform.position - playerTransform.position;
    }
    private void IsPlayerWithinRadius()
    {
        float objDistance = distanceVec.sqrMagnitude;
        if (objDistance<= radiusDistance*radiusDistance)
        { 
            Debug.Log("Alert: Player is nearby!");
        }
        else
        {
            Debug.Log("-");
        }
    }
}
