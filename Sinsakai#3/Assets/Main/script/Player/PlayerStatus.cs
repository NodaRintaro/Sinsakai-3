using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : MonoBehaviour
{
    private static PlayerStatus instance = new PlayerStatus();
    public static PlayerStatus Instance => instance;

    private bool _finishGame = false; 

    /// <summary>
    /// スコア
    /// </summary>
    public float _score = 0;

    /// <summary>
    /// プレイヤーの耐久値
    /// </summary>
    [SerializeField]public int _hp = 3;

    public void CurrentScore (float score)
    {
        _score += score;
    }//スコア加算と表示

    public void CurrentHP (int hp)
    {
        _hp -= hp;
        if (_hp <= 0)
        {
            
        }
    }//HPの計算と表示
}
