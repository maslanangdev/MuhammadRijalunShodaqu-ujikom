using UnityEngine;

public class Game_AnimalHandler : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [SerializeField]
    private float speed = 10;



    void Start()
    {
        transform.rotation = Quaternion.AngleAxis(180, Vector3.up);
    }

    // Update is called once per frame


    void animalMove(float animalSpeed)
    {
        transform.position += Vector3.forward * -1 * Time.deltaTime * animalSpeed * 0.08f;
    }

    void Update()
    {

        //L
        //lifetime += Time.deltaTime;
        //if (3 < lifetime)
        //{
        //    Destroy(gameObject);
        //    Debug.Log("Pizza Destroyed!");
        //}

        animalMove(speed);
    }
}
