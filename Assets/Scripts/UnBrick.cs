using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnBrick : MonoBehaviour
{
    public GameObject brick;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            brick.SetActive(true);
        }
    }
}
