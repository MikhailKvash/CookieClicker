using TMPro;
using UnityEngine;

public class GlobalCookies : MonoBehaviour
{
    public static int cookieCount;
    public GameObject cookieDisplay;
    public int internalCookie;

    // Ведёт общий счётчик печенья
    void Update()
    {
        internalCookie = cookieCount;
        cookieDisplay.GetComponent<TextMeshProUGUI>().text = "Cookies: " + internalCookie;
    }
}