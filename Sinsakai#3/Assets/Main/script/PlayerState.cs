using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerState : MonoBehaviour
{
    private static PlayerState instance = new PlayerState();
    public static PlayerState Instance => instance;

    /// <summary>
    /// スコア
    /// </summary>
    private float _score = 0;

    /// <summary>
    /// プレイヤーの耐久値
    /// </summary>
    [SerializeField] int _hp = 3;

    public void Score (float score)
    {
        _score += score;
    }//スコア加算

    public void HP (int hp)
    {
        _hp -= hp;
        if (_hp <= 0)
        {
            
        }
    }//HPの計算
}
