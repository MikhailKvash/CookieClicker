using System.Collections;
using UnityEngine;
using TMPro;

public class AutoSell : MonoBehaviour
{
    [SerializeField] GameObject shopStats;
    
    public static int cashIncrease = 1;
    public int internalIncrease;

    private int sellingPrice;
    private int remainingCookies;

    public void Start()
    {
        StartCoroutine(SellTheCookie());
    }
    
    void Update()
    {
        sellingPrice = Mathf.RoundToInt(internalIncrease * MultiplierUpgrade.cashMultiplier);
        remainingCookies = Mathf.RoundToInt(GlobalCookies.cookieCount * MultiplierUpgrade.cashMultiplier);
        
        if (GlobalCookies.cookieCount >= internalIncrease && GlobalShop.shopPerSec >= 1)
        {
            shopStats.GetComponent<TextMeshProUGUI>().text = "Cookies sold per second: " + sellingPrice;
        }
        else if (GlobalCookies.cookieCount < internalIncrease && GlobalShop.shopPerSec >= 1)
        {
            shopStats.GetComponent<TextMeshProUGUI>().text = "Cookies sold per second: " + remainingCookies;
        }
        else
        {
            shopStats.GetComponent<TextMeshProUGUI>().text = "Cookies sold per second: 0";
        }
        
        cashIncrease = GlobalShop.shopPerSec;
        internalIncrease = cashIncrease;
    }

    IEnumerator SellTheCookie()
    {
        yield return new WaitForSeconds(1);
        if (GlobalCookies.cookieCount >= internalIncrease && GlobalShop.shopPerSec >= 1)
        {
            GlobalCash.cashCount += sellingPrice;
            GlobalCookies.cookieCount -= internalIncrease;
        }
        else if (GlobalCookies.cookieCount < internalIncrease && GlobalShop.shopPerSec >= 1)
        {
            GlobalCash.cashCount += remainingCookies;
            GlobalCookies.cookieCount = 0;
        }
        StartCoroutine(SellTheCookie());
    }
}
