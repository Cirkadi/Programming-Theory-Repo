using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerNameHandle : MonoBehaviour
{
    public static PlayerNameHandle Instance;
    public string PlayerName;

    private void Awake()
    {
        if(Instance != null)
        {
            Destroy(gameObject);
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
