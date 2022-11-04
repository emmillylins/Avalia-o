using System;

public class Lugares {
    private String nome;
    private String endereco;
    private bool pagaEntrada;

    public Lugares(){
        Nome = nome;
        Endereco = endereco;
        PagaEntrada = pagaEntrada;
    }

    public string Endereco { 
        get => endereco; 
        set => endereco = value; 
    }
    public string Nome { 
        get => nome; 
        set => nome = value; 
    }
    public bool PagaEntrada { 
        set => pagaEntrada = value; 
    }

    public void mostraLugar() {
        Console.WriteLine("Nome: " + Nome + "\nEndereço: " + Endereco);
    }
}