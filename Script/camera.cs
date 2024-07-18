using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class camera : MonoBehaviour
{
    public Transform target;
    //private float smoothtime;
    //private Vector3 currentvelocity = Vector3.zero;
    private Vector3 offset;
    private Vector3 lastpos;
    public Material[] Skybox;

    private void Start()
    {
        var sky = Skybox[Random.Range(0, Skybox.Length)];


    }

    private void Awake()
    {
        offset = transform.position - target.position;
        lastpos = target.position + offset;
    }
    private void Update()
    {
        /*Vector3 targetposition = target.position + offset;
        transform.position = Vector3.SmoothDamp(ref transform.position, ref targetposition, ref currentvelocity, ref smoothtime);*/

        var pos = transform.position;
        pos.y = Mathf.Min(target.position.y + 1.5f, lastpos.y);
        lastpos = pos;
        transform.position = pos;

    }

}
