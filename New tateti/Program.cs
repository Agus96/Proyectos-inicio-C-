using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine(" _____ _____    _____ _____    _____ _____ ");
            Console.WriteLine("|_   _|  _  |  |_   _|   __|  |_   _|     |");
            Console.WriteLine("  | | |     |    | | |   __|    | |  \\   /  ");
            Console.WriteLine("  |_| |__|__|    |_| |_____|    |_| |_____|");

            Console.WriteLine("---------------------------------------------------------------------");
            //-----------------------------------------------------------------------------------------------//
            string pjp;
            string pjs;
            //-----------------------------------------------------------------------------------------------//
            Console.WriteLine("Para empezar a jugar, ingrese los nombres de los jugadores \n");
            Console.WriteLine("Primer jugador ? ");
            pjp = Convert.ToString(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Segundo jugador ?");
            pjs = Convert.ToString(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine(pjp + ": X  \n");
            Console.WriteLine(pjs + ": O");
            Console.WriteLine("");
            Console.WriteLine("CONTROLES PARA EL JUEGO");
            Console.WriteLine("----------------------");
            Console.WriteLine("_________________ ");
            Console.WriteLine("  7  |  8  |  9   ");
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("  4  |  5  |  6   ");
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("  1  |  2  |  3   ");
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("");
            //------------------------------------------------------------------------------------------------------------//
            //----------------MAPEADO-------------------------------------------------------------------------------------//
            Console.WriteLine("A JUGAR!!\n");
            string[] pato = { " ", " ", " ", " ", " ", " ", " ", " ", " " };
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", pato[6], pato[7], pato[8]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", pato[3], pato[4], pato[5]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", pato[0], pato[1], pato[2]);
            Console.WriteLine("     |     |      ");
            //---------------------------------------------------------------------------------------------------------------//
            //----------------------------------Escribir en el mapa ---------------------------------------------------------//
            char pj1 = 'X';
            char pj2 = 'O';
            int Juego = 0;
            bool turn = false;

            //=================================================================================================================//
            while (Juego == 0)
            {
                    ConsoleKeyInfo cki = Console.ReadKey();
                    if (cki.KeyChar == 49 && pato[0] == " ") //------ 1-------// 
                    {
                        Console.SetCursorPosition(2, 36);
                        if (turn == false)
                        {
                            Console.Write(pj1);
                            pato[0] = pj1.ToString();
                        }
                        else
                        {
                            Console.Write(pj2);
                            pato[0] = pj2.ToString();
                        }
                        turn = !turn;
                        Console.SetCursorPosition(41, 41);
                    }

                    if (cki.KeyChar == 50 && pato[1] == " ") //------ 2 -------// 
                    {
                        Console.SetCursorPosition(8, 36);
                        if (turn == false)
                        {
                            Console.Write(pj1);
                            pato[1] = pj2.ToString();
                        }
                        else
                        {
                            Console.Write(pj2);
                            pato[1] = pj2.ToString();

                        }
                        turn = !turn;
                        Console.SetCursorPosition(41, 45);
                    }
                    if (cki.KeyChar == 51 && pato[2] == " ") //------ 3-------// 
                    {
                        Console.SetCursorPosition(14, 36);
                        if (turn == false)
                        {
                            Console.Write(pj1);
                            pato[2] = pj1.ToString();
                        }
                        else
                        {
                            Console.Write(pj2);
                            pato[2] = pj2.ToString();
                        }
                        turn = !turn;
                        Console.SetCursorPosition(41, 41);
                    }
                    if (cki.KeyChar == 52 && pato[3] == " ") //------ 4 -------// 
                    {
                        Console.SetCursorPosition(2, 33);
                        if (turn == false)
                        {
                            Console.Write(pj1);
                            pato[3] = pj1.ToString();
                        }
                        else
                        {
                            Console.Write(pj2);
                            pato[3] = pj2.ToString();

                        }
                        turn = !turn;
                        Console.SetCursorPosition(41, 41);
                    }
                    if (cki.KeyChar == 53 && pato[4] == " ") //------5-------// 
                    {
                        Console.SetCursorPosition(8, 33);
                        if (turn == false)
                        {
                            Console.Write(pj1);
                            pato[4] = pj1.ToString();
                        }
                        else
                        {
                            Console.Write(pj2);
                            pato[4] = pj2.ToString();
                        }
                        turn = !turn;
                        Console.SetCursorPosition(41, 41);
                    }
                    if (cki.KeyChar == 54 && pato[5] == " ") //------ 6-------// 
                    {
                        Console.SetCursorPosition(14, 33);
                        if (turn == false)
                        {
                            Console.Write(pj1);
                            pato[5] = pj1.ToString();
                        }
                        else
                        {
                            Console.Write(pj2);
                            pato[5] = pj2.ToString();

                        }
                        turn = !turn;
                        Console.SetCursorPosition(41, 41);
                    }
                    if (cki.KeyChar == 55 && pato[6] == " ") //------7-------// 
                    {
                        Console.SetCursorPosition(2, 30);
                        if (turn == false)
                        {
                            Console.Write(pj1);
                            pato[6] = pj1.ToString();
                        }
                        else
                        {
                            Console.Write(pj2);
                            pato[6] = pj2.ToString();
                        }
                        turn = !turn;
                        Console.SetCursorPosition(41, 41);
                    }
                    if (cki.KeyChar == 56 && pato[7] == " ") //------8-------// 
                    {
                        Console.SetCursorPosition(8, 30);
                        if (turn == false)
                        {
                            Console.Write(pj1);
                            pato[7] = pj1.ToString();
                        }
                        else
                        {
                            Console.Write(pj2);
                            pato[7] = pj2.ToString();
                        }
                        turn = !turn;
                        Console.SetCursorPosition(41, 41);
                    }
                    if (cki.KeyChar == 57 && pato[8] == " ") //------ 9-------// 
                    {
                        Console.SetCursorPosition(14, 30);
                        if (turn == false)
                        {
                            Console.Write(pj1);
                            pato[8] = pj1.ToString();
                        }
                        else
                        {
                            Console.Write(pj2);
                            pato[8] = pj2.ToString();
                        }
                        turn = !turn;
                        Console.SetCursorPosition(41, 41);
                    }
                    if (cki.KeyChar == 48) //------ 0 -------// 
                    {
                        //  Console.SetCursorPosition(2, 33);
                        Console.WriteLine(" ELIJA DE NUEVO ");
                    }
                    //==============================================================================================//
                    //------------ PUNTOS DE VICTORIA Y EMPATE -----------------------------------------------------//

                    //------------ Personaje uno         -----------------------------------------------------------//

                    if (pj1.ToString() == pato[0] && pj1.ToString() == pato[1] && pj1.ToString() == pato[2])      //1
                    {

                       
                        Console.WriteLine("RESULTADO: Gano:" + pjp);

                    }

                    else if (pj1.ToString() == pato[3] && pj1.ToString() == pato[4] && pj1.ToString() == pato[5]) //2
                    {
                        Console.WriteLine("RESULTADO: Gano:" + pjp);
                      

                    }
                    else if (pj1.ToString() == pato[6] && pj1.ToString() == pato[7] && pj1.ToString() == pato[8]) //3
                    {

                        Console.WriteLine("RESULTADO: Gano:" + pjp);
                    

                    }

                    else if (pj1.ToString() == pato[0] && pj1.ToString() == pato[3] && pj1.ToString() == pato[6]) //4
                    {
                   
                        Console.WriteLine("RESULTADO: Gano:" + pjp);

                    }

                    else if (pj1.ToString() == pato[1] && pj1.ToString() == pato[4] && pj1.ToString() == pato[7]) //5
                    {
                        
                        Console.WriteLine("RESULTADO: Gano:" + pjp);

                    }

                    else if (pj1.ToString() == pato[2] && pj1.ToString() == pato[5] && pj1.ToString() == pato[8]) //6
                    {
                  
                        Console.WriteLine("RESULTADO: Gano:" + pjp);

                    }

                    else if (pj1.ToString() == pato[0] && pj1.ToString() == pato[4] && pj1.ToString() == pato[8]) //7
                    {
                      
                        Console.WriteLine("RESULTADO: Gano:" + pjp);

                    }
                    else if (pj1.ToString() == pato[2] && pj1.ToString() == pato[4] && pj1.ToString() == pato[6]) //8
                    {
                 
                        Console.WriteLine("RESULTADO: Gano:" + pjp);

                    }
                    //===============================================================================================//
                    //-----------------------------------------------------------------------------------------------//
                    //================================== SEGUNDO ====================================================//
                    else if (pj2.ToString() == pato[0] && pj2.ToString() == pato[1] && pj2.ToString() == pato[2])      //1
                    {
                    
                        Console.WriteLine("RESULTADO: Gano:" + pjs);

                    }

                    else if (pj2.ToString() == pato[3] && pj2.ToString() == pato[4] && pj2.ToString() == pato[5]) //2
                    {
                
                        Console.WriteLine("RESULTADO: Gano:" + pjs);

                    }
                    else if (pj2.ToString() == pato[6] && pj2.ToString() == pato[7] && pj2.ToString() == pato[8]) //3
                    {
                        
                        Console.WriteLine("RESULTADO: Gano:" + pjs);

                    }

                    else if (pj2.ToString() == pato[0] && pj2.ToString() == pato[3] && pj2.ToString() == pato[6]) //4
                    {
                    
                        Console.WriteLine("RESULTADO: Gano:" + pjs);

                    }

                    else if (pj2.ToString() == pato[1] && pj2.ToString() == pato[4] && pj2.ToString() == pato[7]) //5
                    {
                       
                        Console.WriteLine("RESULTADO: Gano:" + pjs);

                    }

                    else if (pj2.ToString() == pato[2] && pj2.ToString() == pato[5] && pj2.ToString() == pato[8]) //6
                    {
                       
                        Console.WriteLine("RESULTADO: Gano:" + pjs);

                    }

                    else if (pj2.ToString() == pato[0] && pj2.ToString() == pato[4] && pj2.ToString() == pato[8]) //7
                    {
                       
                        Console.WriteLine("RESULTADO: Gano:" + pjs);

                    }

                    else if (pj2.ToString() == pato[2] && pj2.ToString() == pato[4] && pj2.ToString() == pato[6]) //8
                    {
                     
                        Console.WriteLine("RESULTADO: Gano:" + pjs);

                    }
                        else
                        {
                            int lleno = 0;
                            for (int i = 0; i < pato.Length; i++)
                            {
                                if (pato[i] != " ")
                                {

                                    lleno++;

                                }
                                if (lleno == 9)
                                {
                            
                                    Console.WriteLine("EMPATE");
                                }

                            }
                        }
                    Console.ReadKey();
                }

            }
        }
    }

