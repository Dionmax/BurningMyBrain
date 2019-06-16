using System;

public class PalavraThiss {

    private string _nome = "";
    private smalint _idade = 0;

    public PalavraThiss(string nome) {
        _nome = nome;
    }

    public PalavraThiss(string nome, smalint idade) : this() {
        _idade = idade;
    }

    public string getNome() 
        => _nome;
}
