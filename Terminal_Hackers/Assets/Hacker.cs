using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour {

    enum Screen { MainMenu,Password, Win};
    Screen currentScreen;
    int level = 0;

    void ShowMainMenu()
    {
        currentScreen = Screen.MainMenu;
        Terminal.ClearScreen();
        Terminal.WriteLine("What would you like to Play onto?");
        Terminal.WriteLine(" ");
        Terminal.WriteLine("Press 1 for the local library");
        Terminal.WriteLine("Press 2 for the police station");
        Terminal.WriteLine("Press 3 for the Nasa");
        
    }

    private void HandleInputMenu(string input)
    {
        if (input == "1")
        {
            level = 1;
            startGame();
        }
        else if (input == "2")
        {
            level = 2;
            startGame();
        }
        else if (input == "3")
        {
            level = 3;
            startGame();
        }
        else
            Terminal.WriteLine("Input Should be 1 - 3");
    }

    void OnUserInput(string input)
    {
        if (input == "menu" || input == "Menu")
            ShowMainMenu();
        else if (currentScreen == Screen.MainMenu)
            HandleInputMenu(input);

    }
    private void startGame()
    {
        currentScreen = Screen.Password;
        Terminal.ClearScreen();
        Terminal.WriteLine("game: " + level);
    }

    // Use this for initialization
    void Start () {

        ShowMainMenu();
        Terminal.WriteLine("Enter Your selection :");

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
