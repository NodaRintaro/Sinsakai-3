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
    /// �����ʒuX�̍ő�l
    /// </summary>
    [SerializeField] private float _maxSpawnRangeX = 3;
    /// <summary>
    /// �����ʒuY�̍ő�l
    /// </summary>
    [SerializeField] private float _maxSpawnRangeY = 3;
    /// <summary>
    /// Enemy�̔z��
    /// </summary>
    [SerializeField] private List<GameObject>_enemyObject;
    /// <summary>
    /// �������x
    /// </summary>
    [SerializeField] private float _spawnInterval = 1;
    /// <summary>
    /// �G�̈ړ����x
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
