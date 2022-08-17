using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoginManager : MonoBehaviour
{
    public InputField id;
    public InputField password;
    public Text notify;

    void Start()
    {
        notify.text = "";
        id.Select();
    }

    public void Update()
    {
        if(id.isFocused == true)
        {
            if (Input.GetKeyDown(KeyCode.Tab))
            {
                password.Select();
            }
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            CheckUserData();
        }
        if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            CheckUserData();
        }
    }

    public void SaveUserData()
    {
        if (!CheckInput(id.text, password.text))
        {
            return;
        }

        if (!PlayerPrefs.HasKey(id.text))
        {
            PlayerPrefs.SetString(id.text, password.text);
            notify.text = "���̵� ������ �Ϸ�Ǿ����ϴ�.";
        }
        else
        {
            notify.text = "�̹� �����ϴ� ���̵��Դϴ�.";
        }
    }

    public void CheckUserData()
    {
        if (!CheckInput(id.text, password.text))
        {
            return;
        }

        string pass = PlayerPrefs.GetString(id.text);

        if (password.text == pass)
        {
            SceneManager.LoadScene(2);
        }
        else
        {
            notify.text = "���̵� / ��й�ȣ�� ��ġ���� �ʽ��ϴ�.";
        }
    }

    bool CheckInput(string id, string pwd)
    {
        if (id == "" || pwd == "")
        {
            notify.text = "���̵� / ��й�ȣ�� Ȯ�����ּ���.";
            return false;
        }
        else
        {
            return true;
        }
    }
}