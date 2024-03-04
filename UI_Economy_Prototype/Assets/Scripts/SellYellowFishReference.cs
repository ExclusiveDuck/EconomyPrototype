using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SellYellowFishReference : MonoBehaviour
{
    private Money money;
   
    void Start()
    {
        money = GameObject.Find("GameController").GetComponent<Money>();

    }
    public void Purchase()
    {
        money.SellYellowFish();
    }
}
