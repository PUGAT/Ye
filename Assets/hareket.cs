using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hareket : MonoBehaviour {

    Animator anim;
	void Update () {
        if (Input.GetKey(KeyCode.A) && transform.position.x > -5.5)
        {
            gameObject.transform.Translate(Vector3.left /10);
        }
        else if (Input.GetKey(KeyCode.D) && transform.position.x < 5.42)
        {
            gameObject.transform.Translate(Vector3.right /10);
        }
        else if (Input.GetKey(KeyCode.W) && transform.position.y < 8.1)
        {
            gameObject.transform.Translate(Vector3.up /15);
        }
        if (Input.GetKey(KeyCode.S)&&transform.position.y>-7.27)
        {
            gameObject.transform.Translate(Vector3.down /15);
        }
    }
}
