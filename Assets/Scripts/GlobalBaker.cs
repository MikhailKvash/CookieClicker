using UnityEngine;
using TMPro;

public class GlobalBaker : MonoBehaviour
{
    public GameObject realBakerButton;
    public GameObject realBakerText;
    public GameObject fakeBakerButton;
    public GameObject fakeBakerText;
    
    public GameObject realFarmButton;
    public GameObject realFarmText;
    public GameObject fakeFarmButton;
    public GameObject fakeFarmText;
    
    public GameObject realFactoryButton;
    public GameObject realFactoryText;
    public GameObject fakeFactoryButton;
    public GameObject fakeFactoryText;
    
    public GameObject realGrandmaButton;
    public GameObject realGrandmaText;
    public GameObject fakeGrandmaButton;
    public GameObject fakeGrandmaText;
    
    public GameObject realFranchiseButton;
    public GameObject realFranchiseText;
    public GameObject fakeFranchiseButton;
    public GameObject fakeFranchiseText;
    
    public GameObject realPortalButton;
    public GameObject realPortalText;
    public GameObject fakePortalButton;
    public GameObject fakePortalText;

    public int currentCash;
    public static int bakerValue = 20;
    public static int farmValue = 250;
    public static int factoryValue = 400;
    public static int grandmaValue = 900;
    public static int franchiseValue = 2400;
    public static int portalValue = 9000;
    
    public static int bakePerSec;
    
    public static int numberOfBakers;
    public static int numberOfFarms;
    public static int numberOfFactories;
    public static int numberOfGrandmas;
    public static int numberOfFranchises;
    public static int numberOfPortals;
    
    void Update()
    {
        currentCash = GlobalCash.cashCount;

        realBakerText.GetComponent<TextMeshProUGUI>().text = "Baker - $" + bakerValue + " (1/s)" + " (" + numberOfBakers + ")";;
        fakeBakerText.GetComponent<TextMeshProUGUI>().text = "Baker - $" + bakerValue + " (1/s)" + " (" + numberOfBakers + ")";;

        if (currentCash >= bakerValue)
        {
            fakeBakerButton.SetActive(false);
            realBakerButton.SetActive(true);
        }
        else
        {
            fakeBakerButton.SetActive(true);
            realBakerButton.SetActive(false);
        }
        
        realFarmText.GetComponent<TextMeshProUGUI>().text = "Farm - $" + farmValue + " (5/s)" + " (" + numberOfFarms + ")";;
        fakeFarmText.GetComponent<TextMeshProUGUI>().text = "Farm - $" + farmValue + " (5/s)" + " (" + numberOfFarms + ")";;

        if (currentCash >= farmValue)
        {
            fakeFarmButton.SetActive(false);
            realFarmButton.SetActive(true);
        }
        else
        {
            fakeFarmButton.SetActive(true);
            realFarmButton.SetActive(false);
        }
        
        realFactoryText.GetComponent<TextMeshProUGUI>().text = "Factory - $" + factoryValue + " (10/s)" + " (" + numberOfFactories + ")";;
        fakeFactoryText.GetComponent<TextMeshProUGUI>().text = "Factory - $" + factoryValue + " (10/s)" + " (" + numberOfFactories + ")";;

        if (currentCash >= factoryValue)
        {
            fakeFactoryButton.SetActive(false);
            realFactoryButton.SetActive(true);
        }
        else
        {
            fakeFactoryButton.SetActive(true);
            realFactoryButton.SetActive(false);
        }
        
        realGrandmaText.GetComponent<TextMeshProUGUI>().text = "Grandma - $" + grandmaValue + " (30/s)" + " (" + numberOfGrandmas + ")";;
        fakeGrandmaText.GetComponent<TextMeshProUGUI>().text = "Grandma - $" + grandmaValue + " (30/s)" + " (" + numberOfGrandmas + ")";;

        if (currentCash >= grandmaValue)
        {
            fakeGrandmaButton.SetActive(false);
            realGrandmaButton.SetActive(true);
        }
        else
        {
            fakeGrandmaButton.SetActive(true);
            realGrandmaButton.SetActive(false);
        }
        
        realFranchiseText.GetComponent<TextMeshProUGUI>().text = "Franchise - $" + franchiseValue + " (80/s)" + " (" + numberOfFranchises + ")";;
        fakeFranchiseText.GetComponent<TextMeshProUGUI>().text = "Franchise - $" + franchiseValue + " (80/s)" + " (" + numberOfFranchises + ")";;

        if (currentCash >= franchiseValue)
        {
            fakeFranchiseButton.SetActive(false);
            realFranchiseButton.SetActive(true);
        }
        else
        {
            fakeFranchiseButton.SetActive(true);
            realFranchiseButton.SetActive(false);
        }
        
        realPortalText.GetComponent<TextMeshProUGUI>().text = "Cookie portal - $" + portalValue + " (300/s)" + " (" + numberOfPortals + ")";;
        fakePortalText.GetComponent<TextMeshProUGUI>().text = "Cookie portal - $" + portalValue + " (300/s)" + " (" + numberOfPortals + ")";;

        if (currentCash >= portalValue)
        {
            fakePortalButton.SetActive(false);
            realPortalButton.SetActive(true);
        }
        else
        {
            fakePortalButton.SetActive(true);
            realPortalButton.SetActive(false);
        }
    }
}
