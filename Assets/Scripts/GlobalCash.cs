using TMPro;
using UnityEngine;

public class GlobalCash : MonoBehaviour
{
    public static int cashCount;
    public GameObject cashDisplay;
    public int internalCash;

    // Ведёт общий счётчик денег
    void Update()
    {
        internalCash = cashCount;
        cashDisplay.GetComponent<TextMeshProUGUI>().text = "$: " + internalCash;
    }
}