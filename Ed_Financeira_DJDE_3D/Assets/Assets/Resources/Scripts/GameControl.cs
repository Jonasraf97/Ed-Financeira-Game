using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TMPro;

public class GameControl : MonoBehaviour {

    private static GameObject whoWinsTextShadow, player1MoveText, player2MoveText;

    private static GameObject player1, player2;

    public bool jogador1PainelResolved = false;

    public bool jogador2PainelResolved = false;

    public bool jogador1Reset = false; //ainda nao resolvido

    public bool jogador2Reset = false; //ainda nao resolvido

    public static int player1StartWaypoint = 0;
    public static int player2StartWaypoint = 0;

    public static bool gameOver = false;

    public static bool vezdoJogador1;

    public static bool vezdoJogador2;

    public static bool jogador1Respondeuaquest;

    public static bool jogador2Respondeuaquest;

    public static int diceSideThrown = 0;

    public GameObject painelEvento;

    public GameObject painelEvento2;

    public GameObject painelEvento3;

    public GameObject painelEvento4;

    public GameObject limiteCartao;

    public float dinheiroJogador1;

    public float dinheiroJogador2;

    public TextMeshProUGUI dinheiroTxtJogador1;

    public TextMeshProUGUI dinheiroTxtJogador2;

    public float limitecartaoJogador1;

    public float limitecartaoJogador2;

    public TextMeshProUGUI limitecartaoTxtJogador1;

    public TextMeshProUGUI limitecartaoTxtJogador2;

    public float medalhasJogador1;

    public float medalhasJogador2;

    public TextMeshProUGUI medalhasTxtJogador1;

    public TextMeshProUGUI medalhasTxtJogador2;

