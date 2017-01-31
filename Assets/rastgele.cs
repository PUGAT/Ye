using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rastgele : MonoBehaviour {
    public float cikisZamani;
    public float konum;

	void Start () {
        Invoke("rastsal", cikisZamani);
	}

	void rastsal () {
        transform.position = new Vector3(konum, Random.Range(-12, 13), 0);
        GetComponent<balikEkle>().ekleBalik();
        Invoke("rastsal", cikisZamani);

    }
}
