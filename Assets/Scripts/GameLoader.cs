using UnityEngine;

public class GameLoader : MonoBehaviour
{
    public int savedCookies;
    public int savedCash;

    public int savedClickerLevel;
    public int savedClickerCost;

    public float savedCookieMultiplier;
    public int savedCookieMultiplierCost;
    public float savedCashMultiplier;
    public int savedCashMultiplierCost;

    public int savedBakePerSec;
    public int savedBakers;
    public int savedBakerValue;
    public int savedFarms;
    public int savedFarmValue;
    public int savedFactories;
    public int savedFactoryValue;
    public int savedGrandmas;
    public int savedGrandmaValue;
    public int savedFranchises;
    public int savedFranchiseValue;
    public int savedPortals;
    public int savedPortalValue;
    
    public int savedShopPerSec;
    public int savedShops;
    public int savedShopValue;
    public int savedAdvertisements;
    public int savedAdvertisementValue;
    public int savedOnlineStores;
    public int savedOnlineStoreValue;
    public int savedBrokers;
    public int savedBrokerValue;
    public int savedBoutiques;
    public int savedBoutiqueValue;
    public int savedCorporations;
    public int savedCorporationValue;

    public int saveValue;
    
    void Start()
    {
        if (MainMenuOptions.isLoading)
        {
            savedCookies = PlayerPrefs.GetInt("SavedCookies");
            GlobalCookies.cookieCount = savedCookies;
            savedCash = PlayerPrefs.GetInt("SavedCash");
            GlobalCash.cashCount = savedCash;
            
            savedClickerLevel = PlayerPrefs.GetInt("SavedClickerLevel");
            MainButtonClick.clickerLevel = savedClickerLevel;
            savedClickerCost = PlayerPrefs.GetInt("SavedClickerValue");
            MainButtonClick.clickerCost = savedClickerCost;
            
            savedCookieMultiplier = PlayerPrefs.GetFloat("SavedCookieMultiplier");
            MultiplierUpgrade.cookieMultiplier = savedCookieMultiplier;
            savedCookieMultiplierCost = PlayerPrefs.GetInt("SavedCookieMultiplierValue");
            MultiplierUpgrade.cookieMultiplierCost = savedCookieMultiplierCost;
            savedCashMultiplier = PlayerPrefs.GetFloat("SavedCashMultiplier");
            MultiplierUpgrade.cashMultiplier = savedCashMultiplier;
            savedCashMultiplierCost = PlayerPrefs.GetInt("SavedCashMultiplierValue");
            MultiplierUpgrade.cashMultiplierCost = savedCashMultiplierCost;
            
            savedBakePerSec = PlayerPrefs.GetInt("SavedBakePerSec");
            GlobalBaker.bakePerSec = savedBakePerSec;
            savedBakers = PlayerPrefs.GetInt("SavedBakers");
            GlobalBaker.numberOfBakers = savedBakers;
            savedBakerValue = PlayerPrefs.GetInt("SavedBakerValue");
            GlobalBaker.bakerValue = savedBakerValue;
            savedFarms = PlayerPrefs.GetInt("SavedFarms");
            GlobalBaker.numberOfFarms = savedFarms;
            savedFarmValue = PlayerPrefs.GetInt("SavedFarmValue");
            GlobalBaker.farmValue = savedFarmValue;
            savedFactories = PlayerPrefs.GetInt("SavedFactories");
            GlobalBaker.numberOfFactories = savedFactories;
            savedFactoryValue = PlayerPrefs.GetInt("SavedFactoryValue");
            GlobalBaker.factoryValue = savedFactoryValue;
            savedGrandmas = PlayerPrefs.GetInt("SavedGrandmas");
            GlobalBaker.numberOfGrandmas = savedGrandmas;
            savedGrandmaValue = PlayerPrefs.GetInt("SavedGrandmaValue");
            GlobalBaker.grandmaValue = savedGrandmaValue;
            savedFranchises = PlayerPrefs.GetInt("SavedFranchises");
            GlobalBaker.numberOfFranchises = savedFranchises;
            savedFranchiseValue = PlayerPrefs.GetInt("SavedFranchiseValue");
            GlobalBaker.franchiseValue = savedFranchiseValue;
            savedPortals = PlayerPrefs.GetInt("SavedPortals");
            GlobalBaker.numberOfPortals = savedPortals;
            savedPortalValue = PlayerPrefs.GetInt("SavedPortalValue");
            GlobalBaker.portalValue = savedPortalValue;
            
            savedShopPerSec = PlayerPrefs.GetInt("SavedShopPerSec");
            GlobalShop.shopPerSec = savedShopPerSec;
            savedShops = PlayerPrefs.GetInt("SavedShops");
            GlobalShop.numberOfShops = savedShops;
            savedShopValue = PlayerPrefs.GetInt("SavedShopValue");
            GlobalShop.shopValue = savedShopValue;
            savedShops = PlayerPrefs.GetInt("SavedAdvertisements");
            GlobalShop.numberOfAdvertisements = savedAdvertisements;
            savedAdvertisementValue = PlayerPrefs.GetInt("SavedAdvertisementValue");
            GlobalShop.advertisementValue = savedAdvertisementValue;
            savedOnlineStores = PlayerPrefs.GetInt("SavedOnlineStores");
            GlobalShop.numberOfOnlineStores = savedOnlineStores;
            savedOnlineStoreValue = PlayerPrefs.GetInt("SavedOnlineStoreValue");
            GlobalShop.onlineStoreValue = savedOnlineStoreValue;
            savedBrokers = PlayerPrefs.GetInt("SavedBrokers");
            GlobalShop.numberOfBrokers = savedBrokers;
            savedBrokerValue = PlayerPrefs.GetInt("SavedBrokerValue");
            GlobalShop.brokerValue = savedBrokerValue;
            savedBoutiques = PlayerPrefs.GetInt("SavedBoutiques");
            GlobalShop.numberOfBoutiques = savedBoutiques;
            savedBoutiqueValue = PlayerPrefs.GetInt("SavedBoutiqueValue");
            GlobalShop.boutiqueValue = savedBoutiqueValue;
            savedCorporations = PlayerPrefs.GetInt("SavedCorporations");
            GlobalShop.numberOfCorporations = savedCorporations;
            savedCorporationValue = PlayerPrefs.GetInt("SavedCorporationValue");
            GlobalShop.corporationValue = savedCorporationValue;
            
            saveValue = PlayerPrefs.GetInt("SaveValue");
            SaveGame.saveValue = saveValue;
        }
    }
}
