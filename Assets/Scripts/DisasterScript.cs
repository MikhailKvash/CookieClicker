using System.Collections;
using TMPro;
using UnityEngine;

public class DisasterScript : MonoBehaviour
{
    public GameObject statusBox;
    public float cookieCheck;
    public int genChance;
    public bool disasterActive;
    public int cookieLoss;
    
    void Update()
    {
        cookieCheck = GlobalCookies.cookieCount / 20;
        if(disasterActive == false)
        {
            StartCoroutine(StartDisaster());
        }
    }

    IEnumerator StartDisaster()
    {
        disasterActive = true;
        genChance = Random.Range(1, 10);
        if (cookieCheck >= genChance)
        {
            cookieLoss = Mathf.RoundToInt(GlobalCookies.cookieCount * 0.15f);
            statusBox.GetComponent<TextMeshProUGUI>().text = "You lost " + cookieLoss + " cookies in a factory fire!";
            GlobalCookies.cookieCount -= cookieLoss;
            yield return new WaitForSeconds(3);
            statusBox.GetComponent<Animation>().Play("StatusAnim");
            yield return new WaitForSeconds(1);
            statusBox.SetActive(false);
            statusBox.SetActive(true);
        }
        yield return new WaitForSeconds(30);
        disasterActive = false;
    }
}
