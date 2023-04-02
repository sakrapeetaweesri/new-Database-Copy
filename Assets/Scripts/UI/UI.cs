using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI : MonoBehaviour
{
    public static UI instance;

    public TMP_Text moneyText;
    public TMP_Text staffText;
    public TMP_Text wheatText;
    public TMP_Text melonText;
    public TMP_Text cornText;
    public TMP_Text appleText;
    
    void Start()
    {
        instance = this;
    }

    
    void Update()
    {
        
    }

    public void UpdateHeaderPanel()
    {
        moneyText.text = GameManager.instance.money.ToString();
    }
}
