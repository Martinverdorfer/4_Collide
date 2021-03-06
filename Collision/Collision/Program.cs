﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
/*
 *  Collide
 *  Eine Simulation im 2-dimensionalen Raum
 *  Aufgabenverteilung
 *  a) Ausserer Alex
 *  b) Ritsch Julian
 *  c) Verdorfer Martin
 *  d) Pircher Marjan
 * / Teil C Martin Verdorfer
 * 2020 TFO-Meran
 */

namespace ConsoleApplication1
{
    class Program
    {
        const int seite = 50;
        static int[,] feld = new int[seite, seite];

        class einer
        {
            // Private Eigenschaften

            // Öffentliche Eigenschaften
            public int posx, posy;
            public ConsoleColor farbe;
            // Konstruktor
            public einer()
            {
            }
            //Private Methoden
            void show()
            {
                Console.SetCursorPosition(posx, posy); //Hier wird der Cursor auf die Position X,Y gesetzt
                Console.ForegroundColor = farbe;       // Textfarbe wird gewählt
                Console.Write("■");                     //das Objekt wird gezeichnet

            }
            void hide()
            {
                Console.SetCursorPosition(posx, posy); //Hier wird der Cursor auf die Position X,Y gesetzt
                Console.Write(" ");                    //Es wird gelöscht

            }
            void collide()
            {
                Console.SetCursorPosition(posx, posy);  //Hier wird der Cursor auf die Position X,Y gesetzt
                Console.ForegroundColor = farbe;         // Textfarbe wird gewählt
                Console.Write("x");                     //Es wird markiert
                Move();                                 //Die Move Methode wird aufgerufen
            }
            //Öffentliche Methoden
            public void Move()
            {
            }

        }

        static void Main(string[] args)
        {
            Console.WindowWidth = seite*2;
            Console.WindowHeight = seite;
            Console.Clear();
            Random ZG = new Random();
            int Anzahl=ZG.Next(1,6);
            einer[] meineEiner = new einer[Anzahl];
            for (int i = 0; i < Anzahl; i++)
            {
                meineEiner[i] = new einer();
            }
            Console.CursorVisible = false;
            for (int i = 0; i < 1000; i++)
            {
                for (int j = 0; j < Anzahl; j++)
                {
                    meineEiner[j].Move();
                }
                System.Threading.Thread.Sleep(10);

            }
        }
    }
}
