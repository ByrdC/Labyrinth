using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StoryController : MonoBehaviour
{
    public TextContainer StoryText;

    public GameObject IntroCollider01;
    public GameObject IntroCollider02;
    public GameObject IntroCollider03;
    public GameObject IntroCollider04;
    public GameObject IntroCollider05;
    public GameObject IntroCollider06;
    public GameObject IntroCollider07;


    private string IntroText01 = "A red thread begins to unravel...";
    private string IntroText02 = "When Minos of Minoa was contesting his brothers for the throne, he asked the God of the Sea, Poseidon, to send a white bull as a symbol of his right to kingship.";
    private string IntroText03 = "Poseidon agreed, on the condition that Minos sacrifice the bull back to him, as thanks to Poseidon for the gift.";
    private string IntroText04 = "Minos took the bull and the throne, but out of greed did not sacrifice the gift. In anger, Poseidon cursed the wife of Minos, Pasiphae, to fall in love with the bull and mate with it.";
    private string IntroText05 = "The creature she gave birth to was the Minotaur which fed on human flesh and could not be controlled.";
    private string IntroText06 = "Ashamed, but unwilling to kill the creature, Minos ordered the great inventor and architect Daedalus create a labyrinth which would hold the monster, a maze so complicated that no one could find the exit.";
    private string IntroText07 = "When King Minos lost his son Androgeus to a fatal accident during the Panathenaic Games he was infuriated, and demanded Aegeus the king of Athens to send seven men and women every nine years to feed to the Minotaur.";

    // Start is called before the first frame update
    void Start()
    {
       // StoryText.text = IntroText01;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ChapterSelect()
    {
    }
}
