using System;
public class Cinema : Lugares {
    private int valorEntrada;
    private float nota;


    public Cinema (bool pagaEntrada){
        pagaEntrada = true;
    }

       public int ValorEntrada { 
        get => valorEntrada; 
        set => valorEntrada = value; 
    }
    public float Nota { 
        get => nota; 
        set => nota = value; 
    }

    public Cinema (){
        ValorEntrada = valorEntrada;
        Nota = nota;
    }

    public void abrir(){
        Console.WriteLine($"O cinema {Nome} acaba de iniciar exibição...");
    }

    public void fechar(){
        Console.WriteLine($"O cinema {Nome} está fechando...");
    }
}