using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balikEkle : MonoBehaviour {
    ye puan = new ye();
    public Rigidbody2D balik;
    public void ekleBalik()
    {

        Rigidbody2D balikKopya;
        balikKopya = Instantiate(balik, transform.position, Quaternion.identity) as Rigidbody2D;
    }
}
