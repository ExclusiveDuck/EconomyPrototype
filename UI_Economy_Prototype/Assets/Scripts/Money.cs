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






    //Green Fish and Bait
    public void PurchaseGreenBait()
    {
        if (currentCurrency >= greenBaitCost)
        {
            currentCurrency -= greenBaitCost;
            Instantiate(greenBait, inventoryPosition.position, Quaternion.identity, inventoryPosition);
            greenQuantity++;

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





    //Blue Fish and Bait
    public void PurchaseBlueBait()
    {
        if (currentCurrency >= blueBaitCost)
        {
            currentCurrency -= blueBaitCost;
            Instantiate(blueBait, inventoryPosition.position, Quaternion.identity, inventoryPosition);
            blueQuantity++;

        }
    }
    public void PurchaseBlueFish()
    {
        if (blueQuantity >= 1)
        {
            blueQuantity--;
            Instantiate(blueFish, inventoryPosition.position, Quaternion.identity, inventoryPosition);
            Destroy(GameObject.Find("BlueBait(Clone)"));
        }
    }

    public void SellBlueFish()
    {
        currentCurrency += blueFishValue;
        Destroy(GameObject.Find("BlueFish(Clone)"));
    }





    //Yellow Fish and Bait

    public void PurchaseYellowBait()
    {
        if (currentCurrency >= yellowBaitCost)
        {
            currentCurrency -= yellowBaitCost;
            Instantiate(yellowBait, inventoryPosition.position, Quaternion.identity, inventoryPosition);
            yellowQuantity++;

        }
    }
    public void PurchaseYellowFish()
    {
        if (yellowQuantity >= 1)
        {
            yellowQuantity--;
            Instantiate(yellowFish, inventoryPosition.position, Quaternion.identity, inventoryPosition);
            Destroy(GameObject.Find("YellowBait(Clone)"));
        }
    }

    public void SellYellowFish()
    {
        currentCurrency += yellowFishValue;
        Destroy(GameObject.Find("YellowFish(Clone)"));

    }

    //Red Fish and Bait
    public void PurchaseRedBait()
    {
        if (currentCurrency >= redBaitCost)
        {
            currentCurrency -= redBaitCost;
            Instantiate(redBait, inventoryPosition.position, Quaternion.identity, inventoryPosition);
            redQuantity++;

        }
    }
    public void PurchaseRedFish()
    {
        if (redQuantity >= 1)
        {
            redQuantity--;
            Instantiate(redFish, inventoryPosition.position, Quaternion.identity, inventoryPosition);
            Destroy(GameObject.Find("RedBait(Clone)"));
        }
    }

    public void SellRedFish()
    {
        currentCurrency += redFishValue;
        Destroy(GameObject.Find("RedFish(Clone)"));

    }















}

