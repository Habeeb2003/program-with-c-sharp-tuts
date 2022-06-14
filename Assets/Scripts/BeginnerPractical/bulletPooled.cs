using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletPooled : MonoBehaviour
{
    public bulletPool bulletPrefab;
    public GameObject gamObjectPrefab;


    private Queue<bulletPool> bulletQueue = new Queue<bulletPool>();
    public static bulletPooled Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public bulletPool GetBullet()
    {
        if (bulletQueue.Count == 0)
        {
            AddToQueue(1);
        }

        bulletPool bb = bulletQueue.Dequeue();
        //bb.gameObject.SetActive(true);
        return bb;
    }
    public void AddToQueue(int count)
    {
        for (int i = 0; i < count; i++)
        {
            bulletPool b = Instantiate(bulletPrefab);
            b.gameObject.SetActive(false);
            bulletQueue.Enqueue(b);
        }
        
    }

    public void ReturnToQueue(bulletPool bbb)
    {
        bbb.gameObject.SetActive(false);
        bulletQueue.Enqueue(bbb);
    }
}
