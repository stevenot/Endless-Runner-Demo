using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GenerateLevel generateLevel;
    private void OnTriggerEnter(Collider other)
    {
        generateLevel.GenerateSection();
        Destroy(transform.parent.gameObject, 2f);
    }
}
