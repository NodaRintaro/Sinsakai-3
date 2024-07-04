using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolCollection : MonoBehaviour
{
    private static PoolCollection instance = new PoolCollection();
    public static PoolCollection Instance => instance;

    [SerializeField]private Dictionary<string,Stack<PooledObject>> _poolCollection = new Dictionary<string,Stack<PooledObject>>();

    public void AddCollection(string key, Stack<PooledObject> value)
    {
        _poolCollection.Add(key, value);
    }
}
