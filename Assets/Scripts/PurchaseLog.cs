using UnityEngine;

public class PurchaseLog : MonoBehaviour
{
    public AudioSource playSound;
    
    float valueMultiplier = 1.15f;

    [SerializeField] private float bakerValueMultiplier;
    [SerializeField] private float farmValueMultiplier;
    [SerializeField] private float factoryValueMultiplier;
    [SerializeField] private float grandmaValueMultiplier;
    [SerializeField] private float franchiseValueMultiplier;
    [SerializeField] private float portalValueMultiplier;
    
    [SerializeField] private float shopValueMultiplier;
    [SerializeField] private float advertisementValueMultiplier;
    [SerializeField] private float onlineStoreValueMultiplier;
    [SerializeField] private float brokerValueMultiplier;
    [SerializeField] private float boutiqueValueMultiplier;
    [SerializeField] private float corporationValueMultiplier;

    private void Update()
    {
        bakerValueMultiplier = valueMultiplier + GlobalBaker.numberOfBakers * 0.03f;
        farmValueMultiplier = valueMultiplier + GlobalBaker.numberOfFarms * 0.03f;
        factoryValueMultiplier = valueMultiplier + GlobalBaker.numberOfFactories * 0.03f;
        grandmaValueMultiplier = valueMultiplier + GlobalBaker.numberOfGrandmas * 0.03f;
        franchiseValueMultiplier = valueMultiplier + GlobalBaker.numberOfFranchises * 0.03f;
        portalValueMultiplier = valueMultiplier + GlobalBaker.numberOfPortals * 0.03f;
        
        shopValueMultiplier = valueMultiplier + GlobalShop.numberOfShops * 0.03f;
        advertisementValueMultiplier = valueMultiplier + GlobalShop.numberOfAdvertisements * 0.03f;
        onlineStoreValueMultiplier = valueMultiplier + GlobalShop.numberOfOnlineStores * 0.03f;
        brokerValueMultiplier = valueMultiplier + GlobalShop.numberOfBrokers * 0.03f;
        boutiqueValueMultiplier = valueMultiplier + GlobalShop.numberOfBoutiques * 0.03f;
        corporationValueMultiplier = valueMultiplier + GlobalShop.numberOfCorporations * 0.03f;
    }

    public void BuyBaker()
    {
        playSound.Play();
        GlobalCash.cashCount -= GlobalBaker.bakerValue;
        GlobalBaker.bakerValue = (int)(GlobalBaker.bakerValue * bakerValueMultiplier);
        
        GlobalBaker.bakePerSec += 1;
        GlobalBaker.numberOfBakers += 1;
    }
    
    public void BuyFarm()
    {
        playSound.Play();
        GlobalCash.cashCount -= GlobalBaker.farmValue;
        GlobalBaker.farmValue = (int)(GlobalBaker.farmValue * farmValueMultiplier);
        
        GlobalBaker.bakePerSec += 5;
        GlobalBaker.numberOfFarms += 1;
    }
    
    public void BuyFactory()
    {
        playSound.Play();
        GlobalCash.cashCount -= GlobalBaker.factoryValue;
        GlobalBaker.factoryValue = (int)(GlobalBaker.factoryValue * factoryValueMultiplier);
        
        GlobalBaker.bakePerSec += 10;
        GlobalBaker.numberOfFactories += 1;
    }
    
    public void BuyGrandma()
    {
        playSound.Play();
        GlobalCash.cashCount -= GlobalBaker.grandmaValue;
        GlobalBaker.grandmaValue = (int)(GlobalBaker.grandmaValue * grandmaValueMultiplier);
        
        GlobalBaker.bakePerSec += 30;
        GlobalBaker.numberOfGrandmas += 1;
    }
    
    public void BuyFranchise()
    {
        playSound.Play();
        GlobalCash.cashCount -= GlobalBaker.franchiseValue;
        GlobalBaker.franchiseValue = (int)(GlobalBaker.franchiseValue * franchiseValueMultiplier);
        
        GlobalBaker.bakePerSec += 80;
        GlobalBaker.numberOfFranchises += 1;
    }
    
    public void BuyPortal()
    {
        playSound.Play();
        GlobalCash.cashCount -= GlobalBaker.portalValue;
        GlobalBaker.portalValue = (int)(GlobalBaker.portalValue * portalValueMultiplier);
        
        GlobalBaker.bakePerSec += 300;
        GlobalBaker.numberOfPortals += 1;
    }
    
    public void BuyShop()
    {
        playSound.Play();
        GlobalCash.cashCount -= GlobalShop.shopValue;
        GlobalShop.shopValue = (int)(GlobalShop.shopValue * shopValueMultiplier);

        GlobalShop.shopPerSec += 1;
        GlobalShop.numberOfShops += 1;
    }
    
    public void BuyAdvertisement()
    {
        playSound.Play();
        GlobalCash.cashCount -= GlobalShop.advertisementValue;
        GlobalShop.advertisementValue = (int)(GlobalShop.advertisementValue * advertisementValueMultiplier);

        GlobalShop.shopPerSec += 5;
        GlobalShop.numberOfAdvertisements += 1;
    }
    
    public void BuyOnlineStore()
    {
        playSound.Play();
        GlobalCash.cashCount -= GlobalShop.onlineStoreValue;
        GlobalShop.onlineStoreValue = (int)(GlobalShop.onlineStoreValue * onlineStoreValueMultiplier);

        GlobalShop.shopPerSec += 10;
        GlobalShop.numberOfOnlineStores += 1;
    }
    
    public void BuyBroker()
    {
        playSound.Play();
        GlobalCash.cashCount -= GlobalShop.brokerValue;
        GlobalShop.brokerValue = (int)(GlobalShop.brokerValue * brokerValueMultiplier);

        GlobalShop.shopPerSec += 30;
        GlobalShop.numberOfBrokers += 1;
    }
    
    public void BuyBoutique()
    {
        playSound.Play();
        GlobalCash.cashCount -= GlobalShop.boutiqueValue;
        GlobalShop.boutiqueValue = (int)(GlobalShop.boutiqueValue * boutiqueValueMultiplier);

        GlobalShop.shopPerSec += 80;
        GlobalShop.numberOfBoutiques += 1;
    }
    
    public void BuyCorporation()
    {
        playSound.Play();
        GlobalCash.cashCount -= GlobalShop.corporationValue;
        GlobalShop.corporationValue = (int)(GlobalShop.corporationValue * corporationValueMultiplier);

        GlobalShop.shopPerSec += 300;
        GlobalShop.numberOfCorporations += 1;
    }
}
