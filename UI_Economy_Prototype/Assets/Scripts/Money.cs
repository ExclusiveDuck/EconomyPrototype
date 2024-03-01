using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Money : MonoBehaviour
{
    

    [Header("Cost of Bait")]
    public float greenBaitCost;
    public float blueBaitCost;
    public float yellowBaitCost;
    public float redBaitCost;

    [Header("Sale price of Fish")]
    public float greenFishValue;
    public float blueFishValue;
    public float yellowFishValue;
    public float redFishValue;

    [Header("Amount of Fish Caught")]
    public int greenFishAmount;
    public int blueFishAmount;
    public int yellowFishAmount;
    public int redFishAmount;

    [Header("Gold")]
    public float currentCurrency;
    public float startingCurrency;



    [Header("References")]
    public GameObject greenFish;
    public GameObject blueFish;
    public GameObject yellowFish;
    public GameObject redFish;

    public GameObject greenBait;
    public GameObject blueBait;
    public GameObject yellowBait;
    public GameObject redBait;

    public TextMeshProUGUI textCurrency;


    public Transform inventoryPosition;

    [Header("Quantity of Bait")]
    public int greenQuantity;
    public int blueQuantity;
    public int yellowQuantity;
    public int redQuantity;






    // Start is called before the first frame update
    void Start()
    {
        currentCurrency = startingCurrency;
    }

    // Update is called once per frame
    void Update()
    {
        textCurrency.text = "Current Gold $" + currentCurrency;
    }

    public void PurchaseGreenBait()
    {
        if (currentCurrency >= greenBaitCost)
        {
            currentCurrency -= greenBaitCost;
            Instantiate(greenBait, inventoryPosition.position, Quaternion.identity, inventoryPosition);
            greenQuantity ++;

        }
    }
    public void PurchaseGreenFish()
    {
        if (greenQuantity >= 1)
        {
            greenQuantity--;
            Instantiate(greenFish, inventoryPosition.position, Quaternion.identity, inventoryPosition);
            Destroy(GameObject.Find("GreenBait(Clone)"));
        }
    }

    public void SellGreenFish()
    {
        currentCurrency += greenFishValue;
        Destroy(GameObject.Find("GreenFish(Clone)"));
    }
}
