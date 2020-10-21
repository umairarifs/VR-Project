using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timer : MonoBehaviour
{
      private float time; 
    void Update()
    {
        time += Time.deltaTime;
        Debug.Log(time);
    }

}
