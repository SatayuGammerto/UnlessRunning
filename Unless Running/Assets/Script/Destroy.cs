using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    [SerializeField] private int destroyTime;
    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, destroyTime);
        
    }

}
