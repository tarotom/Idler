using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameControllerScript : MonoBehaviour
{
    private int moneyInTheBankAmount;
    private GameObject moneyInTheBankUIMoneyAmount;
    private float timer;
    private int updateTime = 1;
    private int increaseMoneyInTheBankBy;
    public TextMeshProUGUI moneyInTheBankAmountGUI;

    // Start is called before the first frame update
    void Start()
    {
        increaseMoneyInTheBankBy = 1;
        moneyInTheBankAmount = 0;
        moneyInTheBankAmountGUI.text = ""+moneyInTheBankAmount;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= updateTime)
        {
            timer = 0f;
            moneyInTheBankAmount += increaseMoneyInTheBankBy;
            moneyInTheBankAmountGUI.text = ""+moneyInTheBankAmount;
        }
    }

    public void IncreaseMoneyInTheBankAmountOnClick(int increaseMoneyInTheBankByClickingAmount) {
        moneyInTheBankAmount += increaseMoneyInTheBankByClickingAmount;
        Debug.Log($"Money in the bank increased by 1. In bank = {moneyInTheBankAmount}");
        moneyInTheBankAmountGUI.text = ""+moneyInTheBankAmount;
    }
}
