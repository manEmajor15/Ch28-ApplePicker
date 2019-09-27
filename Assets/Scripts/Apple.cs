using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{

    public static float bottomY = -20f;
    int count; //counter since position tracking isn't working
    // Start is called before the first frame update
    void Start()
    {
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        count++;
        if (count > 600)  // Keep getting error that the object is already destroyed so no apples spawn
         {
             Destroy(this.gameObject);
         }
    }
}
