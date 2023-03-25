using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMoneyMaker : MonoBehaviour
{
    public GameControllerScript gameControllerScript;
    int moneyToTheBankFromClickingAmount;

    // Start is called before the first frame update
    void Start()
    {
        // Button btn = moneyMaker.GetComponent<Button>();
		// btn.onClick.AddListener(TaskOnClick);
        moneyToTheBankFromClickingAmount = 9;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown() {
        Debug.Log("MONEY MONEY MONEEEYYYY! MONEY!!");
        gameControllerScript.IncreaseMoneyInTheBankAmountOnClick(moneyToTheBankFromClickingAmount);
    }

}
