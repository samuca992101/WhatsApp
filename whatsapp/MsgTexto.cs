public class MsgTexto : Mensagem {
    public int NumChar { get; set; }

    public MsgTexto(Contatinho destinatario, string horaEnvio, string conteudo, int numChar)
        : base(destinatario, horaEnvio, conteudo) {
        NumChar = numChar;
    }

    public override string ToString() {
        return $"[Texto] Para: {Destinatario.Nome} - {Conteudo} ({NumChar} caracteres)";
    }
}
