using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SellBlueFishReference : MonoBehaviour
{
    private Money money;

    void Start()
    {
        money = GameObject.Find("GameController").GetComponent<Money>();
    }

    public void Purchase()
    {
        money.SellBlueFish();
    }

}
