using UnityEngine;
using TMPro;

public class MainButtonClick : MonoBehaviour
{
    [SerializeField] private GameObject clickButton;
    [SerializeField] private GameObject clickButtonText;
    [SerializeField] private GameObject fakeClickButton;
    [SerializeField] private GameObject fakeClickButtonText;
    
    [SerializeField] private AudioSource cookieSound;
    [SerializeField] private AudioSource upgradeSound;

    public static int clickerLevel = 1;
    public static int clickerCost = 50;
    private float _clickerMultiplier = 1.07f;

    public void Update()
    {
        clickButtonText.GetComponent<TextMeshProUGUI>().text = "Upgrade Click - $" + clickerCost
            + " (+1 Cookie/$ per click)" + " (" + clickerLevel + ")";
        fakeClickButtonText.GetComponent<TextMeshProUGUI>().text = "Upgrade Click - $" + clickerCost
            + " (+1 Cookie/$ per click)" + " (" + clickerLevel + ")";
        
        if (GlobalCash.cashCount >= clickerCost)
        {
            fakeClickButton.SetActive(false);
            clickButton.SetActive(true);
        }
        else
        {
            fakeClickButton.SetActive(true);
            clickButton.SetActive(false);
        }
    }

    public void ClickTheButton()
    {
        cookieSound.Play();
        GlobalCookies.cookieCount += clickerLevel;
    }

    public void UpgradeTheCookieClick()
    {
        upgradeSound.Play();
        GlobalCash.cashCount -= clickerCost;
        clickerCost = (int)(clickerCost * _clickerMultiplier) * clickerLevel;

        clickerLevel += 1;
    }
}