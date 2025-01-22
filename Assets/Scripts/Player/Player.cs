using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed;

    Vector3 inputVec = Vector3.zero;
    private void Update()
    {
        inputVec = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
     //   Debug.Log(inputVec);
    }

    private void FixedUpdate()
    {
        PlayerMovement();
    }
    private void PlayerMovement()
    {
        this.transform.position += inputVec*moveSpeed*Time.fixedDeltaTime;
    }
}
