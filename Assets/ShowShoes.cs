using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowShoes : MonoBehaviour
{
    public GameObject Shoes1L;
    public GameObject Shoes1R;
    public GameObject Shoes2L;
    public GameObject Shoes2R;

    public bool shoes1 = false;
    public bool shoes2 = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (shoes1)
        {
            Shoes1L.SetActive(true);
            Shoes1R.SetActive(true);
            Shoes2L.SetActive(false);
            Shoes2R.SetActive(false);
        }
        if (shoes2)
        {
            Shoes1L.SetActive(false);
            Shoes1R.SetActive(false);
            Shoes2L.SetActive(true);
            Shoes2R.SetActive(true);
        }

    }
    public void Shoes1()
    {
        shoes1 = true;
        shoes2 = false;
    }
    public void Shoes2()
    {
        shoes1 = false;
        shoes2 = true;
    }

}
