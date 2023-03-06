using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoins : MonoBehaviour
{


     private void OnTriggerEnter (Collider other)
     {
        if(other.gameObject.CompareTag("Coins"))
        {
            Destroy(other.gameObject);
        }
     }
}
