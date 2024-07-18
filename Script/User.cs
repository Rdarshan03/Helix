using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public class User : MonoBehaviour
{
    public GameObject Play, start;
    Vector3 YAxis;
    public GameObject splash;
    public float bounceforce;
    Rigidbody rb;
    void Start()
    {

        rb = GetComponent<Rigidbody>();

    }

    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
       //rb.velocity = new Vector3(rb.velocity.x, bounceforce * Time.deltaTime, rb.velocity.z);
        
        if (collision.gameObject.tag == "Over")
        {
            start.SetActive(true);
            Time.timeScale = 0f;
        }
        if (collision.gameObject.tag == "Win")
        {
            Play.SetActive(false);
            start.SetActive(true);
            Time.timeScale = 0f;
        }
        // splash generator
        rb.velocity = Vector3.up * 200 * Time.deltaTime;
        Generatesplash(collision.gameObject.transform);
    }

    private void Generatesplash(Transform collosionTran)
    {
        var p = Instantiate(splash, collosionTran);
        //print("splash" + splash);
        var pos = transform.position;
        pos.y -= .08f;

        p.transform.position = pos;

    }

    public void btnRetry()
    {
        start.SetActive(false);
        Time.timeScale = 1f;
        SceneManager.LoadScene("Lvl 1");

    }
}
