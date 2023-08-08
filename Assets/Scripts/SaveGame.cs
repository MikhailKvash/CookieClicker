using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SaveGame : MonoBehaviour
{
    [SerializeField] private GameObject saveButton;
    [SerializeField] private GameObject saveText;
    
    public int saveGameCash;
    public static int saveValue = 10;

    private void Update()
    {
        saveGameCash = GlobalCash.cashCount;
        saveText.GetComponent<TextMeshProUGUI>().text = "Cost: $" + saveValue;

        if (saveGameCash >= saveValue)
        {
            saveButton.GetComponent<Button>().interactable = true;
        }
        else
        {
            saveButton.GetComponent<Button>().interactable = false;
        }
    }

    public void SaveTheGame()
    {
        GlobalCash.cashCount -= saveValue;

        PlayerPrefs.SetInt("SavedCookies", GlobalCookies.cookieCount);
        PlayerPrefs.SetInt("SavedCash", GlobalCash.cashCount);
        
        PlayerPrefs.SetInt("SavedClickerLevel", MainButtonClick.clickerLevel);
        PlayerPrefs.SetInt("SavedClickerValue", MainButtonClick.clickerCost);
        
        PlayerPrefs.SetFloat("SavedCookieMultiplier", MultiplierUpgrade.cookieMultiplier);
        PlayerPrefs.SetInt("SavedCookieMultiplierValue", MultiplierUpgrade.cookieMultiplierCost);
        PlayerPrefs.SetFloat("SavedCashMultiplier", MultiplierUpgrade.cashMultiplier);
        PlayerPrefs.SetInt("SavedCashMultiplierValue", MultiplierUpgrade.cashMultiplierCost);
        
        PlayerPrefs.SetInt("SavedBakePerSec", GlobalBaker.bakePerSec);
        PlayerPrefs.SetInt("SavedBakers", GlobalBaker.numberOfBakers);
        PlayerPrefs.SetInt("SavedBakerValue", GlobalBaker.bakerValue);
        PlayerPrefs.SetInt("SavedFarms", GlobalBaker.numberOfFarms);
        PlayerPrefs.SetInt("SavedFarmValue", GlobalBaker.farmValue);
        PlayerPrefs.SetInt("SavedFactories", GlobalBaker.numberOfFactories);
        PlayerPrefs.SetInt("SavedFactoryValue", GlobalBaker.factoryValue);
        PlayerPrefs.SetInt("SavedGrandmas", GlobalBaker.numberOfGrandmas);
        PlayerPrefs.SetInt("SavedGrandmaValue", GlobalBaker.grandmaValue);
        PlayerPrefs.SetInt("SavedFranchises", GlobalBaker.numberOfFranchises);
        PlayerPrefs.SetInt("SavedFranchiseValue", GlobalBaker.franchiseValue);
        PlayerPrefs.SetInt("SavedPortals", GlobalBaker.numberOfPortals);
        PlayerPrefs.SetInt("SavedPortalValue", GlobalBaker.portalValue);
        
        PlayerPrefs.SetInt("SavedShopPerSec", GlobalShop.shopPerSec);
        PlayerPrefs.SetInt("SavedShops", GlobalShop.numberOfShops);
        PlayerPrefs.SetInt("SavedShopValue", GlobalShop.shopValue);
        PlayerPrefs.SetInt("SavedAdvertisements", GlobalShop.numberOfAdvertisements);
        PlayerPrefs.SetInt("SavedAdvertisementValue", GlobalShop.advertisementValue);
        PlayerPrefs.SetInt("SavedOnlineStores", GlobalShop.numberOfOnlineStores);
        PlayerPrefs.SetInt("SavedOnlineStoreValue", GlobalShop.onlineStoreValue);
        PlayerPrefs.SetInt("SavedBrokers", GlobalShop.numberOfBrokers);
        PlayerPrefs.SetInt("SavedBrokerValue", GlobalShop.brokerValue);
        PlayerPrefs.SetInt("SavedBoutiques", GlobalShop.numberOfBoutiques);
        PlayerPrefs.SetInt("SavedBoutiqueValue", GlobalShop.boutiqueValue);
        PlayerPrefs.SetInt("SavedCorporations", GlobalShop.numberOfCorporations);
        PlayerPrefs.SetInt("SavedCorporationValue", GlobalShop.corporationValue);
        
        saveValue *= 2;
        PlayerPrefs.SetInt("SaveValue", saveValue);
    }
}
