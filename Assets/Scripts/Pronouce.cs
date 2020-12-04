using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pronouce : MonoBehaviour
{
    public AudioSource Elephant;
    public AudioSource Bat;
    public AudioSource Buffalo;
    public AudioSource Cat;
    public AudioSource Cattle;
    public AudioSource Chicken;
    public AudioSource Frog;
    public AudioSource Crab;
    public AudioSource Deer;
    public AudioSource Salamander;
    public AudioSource Spider;
    public AudioSource Horse;
    public AudioSource Ibex;
    public AudioSource Leopard;
    public AudioSource Pig;
    public AudioSource Octopus;
    public AudioSource Penguin;
    public AudioSource Perch;
    public AudioSource Rhinoceros;
    public AudioSource Salmon;
    public AudioSource Scorpion;
    public AudioSource Turtle;
    public AudioSource Swan;
    public AudioSource Tiger;
    public AudioSource Tucano;
    public AudioSource Rabbit;
    public AudioSource Zebra;
    AudioSource audioData;

    public void setPronouce(string audioAnimal)
    {
        //audioData = GetComponent<AudioSource>();
        switch (audioAnimal)
        {
            case "Elephant":
                audioData = Elephant;
                break;
            case "Bat":
                audioData = Bat;
                break;
            case "Buffalo":
                audioData = Buffalo;
                break;
            case "Cat":
                audioData = Cat;
                break;
            case "Cattle":
                audioData = Cattle;
                break;
            case "Chicken":
                audioData = Chicken;
                break;
            case "Frog":
                audioData = Frog;
                break;
            case "Crab":
                audioData = Crab;
                break;
            case "Deer":
                audioData = Deer;
                break;
            case "Salamander":
                audioData = Salamander;
                break;
            case "Spider":
                audioData = Spider;
                break;
            case "Horse":
                audioData = Horse;
                break;
            case "Ibex":
                audioData = Ibex;
                break;
            case "Leopard":
                audioData = Leopard;
                break;
            case "Pig":
                audioData = Pig;
                break;
            case "Octopus":
                audioData = Octopus;
                break;
            case "Penguin":
                audioData = Penguin;
                break;
            case "Perch":
                audioData = Perch;
                break;
            case "Rhinoceros":
                audioData = Rhinoceros;
                break;
            case "Salmon":
                audioData = Salmon;
                break;
            case "Scorpion":
                audioData = Scorpion;
                break;
            case "Turtle":
                audioData = Turtle;
                break;    
            case "Swan":
                audioData = Swan;
                break;
            case "Tiger":
                audioData = Tiger;
                break;
            case "Tucano":
                audioData = Tucano;
                break;
            case "Rabbit":
                audioData = Rabbit;
                break;
            case "Zebra":
                audioData = Zebra;
                break;
            default:
                audioData = Tiger;
                break;
        }
        audioData.Play();
    }
}