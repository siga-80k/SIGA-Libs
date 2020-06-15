using System;
using System.Collections.Generic;
using System.Text;

namespace CCR_DEV_Tool.Helpers.TeleCom.email
{
    public class EmailModel
    {
        public static string uname = "Sílvio";
        public static string usname = "Santos";
        public static string cnh = "27517183307";
        public static string cpf = "447.727.950-73";
        public static string[] supflag = { "Equipe Médica", "Força Policial" };
        public static double[] coord = { -22.079622, -43.711359 };
        public static string[] datetime = { "22:15", "12/05/2020" };
        public static string[] locate = { "Rua São Sebastião do Barredo", "Santa Bárbara do Monte Verde", "MG" };

        public static string content =
        "<section style=\"margin: 0px; padding: 0px; width: 481px; height: 480px; font-family: Roboto, Oxygen, Ubuntu, Cantarell, 'Open Sans', 'Helvetica Neue', sans-serif; font-size: 9pt; background-image: url('https://i.imgur.com/xOA07D5.png'); background-repeat: no-repeat;\">" +
            "<div style=\"display:-ms-flexbox;display:flex;-ms-flex-wrap:wrap;flex-wrap:wrap;margin-right:-15px;margin-left:-15px;\">" +
                "<div style=\"margin-left: 65px; margin-top: 75px;\">"+
                    "<img src = \"https://i.imgur.com/2Kt4ECe.png\" width=\"80\" height=\"70\"/>" +
                "</div>"+
                "<div style=\"margin-left: 5px; margin-top: 60px;\">"+
                    $"<p style=\"font-size: 12pt; font-family: roboto, sans-serif;\"><b>{uname} {usname}</b><br>"+
                    $"<b>CNH:</b> {cnh}<br>" +
                    $"<b>CPF:</b> {cpf}</p>" +
                "</div>"+
            "</div>"+
            "<div style=\"font-size: 10pt; margin-left: 50px; width: 243px; text-align: justify;\">"+
                "<p>Um alerta de pânico foi acionado pelo " +
                    $"motorista <b>{uname}</b>, às <b>{datetime[0]}</b> hrs do dia " +
            $"{datetime[1]}</b>.<br>" +
                    "Solicitando suporte imediato de: " +
                    $"<b>{supflag[1]}</b>. Ambos devem ser " +
                    "enviados para a seguinte localização: " +
                   $"{locate[0]}, {locate[1]} - {locate[2]} " +
                    $"<b>{coord[0]}, {coord[1]}</b></p>" +
            "</div>"+
        "</section>";
    }
}
