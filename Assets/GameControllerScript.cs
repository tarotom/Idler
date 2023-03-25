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
    // get all moneymakingresources
    public GameObject moneyMakingMethod1;
    MoneyMakingMethodController moneyMakingMethodControllerScript;

    // Start is called before the first frame update
    void Start()
    {
        increaseMoneyInTheBankBy = 1;
        moneyInTheBankAmount = 0;
        moneyInTheBankAmountGUI.text = ""+moneyInTheBankAmount;
        moneyMakingMethodControllerScript = moneyMakingMethod1.GetComponent<MoneyMakingMethodController>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= updateTime)
        {
            HandleMoneyMakingCalculations();
            timer = 0f;
            moneyInTheBankAmount += increaseMoneyInTheBankBy;
            moneyInTheBankAmountGUI.text = ""+moneyInTheBankAmount;
        }
    }

    public void IncreaseMoneyInTheBankAmountOnClick(int increaseMoneyInTheBankByClickingAmount) {
        moneyInTheBankAmount += increaseMoneyInTheBankByClickingAmount;
        moneyInTheBankAmountGUI.text = ""+moneyInTheBankAmount;
    }

    // take into account all "passive" money making methods
    public void HandleMoneyMakingCalculations(){
        var money = moneyMakingMethodControllerScript.moneyPerSecond * moneyMakingMethodControllerScript.resourcesOwnedAmount;
        moneyInTheBankAmount += money;
    }
}
