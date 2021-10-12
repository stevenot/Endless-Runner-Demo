using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinsGathered : MonoBehaviour
{
    public Text coins;
    private static int count = 0;
   
    public static void UpdateCoinsCollected()
    {
        ++count;
        GameObject.FindObjectOfType<CoinsGathered>().UpdateCoinsText();
    }

    private void UpdateCoinsText()
    {
        coins.text = count.ToString();
    }
}
