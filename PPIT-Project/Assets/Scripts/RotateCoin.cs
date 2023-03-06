using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCoin : MonoBehaviour
{
    [SerializeField] float speedY;
    [SerializeField] float speedx;
    [SerializeField] float speedz;
 

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(360 * speedx * Time.deltaTime,360 * speedY * Time.deltaTime,360 * speedz * Time.deltaTime);
    }
}
