using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoin : MonoBehaviour
{
    public AudioSource coinFx;
    private void OnTriggerEnter(Collider other)
    {
        coinFx.Play();
        CoinsGathered.UpdateCoinsCollected();
        gameObject.SetActive(false);
    }
}
