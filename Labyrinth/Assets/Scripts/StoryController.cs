using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StoryController : MonoBehaviour
{
    public TextMeshProUGUI StoryText;
    public GameObject EndPanel;

    private string IntroText01 = "A red thread begins to unravel...";
    private string IntroText02 = "When Minos of Minoa was contesting his brothers for the throne, he asked the God of the Sea, Poseidon, to send a white bull as a symbol of his right to kingship.";
    private string IntroText03 = "Poseidon agreed, on the condition that Minos sacrifice the bull back to him, as thanks to Poseidon for the gift.";
    private string IntroText04 = "Minos took the bull and the throne, but out of greed did not sacrifice the gift. In anger, Poseidon cursed the wife of Minos, Pasiphae, to fall in love with the bull and mate with it.";
    private string IntroText05 = "The creature she gave birth to was the Minotaur which fed on human flesh and could not be controlled.";
    private string IntroText06 = "Ashamed, but unwilling to kill the creature, Minos ordered the great inventor and architect Daedalus to create a labyrinth which would hold the monster, a maze so complicated that no one could find the exit.";
    private string IntroText07 = "When King Minos lost his son Androgeus to a fatal accident during the Panathenaic Games he was infuriated, and demanded Aegeus the king of Athens to send seven men and women every nine years to feed to the Minotaur.";
    private string IntroText08 = "Theseus, son of Aegeus, volunteered to be one of the seven young men that would go to Crete, in order to kill the Minotaur and end the human sacrifices to the monster.";
    private string IntroText09 = "When he arrived in Crete, he met the daughter of King Minos, Princess Ariadne. She saw potential in him and decided to give Theseus her weaving thread.";
    private string IntroText10 = "She told him that if he unraveled it as he descended into the Labyrinth, he would always be able to follow it back to the exit.";
    private string IntroText11 = "While the other 13 tributes hovered by the entrance of the Labyrinth, Theseus ventured into the depths to seek the creature, trailing Ariadne’s thread behind him.";
    private string IntroText12 = "The fearsome Minotaur lived at the center of the Labyrinth. With the head of a bull and the body of a man, the creature towers over men.";



    // Start is called before the first frame update
    void Start()
    {
        StoryText.text = "Navigate the labyrinth using the W A S D keys.";
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "intro01")
        {
            StoryText.text = IntroText01;
        }

        else if (collision.tag == "intro02")
        {
            StoryText.text = IntroText02;
        }

        else if (collision.tag == "intro03")
        {
            StoryText.text = IntroText03;
        }

        else if (collision.tag == "intro04")
        {
            StoryText.text = IntroText04;
        }

        else if (collision.tag == "intro05")
        {
            StoryText.text = IntroText05;
        }

        else if (collision.tag == "intro06")
        {
            StoryText.text = IntroText06;
        }

        else if (collision.tag == "intro07")
        {
            StoryText.text = IntroText07;
        }

        else if (collision.tag == "intro08")
        {
            StoryText.text = IntroText08;
        }

        else if (collision.tag == "intro09")
        {
            StoryText.text = IntroText09;
        }

        else if (collision.tag == "intro10")
        {
            StoryText.text = IntroText10;
        }

        else if (collision.tag == "intro11")
        {
            StoryText.text = IntroText11;
        }

        else if (collision.tag == "intro12")
        {
            StoryText.text = IntroText12;
        }

        else if (collision.tag == "ENDING")
        {
            EndPanel.SetActive(true);
        }
    }
}
