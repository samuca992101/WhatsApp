using System;
using System.Collections.Generic;

public class Whatsapp {
    public List<Contatinho> Contatos { get; set; } = new List<Contatinho>();
    public List<Mensagem> Mensagens { get; set; } = new List<Mensagem>();

    public void ListarContatos() {
        Console.WriteLine("=== Lista de Contatos ===");
        foreach (var contato in Contatos) {
            Console.WriteLine($"Nome: {contato.Nome}, Celular: {contato.Celular}");
        }
    }

    public void ListarMensagens() {
        Console.WriteLine("=== Lista de Mensagens ===");
        foreach (var mensagem in Mensagens) {
            Console.WriteLine(mensagem.ToString());
        }
    }
}
