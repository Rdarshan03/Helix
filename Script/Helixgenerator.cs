using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Colorcombination
{
    [SerializeField]
    public Color Cylinder;
    public Color BG;
    public Color hell;
    public Color Over;
    public Color Ball;
}

public class Helixgenerator : MonoBehaviour
{
    public GameObject pipe;
    public Image background;
    public GameObject Ball;
    public GameObject Pieace;
    public GameObject Winpieace;
    public GameObject[] allPrefab;
    [SerializeField] 
    public Colorcombination[] combination;
    public float offset;
    public int helixSize;



    // Start is called before the first frame update
    void Start()
    {
        var clr = combination[Random.Range(0, combination.Length)];
        pipe.GetComponent<MeshRenderer>().material.color = clr.Cylinder;
        Ball.GetComponent<MeshRenderer>().material.color = clr.Ball;
        background.color = clr.BG;

        for (int i = 0; i < helixSize; i++)
        {

            var randomPrefab = allPrefab[Random.Range(0, allPrefab.Length)];
            var piece = Instantiate(randomPrefab, transform);
            var pos = piece.transform.position;
            pos.y -= offset * i;
            piece.transform.position = pos;
            var rota = Random.Range(0, 360);
            piece.transform.rotation = Quaternion.Euler(0, rota, 0);
        }
        
        var W = Instantiate(Winpieace, transform);
        var Winpos = W.transform.position;
        Winpos.y -= offset * helixSize;
        W.transform.position = Winpos;  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
