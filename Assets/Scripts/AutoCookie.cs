using System.Collections;
using UnityEngine;
using TMPro;

public class AutoCookie : MonoBehaviour
{
    [SerializeField] GameObject bakerStats;
    
    public static int cookieIncrease = 1;
    public int internalIncrease;

    public void Start()
    {
        StartCoroutine(CreateTheCookie());
    }

    void Update()
    {            
        bakerStats.GetComponent<TextMeshProUGUI>().text = "Cookies baked per second: " + internalIncrease;
        
        cookieIncrease = GlobalBaker.bakePerSec;
        internalIncrease = cookieIncrease;
    }

    IEnumerator CreateTheCookie()
    {
        yield return new WaitForSeconds(1);
        if (GlobalBaker.bakePerSec >= 1)
        {
            internalIncrease = Mathf.RoundToInt(internalIncrease * MultiplierUpgrade.cookieMultiplier);
            GlobalCookies.cookieCount += internalIncrease;
        }
        StartCoroutine(CreateTheCookie());
    }
}