using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicAttack : MonoBehaviour {
    //Variables
    public float range = 40;

    private float axisY;
    private float axisX;

    //Functions
    //FixedUpdate: Run at a max value every frame (Prevent faster devices from getting faster response time)
    void FixedUpdate() {
        //Get input from joysticks and attack per second rather than per frame
        axisX = Input.GetAxis("RightJoystickVertical") * range * Time.deltaTime;
        axisY = Input.GetAxis("RightJoystickHorizontal") * range * Time.deltaTime;

        transform.localPosition = new Vector3(-axisX, 0, -axisY);
    }
}
