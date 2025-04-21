using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[DefaultExecutionOrder(1000)]
public class MenuUIHandler : MonoBehaviour
{
    public TMP_InputField nameInputField;
    public TextMeshProUGUI highScoreText;

    private void Awake()
    {
        HighScoreManager.instance.LoadHighScore();
        highScoreText.text = $"Best Score : {HighScoreManager.highScorePlayerName} : {HighScoreManager.highScore}";
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartNew()
    {
        HighScoreManager.currentPlayerName = nameInputField.text;
        SceneManager.LoadScene(1);
    }
}
