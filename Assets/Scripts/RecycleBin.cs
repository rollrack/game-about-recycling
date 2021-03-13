using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecycleBin : MonoBehaviour
{
    void Update()
    {
        void Recycle()
        {
            void OnTriggerEnter2D(Collider2D other)
            {
                if (other.CompareTag("greenBin"))
                {
                    Destroy(gameObject);
                }
            }
        }
    }
}
