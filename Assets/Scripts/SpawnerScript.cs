using UnityEngine;
using System.Collections;

public class SpawnerScript : MonoBehaviour
{
	public float timeMin = 5f;
	public float timeMax = 8f;
    // Use this for initialization
    void Start()
    {
        SpawnObject = SpawnObjects[Random.Range(0, SpawnObjects.Length)];
        Spawn();
    }

    void Spawn()
    {
        if (GameStateManager.GameState == GameState.Playing)
        {
            //random y position
            float y = Random.Range( 1f, 2f);
            GameObject go = Instantiate(SpawnObject, this.transform.position + new Vector3(0, y, 0), Quaternion.identity) as GameObject;
        }
        Invoke("Spawn", Random.Range(timeMin, timeMax));
    }

    private GameObject SpawnObject;
    public GameObject[] SpawnObjects;


}
