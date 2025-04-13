public class MsgFoto : Mensagem {
    public int Tamanho { get; set; }

    public MsgFoto(Contatinho destinatario, string horaEnvio, string conteudo, int tamanho)
        : base(destinatario, horaEnvio, conteudo) {
        Tamanho = tamanho;
    }

    public override string ToString() {
        return $"[Foto] Para: {Destinatario.Nome} - {Conteudo} (Tamanho: {Tamanho}KB)";
    }
}
