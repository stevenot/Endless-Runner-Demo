using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateLevel : MonoBehaviour
{
    public GameObject[] section;
    public int intialSections = 2;
    public int zPos = 20;
    private int secNum; 

    public void GenerateSection()
    {
        secNum = Random.Range(0, 10);
        GameObject clonedSection = Instantiate(section[secNum], new Vector3(0, 0, zPos), Quaternion.identity);
        zPos += 20;
}
    void Start()
    {
        //Create a few sections show that the player does not see empty space.
        for (int i = 0; i < intialSections; ++i)
        {
            GenerateSection();
        }
    }
}
