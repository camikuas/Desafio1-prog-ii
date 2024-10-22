using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Progression : MonoBehaviour
{
    private int currentLevel;
    public int CurrentLevel { get => currentLevel;}

    private int currentExperience;

    [SerializeField]
    [Range(10,50)]
    private int experienceToNextLevel;

    [SerializeField]
    [Range(10, 2000)]
    private int scaleExperience;

    public void GainExperience(int experience)
    {
        currentExperience += experience;

        if (currentExperience >= experienceToNextLevel)
        {
            LevelUp();
        }
    }

    private void LevelUp()
    {
        currentLevel++;
        currentExperience -= experienceToNextLevel;
        experienceToNextLevel += scaleExperience; 

    }
}