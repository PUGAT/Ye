using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ye : MonoBehaviour {
    int balikPuan = 0;
    bool a = true, b = true, c = true, d = true;
    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D yeme)
    {
        transform.eulerAngles=new Vector3(0, 0, 0);
        Color color = new Color();
        if (yeme.gameObject.tag=="kopek")
        {
            Destroy(gameObject, 0);
            Application.LoadLevel("tekrar");
        }
        else if (yeme.gameObject.tag=="balik1")
        {
            if (balikPuan>=0)
            {
                Destroy(yeme.gameObject, 0);
                balikPuan += 5;
                if (yeme.gameObject.tag!="Player")
                {
                    yeme.gameObject.tag = "Player";
                }
                if (balikPuan>400&&balikPuan<550)
                {
                }
                else if (balikPuan>650&&balikPuan<800)
                {

                }
                else if(balikPuan<900)
                {
                    transform.localScale = transform.localScale * 1017 / 1000;
                }
                else
                {
                    transform.localScale = transform.localScale * 1002 / 1000;
                }
            }
            else
            {
                Destroy(gameObject,0);
                Application.LoadLevel("tekrar");
            }
        }
        else if (yeme.gameObject.tag == "balik2")
        {
            if (balikPuan >= 50)
            {
                Destroy(yeme.gameObject, 0);
                balikPuan += 10;
                if (yeme.gameObject.tag != "Player")
                {
                    yeme.gameObject.tag = "Player";
                }
                if (balikPuan>400&&balikPuan<550)
                {
                }
                else if (balikPuan>650&&balikPuan<800)
                {

                }
                else if(balikPuan<900)
                {
                    transform.localScale = transform.localScale * 1024 / 1000;
                }
                else
                {
                    transform.localScale = transform.localScale * 1002 / 1000;
                }
            }
            else
            {
                Destroy(gameObject, 0);
                Application.LoadLevel("tekrar");
            }
        }
        else if (yeme.gameObject.tag == "balik3")
        {
            if (balikPuan >= 150)
            {
                Destroy(yeme.gameObject, 0);
                balikPuan += 20;
                if (yeme.gameObject.tag != "Player")
                {
                    yeme.gameObject.tag = "Player";
                }
                if (balikPuan > 400 && balikPuan < 550)
                {
                }
                else if (balikPuan > 650 && balikPuan < 800)
                {

                }
                else if(balikPuan<900)
                {
                    transform.localScale = transform.localScale * 1034 / 1000;
                }
                else
                {
                    transform.localScale = transform.localScale * 1002 / 1000;
                }
            }
            else
            {
                Destroy(gameObject, 0);
                Application.LoadLevel("tekrar");
            }
        }
        else if (yeme.gameObject.tag == "balik4")
        {
            if (balikPuan >= 350)
            {
                Destroy(yeme.gameObject, 0);
                balikPuan += 40;
                if (yeme.gameObject.tag != "Player")
                {
                    yeme.gameObject.tag = "Player";
                }
                if (balikPuan > 400 && balikPuan < 550)
                {
                }
                else if (balikPuan > 650 && balikPuan < 800)
                {

                }
                else if (balikPuan<900)
                {
                    transform.localScale = transform.localScale * 1045 / 1000;
                }
                else
                {
                    transform.localScale = transform.localScale * 1002 / 1000;
                }
            }
            else
            {
                Destroy(gameObject, 0);
                Application.LoadLevel("tekrar");
            }
        }
        else if (yeme.gameObject.tag == "balik5")
        {
            if (balikPuan >= 900)
            {
                Destroy(yeme.gameObject, 0);
                balikPuan += 80;
                if (yeme.gameObject.tag != "Player")
                {
                    yeme.gameObject.tag = "Player";
                }
                if (balikPuan > 400 && balikPuan < 550)
                {
                }
                else if (balikPuan > 650 && balikPuan < 800)
                {

                }
                else if (balikPuan<900)
                {
                    transform.localScale = transform.localScale * 1056 / 1000;
                }
                else
                {
                    transform.localScale = transform.localScale * 1002 / 1000;
                }
            }
            else
            {
                Destroy(gameObject, 0);
                Application.LoadLevel("tekrar");
            }
        }
        if (d == true && balikPuan >= 900) 
        {
            if (d == true)
            {
                Debug.Log("renk1");
                ColorUtility.TryParseHtmlString("#D5FF85FF", out color);
                this.gameObject.GetComponent<SpriteRenderer>().color = color;
                d = false;
            }
        }
        else if (c == true && balikPuan >= 350)
        {
            if (c == true)
            {
                Debug.Log("renk1");
                ColorUtility.TryParseHtmlString("#85FFE6FF", out color);
                this.gameObject.GetComponent<SpriteRenderer>().color = color;
                c = false;
            }
        }
        else if (d == true && balikPuan >= 150)
        {
            if (b == true)
            {
                Debug.Log("renk1");
                ColorUtility.TryParseHtmlString("#9885FFFF", out color);
                this.gameObject.GetComponent<SpriteRenderer>().color = color;
                b = false;
            }
        }
        else if (a == true && balikPuan >= 50)
        {
            if (a == true)
            {
                Debug.Log("renk1");
                ColorUtility.TryParseHtmlString("#FFACACFF", out color);
                this.gameObject.GetComponent<SpriteRenderer>().color = color;
                a = false;
            }
        }
    }
}
