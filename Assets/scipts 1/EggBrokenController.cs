using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggBrokenController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject,0.1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
