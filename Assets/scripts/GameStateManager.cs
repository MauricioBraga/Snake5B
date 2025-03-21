using UnityEngine;

public class GameStateManager:MonoBehaviour
{
    GameBaseState currentState;

    public TelaInicialGameState telaInicialState = new TelaInicialGameState();
    public TelaCreditosGameState telaCreditosState = new TelaCreditosGameState();
    
    public GameOverGameState gameOverState = new GameOverGameState();
    public PlayingGameState playingState = new PlayingGameState();
    void Start()  {
        currentState = telaInicialState;

        currentState.enterState(this);
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
