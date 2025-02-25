using UnityEngine;

public class GameStateManager:MonoBehaviour
{
    GameBaseState currentState;

    public TelaInicialGameState telaInicialState = new TelaInicialGameState();
    public TelaCreditosGameState telaCreditosState = new TelaCreditosGameState();
    
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
