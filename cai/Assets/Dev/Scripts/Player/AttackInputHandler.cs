using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackInputHandler : MonoBehaviour {

    public GameObject hitbox;

    private int killHitbox;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (Input.GetButton("RightBumper")) {
            hitbox.SetActive(true);
        } else if (killHitbox == 100) {
            return;
        }
	}
}
