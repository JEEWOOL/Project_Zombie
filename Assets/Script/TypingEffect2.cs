using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TypingEffect2 : MonoBehaviour
{
    public Text tx;
    private string m_text = "�̼��� �Ϸ� �Ͽ����ϴ�. ���� �ܰ�� �Ѿ�ϴ�.";

    private void Start()
    {
        StartCoroutine(_typing());
    }

    private void Update()
    {
        Cursor.lockState = CursorLockMode.None;
        SceneManager.LoadScene(6);
    }

    IEnumerator _typing()
    {
        yield return new WaitForSeconds(2f);
        for (int i = 0; i < m_text.Length; i++)
        {
            tx.text = m_text.Substring(0, i);
            yield return new WaitForSeconds(0.1f);
        }
    }
}
