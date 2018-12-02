using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class PlayerMovement : MonoBehaviour {
    //Variables
    public float speed;

    private float axisY;
    private float axisX;
	
	//Functions
    //FixedUpdate: Run at a max set value every frame (Prevent faster devices from getting faster response time)
	void FixedUpdate () {
        //Get input from joysticks and move per second rather than per frame
        axisX = Input.GetAxis("LeftJoystickVertical") * speed * Time.deltaTime;
        axisY = Input.GetAxis("LeftJoystickHorizontal") * speed * Time.deltaTime;
       
        transform.position -= new Vector3(axisX, 0, axisY);
	}
}
