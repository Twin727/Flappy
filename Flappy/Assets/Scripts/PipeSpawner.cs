using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject _pipes;
    public float _spawnInterval = 1.4f;
    void Start()
    {
        StartCoroutine(Spawner());
    }

    IEnumerator Spawner()
    {
        while (true)
        {
            yield return new WaitForSeconds(_spawnInterval);
            //float _randX = Random.Range(5.1f, 5.4f);
            float _randY = Random.Range(-2.5f, 2.5f);
            
           GameObject _newPipes = Instantiate(_pipes, new Vector3(4, _randY, 0), Quaternion.identity);
            Destroy(_newPipes, 5);
        }
    }

}
