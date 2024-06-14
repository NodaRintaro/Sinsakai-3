using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance = new GameManager();
    public static GameManager Instance => instance;

    /// <summary>
    /// スコア
    /// </summary>
    private float _score = 0;

    /// <summary>
    /// プレイヤーの耐久値
    /// </summary>
    [SerializeField] int _hp = 3;

    /// <summary>
    /// ゲームが始まっているかどうかの判定
    /// </summary>
    private bool _onPlaying = false;

    public void Score (float score)
    {
        _score += score;
    }

    public void HP (int hp)
    {
        _hp -= hp;
        if (_hp <= 0)
        {
            GameOver();
        }
    }

    public void GameOver()
    {
        _onPlaying = false;
    }

    public void GameStart()
    {
        _onPlaying = true;
    }

    public enum FlyObject
    {
        Enemy,
        Support,
        TimePlsu,
    }
}
