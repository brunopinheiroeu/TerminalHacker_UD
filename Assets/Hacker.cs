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
    string password;

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
        else if (currentScreen == Screen.Password)
        {
            TestPass(input);
        }
    }

    void RunMainMenu(string input)
    {
        switch (input)
        {
            case "1":
                level = 1;
                StartGame(input);
                break;
            case "2":
                level = 2;
                StartGame(input);
                break;
            case "007":
                Terminal.WriteLine("Hi Mr. Bond! Please select a level.");
                break;
            default:
                Terminal.WriteLine("Wrong! Please choose a valid level.");
                break;
        }
        /*
        if (input == "1")
        {
            level = 1;
            StartGame(input);
        }
        else if (input == "2")
        {
            level = 2;
            StartGame(input);
        }
        else if (input == "007")
        {
            Terminal.WriteLine("Hi Mr. Bond! Please select a level.");
        }
        else
        {
            Terminal.WriteLine("Wrong! Please choose a valid level.");
        }*/
    }

    void StartGame(string input)
    {
        currentScreen = Screen.Password;
        Terminal.WriteLine("The level " + level + " has been chosen");
        Terminal.WriteLine("Please type the Password:");
    }

    private void TestPass(string input)
    {
        if (level == 1)
        {
            if (input == "one")
            {
                Terminal.WriteLine("Well Done!");
            }
            else
            {
                Terminal.WriteLine("Sorry, your password is wrong!");
                Terminal.WriteLine("Please type the Password:");
            }

        }
        else if (level == 2)
        {
            if (input == "two")
            {
                Terminal.WriteLine("Well Done!");
            }
            else
            {
                Terminal.WriteLine("Sorry, your password is wrong!");
                Terminal.WriteLine("Please type the Password:");
            }
        }
    }
}
