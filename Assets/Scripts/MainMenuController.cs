using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void playGame()
    {
        string clickedObj = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name;
        GameManager.instance.CharIndex = int.Parse(clickedObj);
        SceneManager.LoadScene("GamePlay");
    }

    public void selectCharacter()
    {

    }
}
