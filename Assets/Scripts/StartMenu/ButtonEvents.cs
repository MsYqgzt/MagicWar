using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonEvents : MonoBehaviour
{
    public AudioSource Audio;
    // Use this for initialization
    void Start()
    {
        //获取按钮名称，执行指定函数
        switch (GetComponent<Button>().name)
        {
            case "NewGame":
                GetComponent<Button>().onClick.AddListener(NewGameClick);
                break;
            case "Continue":
                GetComponent<Button>().onClick.AddListener(ContinueClick);
                break;
            case "Settings":
                GetComponent<Button>().onClick.AddListener(SettingsClick);
                break;
            case "Quit":
                GetComponent<Button>().onClick.AddListener(QuitClick);
                break;
        }
        LTLocalization.GetText(GetComponent<Text>().text);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void PlayAudio()
    {

        Audio.Play();
    }

    void NewGameClick()
    {
        Debug.Log("已点击NewGame");
    }

    void ContinueClick()
    {
        Debug.Log("已点击Continue");
    }

    void SettingsClick()
    {
        Debug.Log("已点击Settings");
    }

    void QuitClick()
    {
        Debug.Log("已点击Quit");
        Application.Quit();
    }
}
