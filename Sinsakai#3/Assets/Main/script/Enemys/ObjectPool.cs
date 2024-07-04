using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class ObjectPool : MonoBehaviour
{
    /// <summary>
    /// 生成速度
    /// </summary>
    [SerializeField] public float _spawnInterval = 1f;

    [SerializeField] private Vector3 _spawnPoint = new Vector3();

    [SerializeField] private Stack<PooledObject> _objectPool = new Stack<PooledObject>();

    [SerializeField] public PooledObject _pooledObject;

    [SerializeField] public string _poolCode;

    private float _timer = 0;

    private void Start()
    {
        PoolCollection.Instance.AddCollection(_poolCode, _objectPool);
    }

    private void Update()
    {
        _timer += Time.deltaTime;
        if (_timer > _spawnInterval)
        {
            _timer = 0;
            GetPooledObject();
        }
    }
    public void GetPooledObject()
    {
        if(_objectPool.Count == 0)
        {
            SpawnPoint();
            Instantiate(_pooledObject, _spawnPoint, Quaternion.identity);
        }
        else
        {
            SpawnPoint();
            PooledObject activeObject = _objectPool.Pop();
            activeObject.gameObject.SetActive(true);
            activeObject.transform.position = _spawnPoint;
        }
    }
    
    public void ReturnToPool(PooledObject pooledObject)
    {
        if(pooledObject == _pooledObject)
        {
            _objectPool.Push(pooledObject);
            pooledObject.gameObject.SetActive(false);
        }
    }

    public void SpawnPoint()
    {
        _spawnPoint = new Vector3(Random.Range(-20,20),0,Random.Range(-20,20));
    }
}
