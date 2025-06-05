using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI txtMoney
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void UpdateMoneyTxt(string moneyAmount)
    {
        txtMoney.text = moneyAmount
    }
}
