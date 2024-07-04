using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerState : MonoBehaviour
{
    private static PlayerState instance = new PlayerState();
    public static PlayerState Instance => instance;

    public bool _inGame = true; 

    /// <summary>
    /// スコア
    /// </summary>
    public float _score = 0;

    /// <summary>
    /// プレイヤーの耐久値
    /// </summary>
    [SerializeField]public int _hp = 3;

    private void Start()
    {

    }
    public void ScorePlus (float score)
    {
        _score += score;
    }//スコア加算

    public void HPMinus (int hp)
    {
        _hp -= hp;
        if (_hp <= 0)
        {
            _inGame = false;
        }
    }//HPの計算
}
