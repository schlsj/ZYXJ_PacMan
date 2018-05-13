using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroControl : MonoBehaviour {

    public float TurnTime = 0.5f;

    Vector3 targetVector = Vector3.forward;
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.A))
        {
            targetVector = Vector3.left;
        }else if (Input.GetKey(KeyCode.D))
        {
            targetVector = Vector3.right;
        }else if (Input.GetKey(KeyCode.W))
        {
            targetVector = Vector3.forward;
        }else if (Input.GetKey(KeyCode.S))
        {
            targetVector = Vector3.back;
        }
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(targetVector), TurnTime);
	}
}
