using UnityEngine;
using TMPro;

public class GlobalShop : MonoBehaviour
{
    public GameObject realShopButton;
    public GameObject realShopText;
    public GameObject fakeShopButton;
    public GameObject fakeShopText;
    
    public GameObject realAdvertisementButton;
    public GameObject realAdvertisementText;
    public GameObject fakeAdvertisementButton;
    public GameObject fakeAdvertisementText;
    
    public GameObject realOnlineStoreButton;
    public GameObject realOnlineStoreText;
    public GameObject fakeOnlineStoreButton;
    public GameObject fakeOnlineStoreText;
    
    public GameObject realBrokerButton;
    public GameObject realBrokerText;
    public GameObject fakeBrokerButton;
    public GameObject fakeBrokerText;
    
    public GameObject realBoutiqueButton;
    public GameObject realBoutiqueText;
    public GameObject fakeBoutiqueButton;
    public GameObject fakeBoutiqueText;
    
    public GameObject realCorporationButton;
    public GameObject realCorporationText;
    public GameObject fakeCorporationButton;
    public GameObject fakeCorporationText;

    public int currentCash;
    public static int shopValue = 30;
    public static int advertisementValue = 300;
    public static int onlineStoreValue = 500;
    public static int brokerValue = 1000;
    public static int boutiqueValue = 2800;
    public static int corporationValue = 12000;
    
    public static int shopPerSec;
    
    public static int numberOfShops;
    public static int numberOfAdvertisements;
    public static int numberOfOnlineStores;
    public static int numberOfBrokers;
    public static int numberOfBoutiques;
    public static int numberOfCorporations;

    void Update()
    {
        currentCash = GlobalCash.cashCount;
        
        realShopText.GetComponent<TextMeshProUGUI>().text = "Shop - $" + shopValue + " (1/s)" + " (" + numberOfShops + ")";
        fakeShopText.GetComponent<TextMeshProUGUI>().text = "Shop - $" + shopValue + " (1/s)" + " (" + numberOfShops + ")";
        
        if (currentCash >= shopValue)
        {
            fakeShopButton.SetActive(false);
            realShopButton.SetActive(true);
        }
        else
        {
            fakeShopButton.SetActive(true);
            realShopButton.SetActive(false);
        }
        
        realAdvertisementText.GetComponent<TextMeshProUGUI>().text = "Advertisement - $" + advertisementValue
            + " (5/s)" + " (" + numberOfAdvertisements + ")";
        fakeAdvertisementText.GetComponent<TextMeshProUGUI>().text = "Advertisement - $" + advertisementValue
            + " (5/s)" + " (" + numberOfAdvertisements + ")";
        
        if (currentCash >= advertisementValue)
        {
            fakeAdvertisementButton.SetActive(false);
            realAdvertisementButton.SetActive(true);
        }
        else
        {
            fakeAdvertisementButton.SetActive(true);
            realAdvertisementButton.SetActive(false);
        }
        
        realOnlineStoreText.GetComponent<TextMeshProUGUI>().text = "Online store - $" + onlineStoreValue
            + " (10/s)" + " (" + numberOfOnlineStores + ")";
        fakeOnlineStoreText.GetComponent<TextMeshProUGUI>().text = "Online store - $" + onlineStoreValue
            + " (10/s)" + " (" + numberOfOnlineStores + ")";
        
        if (currentCash >= onlineStoreValue)
        {
            fakeOnlineStoreButton.SetActive(false);
            realOnlineStoreButton.SetActive(true);
        }
        else
        {
            fakeOnlineStoreButton.SetActive(true);
            realOnlineStoreButton.SetActive(false);
        }
        
        realBrokerText.GetComponent<TextMeshProUGUI>().text = "Broker - $" + brokerValue + " (30/s)" + " (" + numberOfBrokers + ")";
        fakeBrokerText.GetComponent<TextMeshProUGUI>().text = "Broker - $" + brokerValue + " (30/s)" + " (" + numberOfBrokers + ")";
        
        if (currentCash >= brokerValue)
        {
            fakeBrokerButton.SetActive(false);
            realBrokerButton.SetActive(true);
        }
        else
        {
            fakeBrokerButton.SetActive(true);
            realBrokerButton.SetActive(false);
        }
        
        realBoutiqueText.GetComponent<TextMeshProUGUI>().text = "Cookie boutique - $" + boutiqueValue + " (80/s)" + " (" + numberOfBoutiques + ")";
        fakeBoutiqueText.GetComponent<TextMeshProUGUI>().text = "Cookie boutique - $" + boutiqueValue + " (80/s)" + " (" + numberOfBoutiques + ")";
        
        if (currentCash >= boutiqueValue)
        {
            fakeBoutiqueButton.SetActive(false);
            realBoutiqueButton.SetActive(true);
        }
        else
        {
            fakeBoutiqueButton.SetActive(true);
            realBoutiqueButton.SetActive(false);
        }
        
        realCorporationText.GetComponent<TextMeshProUGUI>().text = "Cookie corporation - $" + corporationValue + " (300/s)" + " (" + numberOfCorporations + ")";
        fakeCorporationText.GetComponent<TextMeshProUGUI>().text = "Cookie corporation - $" + corporationValue + " (300/s)" + " (" + numberOfCorporations + ")";
        
        if (currentCash >= corporationValue)
        {
            fakeCorporationButton.SetActive(false);
            realCorporationButton.SetActive(true);
        }
        else
        {
            fakeCorporationButton.SetActive(true);
            realCorporationButton.SetActive(false);
        }
    }
}