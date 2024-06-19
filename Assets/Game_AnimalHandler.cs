using Unity.VisualScripting;
using UnityEngine;

public class Game_AnimalHandler : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [SerializeField]
    private Game_Animals profile;


    private int animalHealth;

    //[SerializeField]
    //private float speed = 10;


    BoxCollider coll;

    void Start()
    {
        transform.rotation = Quaternion.AngleAxis(180, Vector3.up);
        animalHealth = profile.animalHungerNeed;

        coll = GetComponent<BoxCollider>();
    }

    // Update is called once per frame


    public void hitFood()
    {
        animalHealth -= 25;
        Debug.Log(animalHealth);
    }


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

        animalMove(profile.animalSpeed);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("hit!");
    }
}
