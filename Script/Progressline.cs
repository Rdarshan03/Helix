using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Progressline : MonoBehaviour
{
    public GameObject Player;
    public GameObject Finish;


    Image progressbar;
    float maxdistance;

    void Start()
    {
        progressbar = GetComponent<Image>();
        maxdistance = Finish.transform.position.y;
    }


    void Update()
    {
        progressbar.fillAmount = .5f;
    }
}
