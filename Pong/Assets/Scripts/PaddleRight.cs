using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleRight : MonoBehaviour {

    public float pSpeed = 0.05f;
    public Vector3 playerPos;

	void Update () {

        float yPos = gameObject.transform.position.y + (Input.GetAxis("Vertical") * pSpeed);
        playerPos = new Vector3(7f, Mathf.Clamp(yPos,-3.9f, 3.9f));
        gameObject.transform.position = playerPos;

    }
}
