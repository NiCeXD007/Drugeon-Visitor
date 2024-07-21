using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    public GameObject playerPrefab;  

    [Button("Add Character", ButtonSizes.Large)]
    void AddCharacter()
    {
        if (playerPrefab != null)
        {
            Instantiate(playerPrefab, this.transform.position, this.transform.rotation);
        }
        else
        {
            Debug.LogError("PlayerPrefab not assigned.");
        }
    }
}

