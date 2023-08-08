using TMPro;
using UnityEngine;

public class SellCookie : MonoBehaviour
{
    public GameObject statusText;

    public AudioSource cashSoundOne;
    public AudioSource cashSoundTwo;
    public int generateTone;

    public AudioSource noCookie;
    
    public void ClickTheButton()
    {
        generateTone = Random.Range(1, 3);
        if (GlobalCookies.cookieCount == 0)
        {
            noCookie.Play();
            statusText.GetComponent<TextMeshProUGUI>().text = "Not enought cookies to sell.";
            statusText.GetComponent<Animation>().Play("StatusAnim");
        }
        else
        {
            if (generateTone == 1)
            {
                cashSoundOne.Play();
            }
            else
            {
                cashSoundTwo.Play();
            }

            if (GlobalCookies.cookieCount >= MainButtonClick.clickerLevel)
            {
                GlobalCookies.cookieCount -= MainButtonClick.clickerLevel;
                GlobalCash.cashCount += MainButtonClick.clickerLevel;
            }
            else
            {
                GlobalCash.cashCount += GlobalCookies.cookieCount;
                GlobalCookies.cookieCount = 0;
            }
            
        }   
    }
}