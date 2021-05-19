using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heal : MonoBehaviour
{
    private int point = 50;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && !other.isTrigger)
        {
            PlayerHealth playerHealth = other.gameObject.GetComponent<PlayerHealth>();

            playerHealth.Heal(this, point);
        }
    }
}
