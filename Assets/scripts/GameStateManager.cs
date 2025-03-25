using UnityEngine;

public class GameStateManager:MonoBehaviour
{
    GameBaseState currentState;

    public GameObject player;
    public GameObject food;

    public GameObject parede1;
    public GameObject parede2;

    public GameObject parede3;

    public GameObject parede4;

    public TelaInicialGameState telaInicialState = new TelaInicialGameState();
    public TelaCreditosGameState telaCreditosState = new TelaCreditosGameState();
    
    public GameOverGameState gameOverState = new GameOverGameState();
    public PlayingGameState playingState = new PlayingGameState();
    void Start()  {
        currentState = telaInicialState;

        currentState.enterState(this);
    }


    public void AtivarElementosJogo(bool b)  {
        player.GetComponent<SpriteRenderer>().enabled = b;
        player.GetComponent<Snake>().setAtivo(b);
        food.GetComponent<SpriteRenderer>().enabled = b;
        parede1.GetComponent<SpriteRenderer>().enabled = b;
        parede2.GetComponent<SpriteRenderer>().enabled = b;
        parede3.GetComponent<SpriteRenderer>().enabled = b;
        parede4.GetComponent<SpriteRenderer>().enabled = b;
    
    }
    void Update()  {
        currentState.updateState(this);
    }

    public void switchState(GameBaseState state)  {
        currentState.leaveState(this);

        currentState = state;

        currentState.enterState(this);
    }
}
