using QRCoder;
class Program
{
    static void Main(string[] args)
    {
        string linkCertificado = "https://hermes.dio.me/certificates/Q1ARNOWY.pdf";

        string mensagemCertificado = "Veja meu certificado de manipulação de dados no SQL: " + linkCertificado;

      string mensagemAdicional = "Novo certificado de manipulação de dados no SQL disponível! Confira o certificado e fique à vontade para compartilhar.";

        string mensagemFinal = mensagemCertificado + " " + mensagemAdicional;

        QRCodeGenerator qrGenerator = new QRCodeGenerator();
        QRCodeData qrCodeData = qrGenerator.CreateQrCode(mensagemFinal, QRCodeGenerator.ECCLevel.Q);

        BitmapByteQRCode qrCodeBytes = new BitmapByteQRCode(qrCodeData);
        byte[] qrCodeImageBytes = qrCodeBytes.GetGraphic(20); 

        File.WriteAllBytes("qrcode_certificado.png", qrCodeImageBytes);

        Console.WriteLine("QR Code criado com sucesso! Scanee para acessar o certificado e ver a mensagem.");
    }
}
