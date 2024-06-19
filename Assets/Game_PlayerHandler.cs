using UnityEngine;

public class Game_PlayerHandler : MonoBehaviour
{


    private CharacterController game_playerController;

    private float playerSpeed = 20.0f;

    void Start()
    {
        game_playerController = gameObject.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.A))
        {
            game_playerController.Move(Vector3.left * playerSpeed * Time.deltaTime);

        }

        if (Input.GetKey(KeyCode.D))
        {
            game_playerController.Move(Vector3.right * playerSpeed * Time.deltaTime);

        }
    }
}
