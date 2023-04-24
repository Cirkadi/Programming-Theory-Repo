using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class TitleUI : MonoBehaviour
{
    [SerializeField] Text playerNameInput;


    public void SetPlayerName()
    {
        PlayerNameHandle.Instance.PlayerName = playerNameInput.text;
    }
    
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
}
