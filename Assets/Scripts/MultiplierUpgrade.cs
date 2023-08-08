using UnityEngine;
using TMPro;

public class MultiplierUpgrade : MonoBehaviour
{
    [SerializeField] private GameObject cookieMultiplierButton;
    [SerializeField] private GameObject cookieMultiplierButtonText;
    [SerializeField] private GameObject fakeCookieMultiplierButton;
    [SerializeField] private GameObject fakeCookieMultiplierButtonText;
    
    [SerializeField] private GameObject cashMultiplierButton;
    [SerializeField] private GameObject cashMultiplierButtonText;
    [SerializeField] private GameObject fakeCashMultiplierButton;
    [SerializeField] private GameObject fakeCashMultiplierButtonText;
    
    [SerializeField] private AudioSource upgradeSound;
    
    public static float cookieMultiplier = 1;
    public static float cashMultiplier = 1;
    
    public static int cookieMultiplierCost = 1500;
    public static int cashMultiplierCost = 2000;
    
    private float _valueMultiplier = 2f;
    
    public void Update()
    {
        cookieMultiplierButtonText.GetComponent<TextMeshProUGUI>().text = "Buy better flour - $" + cookieMultiplierCost
            + " (+10% Cookies/sec)" + " (" + cookieMultiplier + "0%)";
        fakeCookieMultiplierButtonText.GetComponent<TextMeshProUGUI>().text = "Buy better flour - $" + cookieMultiplierCost
            + " (+10% Cookies/sec)" + " (" + cookieMultiplier + "0%)";
        
        if (GlobalCash.cashCount >= cookieMultiplierCost)
        {
            fakeCookieMultiplierButton.SetActive(false);
            cookieMultiplierButton.SetActive(true);
        }
        else
        {
            fakeCookieMultiplierButton.SetActive(true);
            cookieMultiplierButton.SetActive(false);
        }
        
        cashMultiplierButtonText.GetComponent<TextMeshProUGUI>().text = "Issue new shares - $" + cashMultiplierCost
            + " (+10% Cash/sec)" + " (" + cashMultiplier + "0%)";
        fakeCashMultiplierButtonText.GetComponent<TextMeshProUGUI>().text = "Issue new shares - $" + cashMultiplierCost
            + " (+10% Cash/sec)" + " (" + cashMultiplier + "0%)";
        
        if (GlobalCash.cashCount >= cashMultiplierCost)
        {
            fakeCashMultiplierButton.SetActive(false);
            cashMultiplierButton.SetActive(true);
        }
        else
        {
            fakeCashMultiplierButton.SetActive(true);
            cashMultiplierButton.SetActive(false);
        }
    }
    
    public void UpgradeCookieMultiplier()
    {
        upgradeSound.Play();
        GlobalCash.cashCount -= cookieMultiplierCost;
        cookieMultiplierCost = Mathf.RoundToInt(cookieMultiplierCost * _valueMultiplier);

        cookieMultiplier += 0.1f;
    }
    
    public void UpgradeCashMultiplier()
    {
        upgradeSound.Play();
        GlobalCash.cashCount -= cashMultiplierCost;
        cashMultiplierCost = Mathf.RoundToInt(cashMultiplierCost * _valueMultiplier);

        cashMultiplier += 0.1f;
    }
}