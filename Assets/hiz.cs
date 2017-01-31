using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hiz : MonoBehaviour {

    void Start()
    {
        transform.eulerAngles = new Vector3(0, 0, Random.Range(0.1f,5.1f));
    }
    public float hizlar;
	void Update () {
        if (transform.position.y>-40)
        {
            gameObject.transform.Translate(Vector3.left / 40 * hizlar * Random.Range(1, 2));
            gameObject.transform.Translate(Vector3.up / 240 * hizlar * Random.Range(-2, 2));
        }
    }
}