    // Use this for initialization
    void Start()
    {
        whoWinsTextShadow = GameObject.Find("QuemVenceu");
        player1MoveText = GameObject.Find("VezJogador1");
        player2MoveText = GameObject.Find("VezJogador2");

        player1 = GameObject.Find("Jogador1");
        player2 = GameObject.Find("Jogador2");

        player1.GetComponent<FollowThePath>().moveAllowed = false;
        player2.GetComponent<FollowThePath>().moveAllowed = false;

        //whoWinsTextShadow.gameObject.SetActive(false);
        player1MoveText.gameObject.SetActive(true);
        player2MoveText.gameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        limitecartaoTxtJogador1.text = limitecartaoJogador1.ToString("N"); //Cod pra transformar o limite do cartao em TXT no HUD

        limitecartaoTxtJogador2.text = limitecartaoJogador2.ToString("N");

        dinheiroTxtJogador1.text = dinheiroJogador1.ToString("N"); //Cod pra transformar o dinheiro em TXT no HUD

        dinheiroTxtJogador2.text = dinheiroJogador2.ToString("N");

        medalhasTxtJogador1.text = medalhasJogador1.ToString();

        medalhasTxtJogador2.text = medalhasJogador2.ToString();

        // CONTROLE GERAL DO ANDAR NO TABULEIRO

        print("Index " + player1.GetComponent<FollowThePath>().waypointIndex);
        print("StartWaypoint " + player1StartWaypoint);
        print("Length " + player1.GetComponent<FollowThePath>().waypoints.Length);

        if (player1.GetComponent<FollowThePath>().waypointIndex >
            player1StartWaypoint + diceSideThrown)
        {
            player1.GetComponent<FollowThePath>().moveAllowed = false;
            player1MoveText.gameObject.SetActive(false);
            player2MoveText.gameObject.SetActive(true);
            player1StartWaypoint = player1.GetComponent<FollowThePath>().waypointIndex - 1;
        }

        if (player2.GetComponent<FollowThePath>().waypointIndex >
            player2StartWaypoint + diceSideThrown)
        {
            player2.GetComponent<FollowThePath>().moveAllowed = false;
            player2MoveText.gameObject.SetActive(false);
            player1MoveText.gameObject.SetActive(true);
            player2StartWaypoint = player2.GetComponent<FollowThePath>().waypointIndex - 1;
        }

        if (player1.GetComponent<FollowThePath>().waypointIndex ==
            player1.GetComponent<FollowThePath>().waypoints.Length)
        {
            player1.GetComponent<FollowThePath>().waypointIndex = 0;
            player1StartWaypoint = player1.GetComponent<FollowThePath>().waypointIndex - 1;
        }

        if (player2.GetComponent<FollowThePath>().waypointIndex ==
            player2.GetComponent<FollowThePath>().waypoints.Length)
        {
            player2.GetComponent<FollowThePath>().waypointIndex = 0;
            player2StartWaypoint = player2.GetComponent<FollowThePath>().waypointIndex - 1;
        }

        // 02.06.2021 JOGADOR 1

        if (player1.GetComponent<FollowThePath>().moveAllowed == false && player1.GetComponent<FollowThePath>().waypointIndex == 2
            && vezdoJogador1 == true && jogador1Respondeuaquest == false && jogador1Reset == false)
        {
            painelEvento.SetActive(true);
            print("Painel Ativo");
        }

        if (player1.GetComponent<FollowThePath>().moveAllowed == false && player1.GetComponent<FollowThePath>().waypointIndex == 3
            && vezdoJogador1 == true && jogador1Respondeuaquest == false)
        {
            painelEvento2.SetActive(true);
            print("Painel Ativo");
        }

        if (player1.GetComponent<FollowThePath>().moveAllowed == false && player1.GetComponent<FollowThePath>().waypointIndex == 4
            && vezdoJogador1 == true && jogador1Respondeuaquest == false)
        {
            painelEvento.SetActive(true);
            print("Painel Ativo");

        }

        if (player1.GetComponent<FollowThePath>().moveAllowed == false && player1.GetComponent<FollowThePath>().waypointIndex == 5
            && vezdoJogador1 == true && jogador1Respondeuaquest == false)
        {
            painelEvento2.SetActive(true);
            print("Painel Ativo");
        }


        if (player1.GetComponent<FollowThePath>().moveAllowed == false && player1.GetComponent<FollowThePath>().waypointIndex == 6
            && vezdoJogador1 == true && jogador1Respondeuaquest == false)
        {
            painelEvento.SetActive(true);
            print("Painel Ativo");
        }

        if (player1.GetComponent<FollowThePath>().moveAllowed == false && player1.GetComponent<FollowThePath>().waypointIndex == 7
            && vezdoJogador1 == true && jogador1Respondeuaquest == false)
        {
            painelEvento3.SetActive(true);
            print("Painel Ativo");
        }

        if (player1.GetComponent<FollowThePath>().moveAllowed == false && player1.GetComponent<FollowThePath>().waypointIndex == 8
            && vezdoJogador1 == true && jogador1Respondeuaquest == false)
        {
            painelEvento3.SetActive(true);
            print("Painel Ativo");
        }

        if (player1.GetComponent<FollowThePath>().moveAllowed == false && player1.GetComponent<FollowThePath>().waypointIndex == 9
            && vezdoJogador1 == true && jogador1Respondeuaquest == false)
        {
            painelEvento3.SetActive(true);
            print("Painel Ativo");
        }

        if (player1.GetComponent<FollowThePath>().moveAllowed == false && player1.GetComponent<FollowThePath>().waypointIndex == 10
            && vezdoJogador1 == true && jogador1Respondeuaquest == false)
        {
            painelEvento3.SetActive(true);
            print("Painel Ativo");
        }

        if (player1.GetComponent<FollowThePath>().moveAllowed == false && player1.GetComponent<FollowThePath>().waypointIndex == 11
            && vezdoJogador1 == true && jogador1Respondeuaquest == false)
        {
            painelEvento3.SetActive(true);
            print("Painel Ativo");
        }

        if (player1.GetComponent<FollowThePath>().moveAllowed == false && player1.GetComponent<FollowThePath>().waypointIndex == 12
            && vezdoJogador1 == true && jogador1Respondeuaquest == false)
        {
            painelEvento3.SetActive(true);
            print("Painel Ativo");
        }

        if (player1.GetComponent<FollowThePath>().moveAllowed == false && player1.GetComponent<FollowThePath>().waypointIndex == 13
            && vezdoJogador1 == true && jogador1Respondeuaquest == false)
        {
            painelEvento3.SetActive(true);
            print("Painel Ativo");
        }

        if (player1.GetComponent<FollowThePath>().moveAllowed == false && player1.GetComponent<FollowThePath>().waypointIndex == 14
            && vezdoJogador1 == true && jogador1Respondeuaquest == false)
        {
            painelEvento4.SetActive(true);
            print("Painel Ativo");
        }

        if (player1.GetComponent<FollowThePath>().moveAllowed == false && player1.GetComponent<FollowThePath>().waypointIndex == 15
            && vezdoJogador1 == true && jogador1Respondeuaquest == false)
        {
            painelEvento4.SetActive(true);
            print("Painel Ativo");
        }

        if (player1.GetComponent<FollowThePath>().moveAllowed == false && player1.GetComponent<FollowThePath>().waypointIndex == 16
            && vezdoJogador1 == true && jogador1Respondeuaquest == false)
        {
            painelEvento4.SetActive(true);
            print("Painel Ativo");
        }

        if (player1.GetComponent<FollowThePath>().moveAllowed == false && player1.GetComponent<FollowThePath>().waypointIndex == 17
            && vezdoJogador1 == true && jogador1Respondeuaquest == false)
        {
            painelEvento4.SetActive(true);
            print("Painel Ativo");
        }

        if (player1.GetComponent<FollowThePath>().moveAllowed == false && player1.GetComponent<FollowThePath>().waypointIndex == 18
            && vezdoJogador1 == true && jogador1Respondeuaquest == false)
        {
            painelEvento4.SetActive(true);
            print("Painel Ativo");
        }

        if (player1.GetComponent<FollowThePath>().moveAllowed == false && player1.GetComponent<FollowThePath>().waypointIndex == 19
            && vezdoJogador1 == true && jogador1Respondeuaquest == false)
        {
            painelEvento4.SetActive(true);
            print("Painel Ativo");
        }

        if (player1.GetComponent<FollowThePath>().moveAllowed == false && player1.GetComponent<FollowThePath>().waypointIndex == 20
            && vezdoJogador1 == true && jogador1Respondeuaquest == false)
        {
            painelEvento4.SetActive(true);
            print("Painel Ativo");
        }

        if (player1.GetComponent<FollowThePath>().moveAllowed == false && player1.GetComponent<FollowThePath>().waypointIndex == 21
            && vezdoJogador1 == true && jogador1Respondeuaquest == false)
        {
            painelEvento4.SetActive(true);
            print("Painel Ativo");
        }

        if (player1.GetComponent<FollowThePath>().moveAllowed == false && player1.GetComponent<FollowThePath>().waypointIndex == 22
            && vezdoJogador1 == true && jogador1Respondeuaquest == false)
        {
            painelEvento4.SetActive(true);
            print("Painel Ativo");
        }

        if (player1.GetComponent<FollowThePath>().moveAllowed == false && player1.GetComponent<FollowThePath>().waypointIndex == 23
            && vezdoJogador1 == true && jogador1Respondeuaquest == false)
        {
            painelEvento4.SetActive(true);
            print("Painel Ativo");
        }

        if (player1.GetComponent<FollowThePath>().moveAllowed == false && player1.GetComponent<FollowThePath>().waypointIndex >= 24
            && vezdoJogador1 == true && jogador1Respondeuaquest == false)
        {
            painelEvento4.SetActive(true);
            print("Painel Ativo");
        }

        if (player1.GetComponent<FollowThePath>().moveAllowed == false && player1.GetComponent<FollowThePath>().waypointIndex == 1
    && vezdoJogador1 == true && jogador1Reset == true)
        {
            jogador1Reset = false;
        }

        if (player1.GetComponent<FollowThePath>().moveAllowed == false && player1.GetComponent<FollowThePath>().waypointIndex == 0
    && vezdoJogador1 == true && jogador1Reset == false)
        {
            print("Recomeço");
        }


        // 01.07.2021 - JOGADOR 2

        if (player2.GetComponent<FollowThePath>().moveAllowed == false && player2.GetComponent<FollowThePath>().waypointIndex == 2
            && vezdoJogador2 == true && jogador2Respondeuaquest == false && jogador2Reset == false)
        {
            painelEvento.SetActive(true);
            print("Painel Ativo");
        }

        if (player2.GetComponent<FollowThePath>().moveAllowed == false && player2.GetComponent<FollowThePath>().waypointIndex == 3
            && vezdoJogador2 == true && jogador2Respondeuaquest == false)
        {
            painelEvento2.SetActive(true);
            print("Painel Ativo");
        }

        if (player2.GetComponent<FollowThePath>().moveAllowed == false && player2.GetComponent<FollowThePath>().waypointIndex == 4
            && vezdoJogador2 == true && jogador2Respondeuaquest == false)
        {
            painelEvento.SetActive(true);
            print("Painel Ativo");

        }

        if (player2.GetComponent<FollowThePath>().moveAllowed == false && player2.GetComponent<FollowThePath>().waypointIndex == 5
            && vezdoJogador2 == true && jogador2Respondeuaquest == false)
        {
            painelEvento2.SetActive(true);
            print("Painel Ativo");
        }


        if (player2.GetComponent<FollowThePath>().moveAllowed == false && player2.GetComponent<FollowThePath>().waypointIndex == 6
            && vezdoJogador2 == true && jogador2Respondeuaquest == false)
        {
            painelEvento.SetActive(true);
            print("Painel Ativo");
        }

        if (player2.GetComponent<FollowThePath>().moveAllowed == false && player2.GetComponent<FollowThePath>().waypointIndex == 7
            && vezdoJogador2 == true && jogador2Respondeuaquest == false)
        {
            painelEvento3.SetActive(true);
            print("Painel Ativo");
        }

        if (player2.GetComponent<FollowThePath>().moveAllowed == false && player2.GetComponent<FollowThePath>().waypointIndex == 8
            && vezdoJogador2 == true && jogador2Respondeuaquest == false)
        {
            painelEvento3.SetActive(true);
            print("Painel Ativo");
        }

        if (player2.GetComponent<FollowThePath>().moveAllowed == false && player2.GetComponent<FollowThePath>().waypointIndex == 9
            && vezdoJogador2 == true && jogador2Respondeuaquest == false)
        {
            painelEvento3.SetActive(true);
            print("Painel Ativo");
        }

        if (player2.GetComponent<FollowThePath>().moveAllowed == false && player2.GetComponent<FollowThePath>().waypointIndex == 10
            && vezdoJogador2 == true && jogador2Respondeuaquest == false)
        {
            painelEvento3.SetActive(true);
            print("Painel Ativo");
        }

        if (player2.GetComponent<FollowThePath>().moveAllowed == false && player2.GetComponent<FollowThePath>().waypointIndex == 11
            && vezdoJogador2 == true && jogador2Respondeuaquest == false)
        {
            painelEvento3.SetActive(true);
            print("Painel Ativo");
        }

        if (player2.GetComponent<FollowThePath>().moveAllowed == false && player2.GetComponent<FollowThePath>().waypointIndex == 12
            && vezdoJogador2 == true && jogador2Respondeuaquest == false)
        {
            painelEvento3.SetActive(true);
            print("Painel Ativo");
        }

        if (player2.GetComponent<FollowThePath>().moveAllowed == false && player2.GetComponent<FollowThePath>().waypointIndex == 13
            && vezdoJogador2 == true && jogador2Respondeuaquest == false)
        {
            painelEvento3.SetActive(true);
            print("Painel Ativo");
        }

        if (player2.GetComponent<FollowThePath>().moveAllowed == false && player2.GetComponent<FollowThePath>().waypointIndex == 14
            && vezdoJogador2 == true && jogador2Respondeuaquest == false)
        {
            painelEvento4.SetActive(true);
            print("Painel Ativo");
        }

        if (player2.GetComponent<FollowThePath>().moveAllowed == false && player2.GetComponent<FollowThePath>().waypointIndex == 15
            && vezdoJogador2 == true && jogador2Respondeuaquest == false)
        {
            painelEvento4.SetActive(true);
            print("Painel Ativo");
        }

        if (player2.GetComponent<FollowThePath>().moveAllowed == false && player2.GetComponent<FollowThePath>().waypointIndex == 16
            && vezdoJogador2 == true && jogador2Respondeuaquest == false)
        {
            painelEvento4.SetActive(true);
            print("Painel Ativo");
        }

        if (player2.GetComponent<FollowThePath>().moveAllowed == false && player2.GetComponent<FollowThePath>().waypointIndex == 17
            && vezdoJogador2 == true && jogador2Respondeuaquest == false)
        {
            painelEvento4.SetActive(true);
            print("Painel Ativo");
        }

        if (player2.GetComponent<FollowThePath>().moveAllowed == false && player2.GetComponent<FollowThePath>().waypointIndex == 18
            && vezdoJogador2 == true && jogador2Respondeuaquest == false)
        {
            painelEvento4.SetActive(true);
            print("Painel Ativo");
        }

        if (player2.GetComponent<FollowThePath>().moveAllowed == false && player2.GetComponent<FollowThePath>().waypointIndex == 19
            && vezdoJogador2 == true && jogador2Respondeuaquest == false)
        {
            painelEvento4.SetActive(true);
            print("Painel Ativo");
        }

        if (player2.GetComponent<FollowThePath>().moveAllowed == false && player2.GetComponent<FollowThePath>().waypointIndex == 20
            && vezdoJogador2 == true && jogador2Respondeuaquest == false)
        {
            painelEvento4.SetActive(true);
            print("Painel Ativo");
        }

        if (player2.GetComponent<FollowThePath>().moveAllowed == false && player2.GetComponent<FollowThePath>().waypointIndex == 21
            && vezdoJogador2 == true && jogador2Respondeuaquest == false)
        {
            painelEvento4.SetActive(true);
            print("Painel Ativo");
        }

        if (player2.GetComponent<FollowThePath>().moveAllowed == false && player2.GetComponent<FollowThePath>().waypointIndex == 22
            && vezdoJogador2 == true && jogador2Respondeuaquest == false)
        {
            painelEvento4.SetActive(true);
            print("Painel Ativo");
        }

        if (player2.GetComponent<FollowThePath>().moveAllowed == false && player2.GetComponent<FollowThePath>().waypointIndex == 23
            && vezdoJogador2 == true && jogador2Respondeuaquest == false)
        {
            painelEvento4.SetActive(true);
            print("Painel Ativo");
        }

        if (player2.GetComponent<FollowThePath>().moveAllowed == false && player2.GetComponent<FollowThePath>().waypointIndex >= 24
            && vezdoJogador2 == true && jogador2Respondeuaquest == false)
        {
            painelEvento4.SetActive(true);
            print("Painel Ativo");
        }

        if (player2.GetComponent<FollowThePath>().moveAllowed == false && player2.GetComponent<FollowThePath>().waypointIndex == 1
            && vezdoJogador2 == true && jogador2Reset == true)
        {
            jogador2Reset = false;
        }

        if (player2.GetComponent<FollowThePath>().moveAllowed == false && player2.GetComponent<FollowThePath>().waypointIndex == 0
            && vezdoJogador2 == true && jogador2Reset == false)
        {
            print("Recomeço");
        }
    }

