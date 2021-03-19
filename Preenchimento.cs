using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Preenchimento
{
    public int contadordejogadas = 1;
    public string[] valor = new string[9];
    public bool[] valorb = new bool[9];
    public bool ganhou = false;
    public int comp = 0, jog = 0;


    public void Boasvindas()
    {
        Console.WriteLine("\n           BEM VINDO AO JOGO DA VELHA!!!");
        Console.WriteLine("||||||||||||||||||||||||||||||||||||||||||||||||||||||\n");
        Console.WriteLine(" ESTES SÃO OS NUMEROS QUE VOCÊ IRÁ DIGITAR PARA JOGAR\n\n");
        Console.WriteLine("                        PLACAR");
        Console.WriteLine("           JOGADOR: " + jog + "           COMPUTADOR: " + comp +"\n \n");

    }
    
    
    public void geral()
    {

        for (int i = 1; i <= 9; i++)
        {
            valor[i - 1] = Convert.ToString(i);

        }

        Console.WriteLine("                  |          |       ");
        Console.WriteLine("             " + valor[0] + "    |    " + valor[1] + "     |   " + valor[2] + "   ");
        Console.WriteLine("           -------|----------|-------");
        Console.WriteLine("             " + valor[3] + "    |    " + valor[4] + "     |   " + valor[5] + "   ");
        Console.WriteLine("           -------|----------|-------");
        Console.WriteLine("             " + valor[6] + "    |    " + valor[7] + "     |   " + valor[8] + "   ");
        Console.WriteLine("                  |          |       ");



    }

    public void limpartabuleiro()
    {

        for (int i = 1; i <= 9; i++)
        {
            valor[i - 1] = " ";
            valorb[i - 1] = false;
            contadordejogadas = 1;
            ganhou = false;

        }

        Console.WriteLine("                  |          |       ");
        Console.WriteLine("             " + valor[0] + "    |    " + valor[1] + "     |   " + valor[2] + "   ");
        Console.WriteLine("           -------|----------|-------");
        Console.WriteLine("             " + valor[3] + "    |    " + valor[4] + "     |   " + valor[5] + "   ");
        Console.WriteLine("           -------|----------|-------");
        Console.WriteLine("             " + valor[6] + "    |    " + valor[7] + "     |   " + valor[8] + "   ");
        Console.WriteLine("                  |          |       ");



    }

    public void preenchertabuleiro()
    {
        
        do
        {

            Console.WriteLine("      Escolha a posição que vc quer de 1 a 9");

            string escolha = Console.ReadLine();


            switch (escolha)
            {
                case "1":
                    if (valorb[0] == false)
                    {
                        valor[0] = "X";
                        atualizartabuleiro();
                        contadordejogadas++;
                        valorb[0] = true;
                        revificaseganhou();
                        if (ganhou == false)
                        {
                            escolhapc();
                            revificaseganhou();
                            if (ganhou == true)
                            {
                                contadordejogadas = 10;
                            }
                        }
                        else
                        {
                            contadordejogadas = 10;
                        }

                    }
                    else
                    {
                        Console.WriteLine("Você já jogou nessa posição");
                    }
                    break;

                case "2":
                    if (valorb[1] == false)
                    {
                        valor[1] = "X";
                        atualizartabuleiro();
                        contadordejogadas++;
                        valorb[1] = true;
                        revificaseganhou();
                        if (ganhou == false)
                        {
                            escolhapc();
                            revificaseganhou();
                            if (ganhou == true)
                            {
                                contadordejogadas = 10;
                            }
                        }
                        else
                        {
                            contadordejogadas = 10;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Você já jogou nessa posição");
                    }
                    break;

                case "3":
                    if (valorb[2] == false)
                    {
                        valor[2] = "X";
                        atualizartabuleiro();
                        contadordejogadas++;
                        valorb[2] = true;
                        revificaseganhou();
                        if (ganhou == false)
                        {
                            escolhapc();
                            revificaseganhou();
                            if (ganhou == true)
                            {
                                contadordejogadas = 10;
                            }
                        }
                        else
                        {
                            contadordejogadas = 10;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Você já jogou nessa posição");
                    }
                    break;

                case "4":
                    if (valorb[3] == false)
                    {
                        valor[3] = "X";
                        atualizartabuleiro();
                        contadordejogadas++;
                        valorb[3] = true;
                        revificaseganhou();
                        if (ganhou == false)
                        {
                            escolhapc();
                            revificaseganhou();
                            if (ganhou == true)
                            {
                                contadordejogadas = 10;
                            }
                        }
                        else
                        {
                            contadordejogadas = 10;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Você já jogou nessa posição");
                    }
                    break;

                case "5":
                    if (valorb[4] == false)
                    {
                        valor[4] = "X";
                        atualizartabuleiro();
                        contadordejogadas++;
                        valorb[4] = true;
                        revificaseganhou();
                        if (ganhou == false)
                        {
                            escolhapc();
                            revificaseganhou();
                            if (ganhou == true)
                            {
                                contadordejogadas = 10;
                            }
                        }
                        else
                        {
                            contadordejogadas = 10;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Você já jogou nessa posição");
                    }
                    break;

                case "6":
                    if (valorb[5] == false)
                    {
                        valor[5] = "X";
                        atualizartabuleiro();
                        contadordejogadas++;
                        valorb[5] = true;
                        revificaseganhou();
                        if (ganhou == false)
                        {
                            escolhapc();
                            revificaseganhou();
                            if (ganhou == true)
                            {
                                contadordejogadas = 10;
                            }
                        }
                        else
                        {
                            contadordejogadas = 10;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Você já jogou nessa posição");
                    }
                    break;

                case "7":
                    if (valorb[6] == false)
                    {
                        valor[6] = "X";
                        atualizartabuleiro();
                        contadordejogadas++;
                        valorb[6] = true;
                        revificaseganhou();
                        if (ganhou == false)
                        {
                            escolhapc();
                            revificaseganhou();
                            if (ganhou == true)
                            {
                                contadordejogadas = 10;
                            }
                        }
                        else
                        {
                            contadordejogadas = 10;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Você já jogou nessa posição");
                    }
                    break;

                case "8":
                    if (valorb[7] == false)
                    {
                        valor[7] = "X";
                        atualizartabuleiro();
                        contadordejogadas++;
                        valorb[7] = true;
                        revificaseganhou();
                        if (ganhou == false)
                        {
                            escolhapc();
                            revificaseganhou();
                            if (ganhou == true)
                            {
                                contadordejogadas = 10;
                            }
                        }
                        else
                        {
                            contadordejogadas = 10;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Você já jogou nessa posição");
                    }
                    break;

                case "9":
                    if (valorb[8] == false)
                    {
                        valor[8] = "X";
                        atualizartabuleiro();
                        contadordejogadas++;
                        valorb[8] = true;
                        revificaseganhou();
                        if (ganhou == false)
                        {
                            escolhapc();
                            revificaseganhou();
                            if (ganhou == true)
                            {
                                contadordejogadas = 10;
                            }
                        }
                        else
                        {
                            contadordejogadas = 10;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Você já jogou nessa posição");
                    }
                    break;

                default:
                    Console.WriteLine("              informação incorreta");
                    break;


            }

        } while (contadordejogadas <= 9);

        if (contadordejogadas >= 9 && ganhou == false){
            Console.WriteLine("                  DEU VELHA");
        }



    }

    public void atualizartabuleiro()
    {
        Console.Clear();
        Boasvindas();

        Console.WriteLine("                  |          |       ");
        Console.WriteLine("             " + valor[0] + "    |    " + valor[1] + "     |   " + valor[2] + "   ");
        Console.WriteLine("           -------|----------|-------");
        Console.WriteLine("             " + valor[3] + "    |    " + valor[4] + "     |   " + valor[5] + "   ");
        Console.WriteLine("           -------|----------|-------");
        Console.WriteLine("             " + valor[6] + "    |    " + valor[7] + "     |   " + valor[8] + "   ");
        Console.WriteLine("                  |          |       ");
    }
        public void escolhapc()
    {
        bool jacontou = true;

        if (contadordejogadas <= 9) 
        
        { 

            do
            {
                Random randnum = new Random();
                int escolha = Convert.ToInt32(randnum.Next(1, 9));

                switch (escolha)
                {
                    case 1:
                    if (valorb[0] == false)
                    {
                        valor[0] = "0";
                        atualizartabuleiro();
                        contadordejogadas++;
                        valorb[0] = true;
                        jacontou = false;
                    }

                    break;
                case 2:
                    if (valorb[1] == false)
                    {
                        valor[1] = "0";
                        atualizartabuleiro();
                        contadordejogadas++;
                        valorb[1] = true;
                        jacontou = false;
                    }

                    break;
                case 3:
                    if (valorb[2] == false)
                    {
                        valor[2] = "0";
                        atualizartabuleiro();
                        contadordejogadas++;
                        valorb[2] = true;
                        jacontou = false;
                    }

                    break;
                case 4:
                    if (valorb[3] == false)
                    {
                        valor[3] = "0";
                        atualizartabuleiro();
                        contadordejogadas++;
                        valorb[3] = true;
                        jacontou = false;
                    }

                    break;
                case 5:
                    if (valorb[4] == false)
                    {
                        valor[4] = "0";
                        atualizartabuleiro();
                        contadordejogadas++;
                        valorb[4] = true;
                        jacontou = false;
                    }
                    break;
                case 6:
                    if (valorb[5] == false)
                    {
                        valor[5] = "0";
                        atualizartabuleiro();
                        contadordejogadas++;
                        valorb[5] = true;
                        jacontou = false;
                    }

                    break;
                case 7:
                    if (valorb[6] == false)
                    {
                        valor[6] = "0";
                        atualizartabuleiro();
                        contadordejogadas++;
                        valorb[6] = true;
                        jacontou = false;
                    }

                    break;
                case 8:
                    if (valorb[7] == false)
                    {
                        valor[7] = "0";
                        atualizartabuleiro();
                        contadordejogadas++;
                        valorb[7] = true;
                        jacontou = false;
                    }

                    break;
                case 9:
                    if (valorb[8] == false)
                    {
                        valor[8] = "0";
                        atualizartabuleiro();
                        contadordejogadas++;
                        valorb[8] = true;
                        jacontou = false;
                    }


                    break;
                }


            }while(jacontou == true);

        }
    }

    public void revificaseganhou()
    {
        if ((valor[0] == valor[1] && valor[1] == valor[2] && valor[0] == "X") || (valor[0] == valor[1] && valor[1] == valor[2] && valor[0] == "0"))
        {
            if (valor[0] == "X")
            {
                Console.WriteLine("              Parabéns você ganhou!");
                ganhou = true;
                jog++;
            }
            else
            {
                Console.WriteLine("          Que pena, o computador ganhou");
                ganhou = true;
                comp++;
            }

        }
        else if ((valor[3] == valor[4] && valor[4] == valor[5] && valor[3] == "X") || (valor[3] == valor[4] && valor[4] == valor[5] && valor[3] == "0")) 
        {
            if (valor[3] == "X")
            {
                Console.WriteLine("              Parabéns você ganhou!");
                ganhou = true;
                jog = jog + 1;
            }
            else
            {
                Console.WriteLine("          Que pena, o computador ganhou");
                ganhou = true;
                comp++;
            }

        }
        else if ((valor[6] == valor[7] && valor[7] == valor[8] && valor[6] == "X") || (valor[6] == valor[7] && valor[7] == valor[8] && valor[6] == "0"))
        {
            if (valor[6] == "X")
            {
                Console.WriteLine("              Parabéns você ganhou!");
                ganhou = true;
                jog = jog + 1;
            }
            else
            {
                Console.WriteLine("          Que pena, o computador ganhou");
                ganhou = true;
                jog = jog + 1;
            }

        }
        else if ((valor[0] == valor[3] && valor[3] == valor[6] && valor[0] == "X") || (valor[0] == valor[3] && valor[3] == valor[6] && valor[0] == "0"))
        {
            if (valor[0] == "X")
            {
                Console.WriteLine("              Parabéns você ganhou!");
                ganhou = true;
                jog = jog + 1;
            }
            else
            {
                Console.WriteLine("          Que pena, o computador ganhou");
                ganhou = true;
                comp++;
            }

        }
        else if ((valor[1] == valor[4] && valor[4] == valor[7] && valor[1] == "X") || (valor[1] == valor[4] && valor[4] == valor[7] && valor[1] == "0"))
        {
            if (valor[1] == "X")
            {
                Console.WriteLine("              Parabéns você ganhou!");
                ganhou = true;
                jog = jog + 1;
            }
            else
            {
                Console.WriteLine("          Que pena, o computador ganhou");
                ganhou = true;
                comp++;
            }

        }
        else if ((valor[8] == valor[5] && valor[5] == valor[2] && valor[8] == "X") || (valor[8] == valor[5] && valor[5] == valor[2] && valor[8] == "0"))
        {
            if (valor[8] == "X")
            {
                Console.WriteLine("              Parabéns você ganhou!");
                ganhou = true;
                jog = jog + 1;
            }
            else
            {
                Console.WriteLine("          Que pena, o computador ganhou");
                ganhou = true;
                comp++;
            }

        }
        else if ((valor[0] == valor[4] && valor[4] == valor[8] && valor[8] == "X") || (valor[0] == valor[4] && valor[4] == valor[8] && valor[8] == "0"))
        {
            if (valor[0] == "X")
            {
                Console.WriteLine("              Parabéns você ganhou!");
                ganhou = true;
                jog = jog + 1;
            }
            else
            {
                Console.WriteLine("          Que pena, o computador ganhou");
                ganhou = true;
                comp++;
            }

        }
        else if ((valor[6] == valor[4] && valor[4] == valor[2] && valor[6] == "X") || (valor[6] == valor[4] && valor[4] == valor[2] && valor[6] == "0"))
        {
            if (valor[6] == "X")
            {
                Console.WriteLine("              Parabéns você ganhou!");
                ganhou = true;
                jog = jog + 1;
            }
            else
            {
                Console.WriteLine("          Que pena, o computador ganhou");
                ganhou = true;
                comp++;
            }

        }
    }

}