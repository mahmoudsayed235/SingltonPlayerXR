using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
public class PlayerManager : MonoBehaviour
{
    public static PlayerManager instance = null;
    public GameObject playerPrefab;
    public static GameObject player;

   
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            player = Instantiate(playerPrefab, instance.transform);
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }
}
