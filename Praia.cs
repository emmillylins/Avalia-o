using System;
public class Praia : Lugares {
    private String previsaoTempo;

    public string PrevisaoTempo { 
        get => previsaoTempo; 
        set => previsaoTempo = value;
    }

    public Praia (bool pagaEntrada){
        pagaEntrada = false;
    }

    public Praia(){
        PrevisaoTempo = previsaoTempo;
    }
}