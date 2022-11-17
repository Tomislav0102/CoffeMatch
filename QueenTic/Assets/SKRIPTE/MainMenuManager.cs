using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class MainMenuManager : MonoBehaviour
{
    [SerializeField] SO_postavke postavke;
    [SerializeField] Button btnPlay, btnQuit;
    [SerializeField] TMP_Dropdown ddLevel;
    
    private void Start()
    {
        postavke.level = 1;
        postavke.score = 0;
    }

    private void OnEnable()
    {
        btnPlay.onClick.AddListener(Btn_Play);
        btnQuit.onClick.AddListener(Btn_Quit);
        ddLevel.onValueChanged.AddListener(delegate
        {
            ChangeDropDown();
        });
    }
    private void OnDisable()
    {
        btnPlay.onClick.RemoveListener(Btn_Play);
        btnQuit.onClick.RemoveListener(Btn_Quit);
        ddLevel.onValueChanged.RemoveAllListeners();
    }
    void Btn_Play()
    {
        SceneManager.LoadScene(1);
    }
    void Btn_Quit()
    {
        Application.Quit();
    }
    void ChangeDropDown()
    {
        postavke.level = ddLevel.value + 1;
    }
}
