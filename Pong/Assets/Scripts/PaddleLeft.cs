using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleLeft : MonoBehaviour {

	void Start () {
		
	}

	void Update () {


        float mousePosInUnits = (Input.mousePosition.y / Screen.height * 13f) - 6.5f;

        Vector3 paddlePosition = new Vector3(2f, this.transform.position.x, 0f);

        paddlePosition.x = -7f;
        paddlePosition.y = Mathf.Clamp(mousePosInUnits, -3.9f, 3.9f);

        this.transform.position = paddlePosition;
		
	}
	
}