    //FIM DO CONTROLE DE CASAS

    public static void MovePlayer(int playerToMove)
    {
        vezdoJogador1 = false;
        vezdoJogador2 = false;
        switch (playerToMove) 
        { 
            case 1:
                jogador1Respondeuaquest = false;
                player1.GetComponent<FollowThePath>().moveAllowed = true;
                vezdoJogador1 = true;
                print("Vez do Jogador 1");
                break;

            case 2:
                jogador2Respondeuaquest = false;
                player2.GetComponent<FollowThePath>().moveAllowed = true;
                vezdoJogador2 = true;
                print("Vez do Jogador 2");
                break;
        }
    }

    public void Evento1BtnSim()
    {
        if (vezdoJogador1 == true && vezdoJogador2 == false)
        {
            dinheiroJogador1 = dinheiroJogador1 + 700;
            jogador1PainelResolved = true;
            painelEvento.SetActive(false);
            jogador1Respondeuaquest = true;
            print("Painel fechado");
        }
        if (vezdoJogador2 == true && vezdoJogador1 == false)
        {
            dinheiroJogador2 = dinheiroJogador2 + 700;
            jogador2PainelResolved = true;
            painelEvento.SetActive(false);
            jogador2Respondeuaquest = true;
            print("Painel fechado");
        }
    }

