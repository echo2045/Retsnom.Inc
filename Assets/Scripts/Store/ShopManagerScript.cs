using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;

public class ShopManagerScript : MonoBehaviour
{
    public int[,] shopItems = new int[4,4];
    public float gold;
    public TextMeshProUGUI goldTxt;
    
    void Start()
    {
        goldTxt.text = "Gold: " + gold.ToString();

        //Items
        shopItems[1, 1] = 1;
        shopItems[1, 2] = 2;
        shopItems[1, 3] = 3;

        //Price
        shopItems[2, 1] = 200;
        shopItems[2, 2] = 200;
        shopItems[2, 3] = 500;

        //Info actually Quantity
        shopItems[3, 1] = 0;
        shopItems[3, 2] = 0;
        shopItems[3, 3] = 0;

    }

    
    public void Buy()
    {
        GameObject ButtonRef = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObject;

        if (gold >= shopItems[2, ButtonRef.GetComponent<ButtonInfo>().ItemID])
        {
            gold -= shopItems[2, ButtonRef.GetComponent<ButtonInfo>().ItemID];
            goldTxt.text = "Gold: " + gold;

            

        }

    }
}
