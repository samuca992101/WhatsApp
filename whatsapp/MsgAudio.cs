public class MsgAudio : Mensagem {
    public int Duracao { get; set; }

    public MsgAudio(Contatinho destinatario, string horaEnvio, string conteudo, int duracao)
        : base(destinatario, horaEnvio, conteudo) {
        Duracao = duracao;
    }

    public override string ToString() {
        return $"[Áudio] Para: {Destinatario.Nome} - {Conteudo} (Duração: {Duracao}s)";
    }
}
