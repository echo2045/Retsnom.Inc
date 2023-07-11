using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopInteraction : MonoBehaviour
{

    bool inRange, on;

    public GameObject shop;
    // Start is called before the first frame update
    void Start()
    {
        inRange = false;
        on = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(inRange && Input.GetKeyDown("e") && !shop.activeInHierarchy)
        {
            shop.SetActive(true);
            on = true;
        } else if (inRange && Input.GetKeyDown("e") && shop.activeInHierarchy)
        {
            shop.SetActive(false);
            on = false;
        }

 
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        inRange = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        inRange = false;
        shop.SetActive(false);
    }
}
