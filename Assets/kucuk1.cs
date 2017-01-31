using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kucuk1 : MonoBehaviour {

    void OnCollisionEnter2D(Collision2D yeme)
    {
        if (yeme.gameObject.tag!="Player")
        {
            if (yeme.gameObject.tag == "kopek")
            {
                Destroy(gameObject, 0);
            }
            else if (yeme.gameObject.tag == "balik1")
            {
                Destroy(gameObject, 0);
            }
            else if (yeme.gameObject.tag == "balik2")
            {
                Destroy(gameObject, 0);
            }
            else if (yeme.gameObject.tag == "balik3")
            {
                Destroy(gameObject, 0);
            }
            else if (yeme.gameObject.tag == "balik4")
            {
                Destroy(gameObject, 0);
            }
            else if (yeme.gameObject.tag == "balik5")
            {
                Destroy(gameObject, 0);
            }
        }
    }
}
