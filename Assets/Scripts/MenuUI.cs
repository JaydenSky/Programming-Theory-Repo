using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuUI : MonoBehaviour
{
    public GameObject inputFieldOne;
    public GameObject inputFieldTwo;

    public void SetColors()
    {
        MainManager.Instance.favoriteColor = inputFieldOne.GetComponent<InputField>().text;
        MainManager.Instance.secondColor = inputFieldTwo.GetComponent<InputField>().text;
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
}
