using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using Coffee.UIEffects;

public class MainMenuManager : MonoBehaviour
{
    [SerializeField] SoSetting setting;
    [SerializeField] UITransitionEffect[] effects;
    [SerializeField] Button btnPlay, btnQuit;
    [SerializeField] TMP_Dropdown ddLevel;
    
    private void Start()
    {
        setting.level = 1;
        setting.score = 0;
        StartCoroutine(IntroSequence());
    }

    IEnumerator IntroSequence()
    {
        for (int i = 0; i < effects.Length; i++)
        {
            effects[i].gameObject.SetActive(true);
            effects[i].Show();
            yield return new WaitForSeconds(2);
           // if(i < effects.Length - 1) effects[i].gameObject.SetActive(false);
        }
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
        StopAllCoroutines();
    }
    void Btn_Quit()
    {
        Application.Quit();
    }
    void ChangeDropDown()
    {
        setting.level = ddLevel.value + 1;
    }
}
