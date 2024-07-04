using UnityEngine;

public class PooledObject: MonoBehaviour
{
    private void OnBecameInvisible()
    {

    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {

        }
    }
}
