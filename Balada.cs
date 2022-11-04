using System;
public class Balada : Lugares {
    private int valorEntrada;
    private int qtdEspacos;
    private bool permiteFumar;
    private String djNome;

    public Balada (bool pagaEntrada){
    pagaEntrada = true;
    }
    public Balada(){
        QtdEspacos = qtdEspacos;
        PermiteFumar = permiteFumar;
        DjNome = djNome;
        ValorEntrada = valorEntrada;
    }

    public int ValorEntrada { 
        get => valorEntrada; 
        set => valorEntrada = value; 
    }
    public bool PermiteFumar { 
        get => permiteFumar; 
        set => permiteFumar = value; 
    }
    public int QtdEspacos { 
        get => qtdEspacos; 
        set => qtdEspacos = value; 
    }
    public string DjNome { 
        get => djNome; 
        set => djNome = value; 
    }

    public void anunciaDj(){
        Console.WriteLine($"Na balada {Nome} o Dj de hoje será: {DjNome}");
    }
}