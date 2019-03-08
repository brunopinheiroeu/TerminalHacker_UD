using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    //Game state
    int level;
    enum Screen { MainMenu, Password, Win };
    Screen currentScreen;

    // Start is called before the first frame update
    void Start()
    {
        ShowMainMenu();
    } // TODO handle differently depending on sreen

    void ShowMainMenu ()
    {
        currentScreen = Screen.MainMenu;
        Terminal.ClearScreen();
        Terminal.WriteLine("What do you like to hack today?");
        Terminal.WriteLine("");
        Terminal.WriteLine("Press 1 for the English School");
        Terminal.WriteLine("Press 2 for the Company");
        Terminal.WriteLine("");
        Terminal.WriteLine("Please enter your selection:");
    }

    void OnUserInput(string input)
    {
        if (input == "menu") // we can always go to the main menu
        {
            ShowMainMenu();
            
        }
        else if (currentScreen == Screen.MainMenu)
        {
            RunMainMenu(input);
        }
    }

    void RunMainMenu(string input)
    {
        if (input == "1")
        {
            level = 1;
            StartGame();
        }
        else if (input == "2")
        {
            level = 2;
            StartGame();
        }
        else if (input == "007")
        {
            Terminal.WriteLine("Hi Mr. Bond! Please select a level.");
        }
        else
        {
            Terminal.WriteLine("Wrong! Please choose a valid level.");
        }
    }

    void StartGame()
    {
        currentScreen = Screen.Password;
        Terminal.WriteLine("The level " + level + " has been chosen");
        Terminal.WriteLine("Please type the Password:");
    }

}
