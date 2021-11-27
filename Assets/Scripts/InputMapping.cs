using UnityEngine;
using System.Collections;

public class InputMapping : MonoBehaviour {

    private GameControllerInputs controllerInput;

    void Start () {
		controllerInput = GameControllerInputs.GetIstance();
	}

    // Métodos chamados por qualquer objeto usando o script GameControllerInputs para realizar seu movimento

    // Obtenha a entrada para ir para a direita em uma velocidade fixa
    public bool GoRight ()
    {
        if (controllerInput.DPad_Right || Input.GetKey(KeyCode.RightArrow))
            return true;
        else
            return false;
    }

    // Obtenha a entrada para ir para a esquerda e para a direita em uma velocidade variável, dependendo do movimento do manípulo direcional.
    public float GoHorizontalAnalog()
    {
        return controllerInput.LeftDirectional_Horizontal;
    }

    // Obtenha entrada para ir para a esquerda a uma velocidade fixa
    public bool GoLeft()
    {
        if (controllerInput.DPad_Left || Input.GetKey(KeyCode.LeftArrow))
            return true;
        else
            return false;
    }

    // Obtenha dados para subir a uma velocidade fixa
    public bool GoUp()
    {
        if (controllerInput.DPad_Up || controllerInput.LeftDirectional_asUpButton || Input.GetKey(KeyCode.UpArrow))
            return true;
        else
            return false;
    }

    // Obtenha a entrada para descer a uma velocidade fixa
    public bool GoDown()
    {
        if (controllerInput.DPad_Down || controllerInput.LeftDirectional_asDownButton || Input.GetKey(KeyCode.DownArrow))
            return true;
        else
            return false;
    }

    // Get Input toJump (usado apenas pela garota)
    public bool JumpNow()
    {
        if (controllerInput.A_button_down || Input.GetKeyDown(KeyCode.Space))
            return true;
        else
            return false;
    }

    // Obtenha informações para atacar (usado apenas pela garota)
    public bool AttackNow()
    {
        if (controllerInput.X_button_down || Input.GetKeyDown(KeyCode.F))
            return true;
        else
            return false;
    }

    public bool DuckNow()
    {
        return false;
    }

    // Obtenha informações para definir a garota como o personagem ativo.
    public bool ChangeToAlien()
    {
        if (controllerInput.LB_down || Input.GetKeyDown(KeyCode.Alpha1))
            return true;
        else
            return false;

    }

    // Obtenha informações para definir o zumbi como o personagem ativo.
    public bool ChangeToShip()
    {
        if (controllerInput.RB_down || Input.GetKeyDown(KeyCode.Alpha2))
            return true;
        else
            return false;
    }

    // Obter entrada (pressione o botão para baixo) para atirar uma moeda para baixo (usado apenas pelo zumbi)
    public bool ShootCoinDown()
    {
        if (controllerInput.RightDir_press_down || Input.GetKeyDown(KeyCode.Space))
            return true;
        else
            return false;
    }

    // Obter entrada (botão de liberação) para atirar uma moeda para cima (usado apenas pelo zumbi)
    public bool ShootCoinUp()
    {
        if (controllerInput.RightDir_press_up || Input.GetKeyUp(KeyCode.Space))
            return true;
        else
            return false;
    }
}
