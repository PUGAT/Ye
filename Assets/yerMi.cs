using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yerMi : MonoBehaviour {

    void OnCollisionEnter2D(Collision2D yeme)
    {
        if (yeme.gameObject.tag == "ana" && this.gameObject.tag == "Player")
        {
            Destroy(gameObject, 0);
        }
        if (yeme.gameObject.tag=="duvar")
        {
            Destroy(gameObject, 0);
        }
    }
}
