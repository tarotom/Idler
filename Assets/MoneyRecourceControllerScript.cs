using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyRecourceControllerScript : MonoBehaviour
{
    public Button buyButton;
    public Button sellButton;
    public Button buyTenButton;
    public Button buyHundredButton;
    public Button buyMaxButton;

    //public GameObject moneyMakingMethod1;
    MoneyMakingMethodController moneyMakingMethodControllerScript;

    // Start is called before the first frame update
    void Start()
    {
        moneyMakingMethodControllerScript = GetComponent<MoneyMakingMethodController>();
        buyButton.onClick.AddListener(BuyButtonClicked);
        sellButton.onClick.AddListener(SellButtonClicked);
    }

    // Update is called once per frame
    void Update()
    {
    }

    void BuyButtonClicked()
    {
        moneyMakingMethodControllerScript.resourcesOwnedAmount += 1;
    }

    void SellButtonClicked()
    {
        Debug.Log("Buy button clicked!");
        if (moneyMakingMethodControllerScript.resourcesOwnedAmount > 0)
        {
            moneyMakingMethodControllerScript.resourcesOwnedAmount -= 1;
        }
    }

}
