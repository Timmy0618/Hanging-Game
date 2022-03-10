using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSpawner : MonoBehaviour
{
    [SerializeField] GameObject[] monsterReference;

    GameObject spawnMonster;
    [SerializeField] Transform leftPos, rightPos;
    int randomIndex;
    int randomSide;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnMonster());
    }

    IEnumerator SpawnMonster()
    {
        while (true)
        {
            // yield return new WaitForSeconds(Random.Range(1, 5));
            yield return new WaitForSeconds(1f);

            randomIndex = Random.Range(0, monsterReference.Length);
            randomSide = Random.Range(0, 2);

            spawnMonster = Instantiate(monsterReference[randomIndex]);

            if (randomSide == 0)
            {
                spawnMonster.transform.position = leftPos.position;
                spawnMonster.GetComponent<Enemy>().speed = Random.Range(4, 10);
            }
            else
            {
                spawnMonster.transform.position = leftPos.position;
                spawnMonster.GetComponent<Enemy>().speed = -Random.Range(4, 10);
                // spawnMonster.transform.localScale = new Vector3(-1f, 1f, 1f);
            }
        }
    }
}
