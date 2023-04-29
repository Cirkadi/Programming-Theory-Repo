using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TitleUI : MonoBehaviour
{
    [SerializeField] Text playerNameInput;
    [SerializeField] GameObject noNameAlert;
    [SerializeField] GameObject tooLongNameAlert;

    public void SetPlayerName()
    {
        noNameAlert.SetActive(false);
        tooLongNameAlert.SetActive(false);
        
        PlayerNameHandle.Instance.PlayerName = playerNameInput.text;
    }
    
    public void StartGame()
    {
        if(playerNameInput.text.Length == 0)
        {
            noNameAlert.SetActive(true);
            return;
        }
        if(playerNameInput.text.Length >= 12)
        {
            tooLongNameAlert.SetActive(true);
            return;
        }        
        SceneManager.LoadScene(1);        
    }
}
