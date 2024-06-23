using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class EnemyManager : MonoBehaviour
{
    private static EnemyManager instance = new EnemyManager();
    public static EnemyManager Instance => instance;
    /// <summary>
    /// 生成位置Xの最大値
    /// </summary>
    [SerializeField] private float _maxSpawnRangeX = 3;
    /// <summary>
    /// 生成位置Yの最大値
    /// </summary>
    [SerializeField] private float _maxSpawnRangeY = 3;
    /// <summary>
    /// Enemyの配列
    /// </summary>
    [SerializeField] private List<GameObject>_enemyObject;
    /// <summary>
    /// 生成速度
    /// </summary>
    [SerializeField] private float _spawnInterval = 1;
    /// <summary>
    /// 敵の移動速度
    /// </summary>
    [SerializeField] public float _movePower = 10;

    private float _time;

    public void Update()
    {
        _time += Time.deltaTime;
        if(_time >= _spawnInterval)
        {
            int random = Random.Range(0, _enemyObject.Count);
            _time = 0;
            Spawn(random);
        }
    }

    public void Spawn(int num)
    {
        GameObject enemy = _enemyObject[num];
        Vector3 spawnPos = new Vector3(Random.Range(-_maxSpawnRangeX, _maxSpawnRangeX), Random.Range(-_maxSpawnRangeY, _maxSpawnRangeY), 20);
        if(_enemysCount >= )
        Instantiate(enemy, spawnPos, Quaternion.identity);
        _enemyObject.Remove(enemy);
    }

    public void AddEnemy(GameObject enemy)
    {
        //_enemyObject.Add(enemy);
        enemy.SetActive(false);
    }
}
