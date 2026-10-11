using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public PooledObject _objectToPool;
    private int _poolLimit;

    [SerializeField] private int _startSize = 128;
    [SerializeField] private List<PooledObject> pooledObjects;
    [SerializeField] private List<PooledObject> usedObjects;

    private PooledObject _temp;

    void Awake()
    {
        Initialize();
    }

    void Initialize()
    {
        _poolLimit = _startSize;
        
        pooledObjects = new List<PooledObject>();
        
        if (usedObjects.Count > 0)
            usedObjects = new List<PooledObject>();
        
        for(int i = 0; i < _startSize; i++)
        {
            AddNewObject();
        }
    }

    private void AddNewObject()
    {
        _temp = Instantiate(_objectToPool, transform).GetComponent<PooledObject>();
        _temp.gameObject.SetActive(false);
        _temp.SetObjectPool(this);
        pooledObjects.Add(_temp);
    }

    public PooledObject GetPooledObject()
    {
        if (usedObjects.Count >= _poolLimit)
            return null;
        
        PooledObject obj;
        if(pooledObjects.Count > 0)
        {
            obj = pooledObjects[0];
            usedObjects.Add(obj);
            pooledObjects.RemoveAt(0);
        }
        else
        {
            AddNewObject();
            obj = GetPooledObject();
        }

        obj.gameObject.SetActive(true);
        obj.ResetObject();
        return obj;
    }

    public void RecyclePooledObject(PooledObject obj, float time=0)
    {
        if(time == 0)
        {
            obj.Recycle();
        }
        else
        {
            obj.Recycle(time);
        }
    }

    public void RestoreObject(PooledObject obj)
    {
        obj.gameObject.SetActive(false);
        usedObjects.Remove(obj);
        pooledObjects.Add(obj);
    }
}