    public void Evento1BtnNao()
    {
        if (vezdoJogador1 == true && vezdoJogador2 == false)
        {
            jogador1PainelResolved = true;
            painelEvento.SetActive(false);
            jogador1Respondeuaquest = true;
            print("Painel fechado");
        }
        if (vezdoJogador2 == true && vezdoJogador1 == false)
        {
            jogador2PainelResolved = true;
            painelEvento.SetActive(false);
            jogador2Respondeuaquest = true;
            print("Painel fechado");
        }
    }

    public void Evento2BtnSim()
    {
        if (vezdoJogador1 == true && vezdoJogador2 == false)
        {
            limiteCartao.gameObject.SetActive(true);
            limitecartaoTxtJogador1.gameObject.SetActive(true);
            limitecartaoJogador1 = limitecartaoJogador1 + 200;
            jogador1PainelResolved = true;
            painelEvento2.SetActive(false);
            jogador1Respondeuaquest = true;
            print("Painel fechado");
        }
        if (vezdoJogador2 == true && vezdoJogador1 == false)
        {
            limiteCartao.gameObject.SetActive(true);
            limitecartaoTxtJogador2.gameObject.SetActive(true);
            limitecartaoJogador2 = limitecartaoJogador2 + 200;
            jogador2PainelResolved = true;
            painelEvento2.SetActive(false);
            jogador2Respondeuaquest = true;
            print("Painel fechado");
        }

    }

