using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AndroidHareket : MonoBehaviour {

	// Use this for initialization
	void Start () {
        ilk = gameObject.transform.position;
	}
    Vector3 ilk;
    float x = Screen.width;
    float y = Screen.height;
    // Update is called once per frame
    void Update()
    {
        var parmak = Input.touches[Input.touches.Length-1];
        if (x / 2 < parmak.position.x && gameObject.transform.position.x < 25-(transform.localScale.x*3)) 
        {
            gameObject.transform.Translate(Vector3.right / 10 * (parmak.position.x - (x / 2)) / 400);
        }
        if (x / 2 >= parmak.position.x && gameObject.transform.position.x > -25+(transform.localScale.x*3))
        {
            gameObject.transform.Translate(Vector3.left / 10 * ((parmak.position.x- (x / 2) ) / 400)*-1);
        }
        if (y / 2 < parmak.position.y && gameObject.transform.position.y < 15.5 - (transform.localScale.y * 3))
        {
            gameObject.transform.Translate(Vector3.up / 8 * (parmak.position.y - (y / 2)) / 400);
        }
        if (y / 2 >= parmak.position.y && gameObject.transform.position.y > -15.5 + (transform.localScale.y * 3))
        {
            gameObject.transform.Translate(Vector3.down / 8 * ((parmak.position.y - (y / 2)) / 400)*-1);
        }
    }
}
