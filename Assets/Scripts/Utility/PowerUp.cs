using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    private float waitTime = 5f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && !other.isTrigger)
        {
            PlayerMovement playerMovement = other.gameObject.GetComponent<PlayerMovement>();

            playerMovement.isPowerUp = true;

            Destroy(gameObject);
        }
    }
}
