using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{


    [SerializeField] UnityEngine.GameObject _scoreObject = null;
    [SerializeField] UnityEngine.GameObject _hpObject = null;
    [SerializeField] UnityEngine.GameObject _gameOverObject = null;
    Text _scoreText = null;
    Text _hpText = null;
    Text _gameOverText = null;

    private void Start()
    {
        _scoreText = _scoreObject.GetComponent<Text>();
        _hpText = _hpObject.GetComponent<Text>();
        _gameOverText = _gameOverObject.GetComponent<Text>();
    }

    private void Update()
    {
        if (PlayerState.Instance._inGame == false)
        {
            _gameOverObject.SetActive(true);
            _gameOverText.text = "GameOver";
            _hpText.text = "HP:0";
        }
        else
        {
            _scoreText.text = "Score:" + PlayerState.Instance._score.ToString("000");
            _hpText.text = "HP:" + PlayerState.Instance._hp.ToString();
        }
    }
}