    public void Evento2BtnNao()
    {
        if (vezdoJogador1 == true && vezdoJogador2 == false)
        {
            jogador1PainelResolved = true;
            painelEvento2.SetActive(false);
            jogador1Respondeuaquest = true;
            print("Painel fechado");
        }
        if (vezdoJogador2 == true && vezdoJogador1 == false)
        {
            jogador2PainelResolved = true;
            painelEvento2.SetActive(false);
            jogador2Respondeuaquest = true;
            print("Painel fechado");
        }
    }

    public void Evento3Oba()
    {
        if (vezdoJogador1 == true && vezdoJogador2 == false)
        {
            medalhasJogador1 = medalhasJogador1 + 1;
            jogador1PainelResolved = true;
            painelEvento3.SetActive(false);
            jogador1Respondeuaquest = true;
            print("Painel fechado");
        }
        if (vezdoJogador2 == true && vezdoJogador1 == false)
        {
            medalhasJogador2 = medalhasJogador2 + 1;
            jogador2PainelResolved = true;
            painelEvento3.SetActive(false);
            jogador2Respondeuaquest = true;
            print("Painel fechado");
        }
    }

    public void Evento4Prejuizo()
    {
        if (vezdoJogador1 == true && vezdoJogador2 == false)
        {
            dinheiroJogador1 = dinheiroJogador1 - 50;
            jogador1PainelResolved = true;
            painelEvento4.SetActive(false);
            jogador1Respondeuaquest = true;
            print("Painel fechado");
        }
        if (vezdoJogador2 == true && vezdoJogador1 == false)
        {
            dinheiroJogador2 = dinheiroJogador2 - 50;
            jogador2PainelResolved = true;
            painelEvento4.SetActive(false);
            jogador2Respondeuaquest = true;
            print("Painel fechado");
        }
    }

}
