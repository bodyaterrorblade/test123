using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSpawner : MonoBehaviour
{
    public GameObject obj;
    public GameObject obj1;
    public Vector3 vlm;
    public float spawn_radius = 4f;
    public GameObject prefab;
    public GameObject prefab1;
    public Transform spawn_point;
    public int badfruit=5;
    void Start()
    {
        StartCoroutine(Cube_spawn());
    }

    IEnumerator Cube_spawn()
    {
        GameObject parent = new GameObject();
        while (true)
        {
            Vector3 pos = new Vector3(Random.Range(spawn_point.position.x - vlm.x, spawn_point.position.x + vlm.x), 120, 60);

            GameObject obj = Instantiate(prefab, pos, Quaternion.identity, parent.transform);
            yield return new WaitForSeconds(0.9f);

            GameObject obj1 = Instantiate(prefab1, pos, Quaternion.identity, parent.transform);
            yield return new WaitForSeconds(0.6f);
        }
        while (badfruit<=5)
        {
            badfruit--;

        }
    }
    void Update()
    {
        
    }
}
