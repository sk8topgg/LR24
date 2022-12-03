using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiamondInstantiator : MonoBehaviour
{
    Transform[] childTransform;
    public GameObject DiamondPrefab;
    void Awake()
    {
        childTransform = new Transform[transform.childCount];
        for (int i = 0; i < childTransform.Length; i++)
        {
            childTransform[i] = transform.GetChild(i);
        }
        InstantiateDiamond();
    }

    void Update()
    {
        
    }
    void InstantiateDiamond()
    {
        for (int i = 0; i < childTransform.Length; i++)
        {
            if(Random.value > 0.4f)
            {
                Instantiate(DiamondPrefab, childTransform[i].position, Quaternion.identity);
            }
        }
    }
}
