using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SellBlueFishReference : MonoBehaviour
{
    private Money money;



    // Start is called before the first frame update
    void Start()
    {
        money = GameObject.Find("GameController").GetComponent<Money>();
    }

    public void Purchase()
    {
        money.SellBlueFish();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
