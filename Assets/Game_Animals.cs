using UnityEngine;

[CreateAssetMenu(fileName = "Animal", menuName = "Scriptable Objects/Animal")]
public class Game_Animals : ScriptableObject
{
    public string animalName;
    public int animalSpeed;
    public int animalHungerNeed;
    public int animalScore;
    //public GameObject animalPrefab;
}
