using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ButtonInfo : MonoBehaviour
{
    public int ItemID;
    public TextMeshProUGUI PriceText, QuantityText;
    public GameObject ShopManager;

    void Update()
    {
        PriceText.text = "Price: " + ShopManager.GetComponent<ShopManagerScript>().shopItems[2, ItemID].ToString();
        QuantityText.text =  ShopManager.GetComponent<ShopManagerScript>().shopItems[3, ItemID].ToString();


    }
}
