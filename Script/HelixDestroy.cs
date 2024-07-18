using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HelixDestroy : MonoBehaviour
{

    Transform player;

   

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;

    }

    // Update is called once per frame
    void Update()
    {
        if (player.position.y + 0.05f < transform.position.y)
        {
            
            Collider[] colArray = Physics.OverlapSphere(transform.position, 1);
            foreach (var col in colArray)
            {
               Rigidbody rb = col.gameObject.GetComponent<Rigidbody>();
                if (rb != null && col.gameObject.tag == "Destro" || col.gameObject.tag == "Over")
                {
                    rb.isKinematic = false;
                    rb.AddExplosionForce(20, transform.position,100);
                    col.gameObject.GetComponent<MeshCollider>().isTrigger = true;
                    //col.gameObject.tag = "Untagged";
                }
            }

            Destroy(gameObject, 1);
        }
    }
}
