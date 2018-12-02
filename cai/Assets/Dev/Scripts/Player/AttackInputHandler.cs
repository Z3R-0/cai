using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackInputHandler : MonoBehaviour {

    public GameObject hitbox;

    private int killHitbox;
    private int recoveryTime;

    // Use this for initialization
    void Start() {
        hitbox.SetActive(false);
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetButton("RightBumper")) {
            hitbox.SetActive(true);
            StartCoroutine(Timer());
        }

        if (killHitbox == 13) {
            hitbox.SetActive(false);
            killHitbox = 0;
        }
        killHitbox++;
    }
    //NOT WORKING
    IEnumerator Timer() {
        yield return new WaitForSeconds(0.5f);
    }
}

