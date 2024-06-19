using UnityEngine;

public class Game_AnimalSpawner : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created


    private float spawnerTime;




    [SerializeField]
    private Game_Animals[] Game_AnimalList;
    void Start()
    {
        Debug.Log(Game_AnimalList.Length);
    }

    // Update is called once per frame
    void Update()
    {
        spawnerTime += Time.deltaTime;


        if (spawnerTime > 2) {

            

            Instantiate(Game_AnimalList[Random.Range(0, Game_AnimalList.Length)].animalPrefab, 
                new Vector3(Random.Range(transform.position.x - 33, transform.position.x + 60), transform.position.y, transform.position.z), Quaternion.identity);

            spawnerTime = 0;
        }
            
    }
}
