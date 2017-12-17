using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    public float ballV = 375;

    Rigidbody2D rB;

    bool isPlay;

    int rInt;

    void Awake() {

        rB = gameObject.GetComponent<Rigidbody2D>();
        rInt = Random.Range(1, 3);

    }
	
	void Update () {

            if (Input.GetMouseButton(0) == true && isPlay == false)
            {
                transform.parent = null;
                isPlay = true;
                rB.isKinematic = false;
                if (rInt == 1)
                {
                    rB.AddForce(new Vector3(ballV, ballV, 0));
                }
                if (rInt == 2)
                {
                    rB.AddForce(new Vector3(-ballV, -ballV, 0));
                }
            }

        }
    }

