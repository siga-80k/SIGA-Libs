
<h1 align="center">
    <img alt="SIGA LOGOTYPE" src="https://i.imgur.com/ZuNXLU8.png" />
    <br>
    S.I.G.A. - Segurança Integrada de Guarda Automotiva
</h1>

<h4 align="center">
  This repository contains all libs about this project with the referenced program languages.
</h4>

<p align="center">
  <img alt="GitHub top language" src="https://img.shields.io/github/languages/top/siga-80k/SIGA-Libs">

  <img alt="GitHub language count" src="https://img.shields.io/github/languages/count/siga-80k/SIGA-Libs.svg">

  <a href="https://www.codacy.com/app/BrewertonSantos/SIGA-Libs?utm_source=github.com&amp;utm_medium=referral&amp;utm_content=BrewertonSantos/SIGA-Libs&amp;utm_campaign=Badge_Grade">
    <img alt="Codacy grade" src="https://api.codacy.com/project/badge/Grade/430e60f15a4c484898f4cac9408ce90b">
  </a>

  <img alt="Repository size" src="https://img.shields.io/github/repo-size/BrewertonSantos/SIGA-Libs.svg">
  <a href="https://github.com/BrewertonSantos/SIGA-Libs/commits/master">
    <img alt="GitHub last commit" src="https://img.shields.io/github/last-commit/BrewertonSantos/SIGA-Libs.svg">
  </a>

  <a href="https://github.com/BrewertonSantos/SIGA-Libs">
    <img alt="Repository issues" src="https://img.shields.io/github/issues/BrewertonSantos/SIGA-Libs.svg">
  </a>

  <img alt="GitHub" src="https://img.shields.io/github/license/BrewertonSantos/SIGA-Libs.svg">
  </p>

  <p align="center">
    <a href="https://github.com/siga-80k/siga-mobile">SIGA - APP</a>&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
    <a href="#Propósito">SIGA - Libs</a>
  </p>


# Propósito

  <p>
    Um rastreador autônomo de baixo custo com tecnologia de comunicação por rádio frequência (RF) combinada com serviços baseados em localização (SBL) por meio de um micro-circuito. 
  </p>

  <p>
    Possui componentes, como receptor e transmissor de rádio frequência, microfone, wi-fi, bluetooth, SIM slot. O SIGA COM é o principal responsável por conectar o caminhoneiro com autoridades e serviços indispensáveis para a sua segurança e bem estar de forma discreta, segura e autônoma.
  </p>

  <p>
    O SIGA COM se destaca por fazer uso de rede de comunicação em malha via radiofrequência para contornar a interferência de jammers.
  </p>

# SIGA - APP

  <p>
    O SIGA APP é um aplicativo para smartphone que reúne dados e informações pertinentes para a segurança do caminhoneiro. Através dele podem ser configuradas frases e palavras-chave para ativar o modo “alerta de pânico”, cadastrar contatos de segurança, gerenciar registros de informações sobre o veículo e o motorista, sobre rota e trajeto do caminhão e até armazenar informações do serviço que está sendo prestado.
  </p>

  <p>
    Suas funcionalidades são resumidas por:
    Armazenamento de informações do perfil do caminhoneiro (nome, CNH, modelo do carro, placa)
    Configuração de frases e palavras chaves para ativar o modo “alerta de pânico”
    Cadastrar contatos de segurança em caso de alerta
    Armazenar registros de informações da viagem (trajeto, rota, cliente, carga)
    Exibir informações referenteS ao bem estar do caminhoneiro extraídas da SIGA BAND
    Exibir informações de alertas de pânico de outros caminhoneiros
  </p>

  <p align="center">
    <a href="https://bit.ly/2YGgZvQ" target="_blank">
      <img alt="Apk Demo" src="https://i.imgur.com/ekMIWIA.png" width="425" height="109">
    </a>
  </p>

# SIGA - BAND

  <p>
    A SIGA BAND é um acessório vestível dispensável para o uso das funções citadas acima (com exceção da extração de informações referentes ao bem-estar do caminhoneiro), apesar de funcionar de forma complementar, garantindo a segurança de forma ainda mais abrangente ao motorista, utilizando também o monitoramento da saúde como input. 
  </p>

  <p>
    Sob o formato de pulseira, a SIGA BAND se conecta via bluetooth com o SIGA COM, atuando como um controle para os comandos do sistema. Por meio dela, é possível ativar o alarme de pânico assim como fazer o monitoramento do bem-estar do condutor, identificando características como frequência cardíaca, monitoramento de sono e frequência e desempenho em exercícios físicos.
  </p>

  <p>
    O objetivo da pulseira, além de ser mais uma alternativa para iniciar um pedido de socorro, é monitorar e identificar qualquer irregularidade quanto a frequência cardíaca, temperatura, estresse e outros índices que podem apresentar uma possível disfunção ou até mesmo um mal súbito pelo motorista. Permitindo-o dessa forma solicitar socorro médico através do SIGA COM.
  </p>

# SIGA - Libs (Futuro framework)
  <p>
    Os conceitos de funcionamento do SIGA são, de certa forma, simples, e já validados por pesquisas e mercados, individualmente. A inovação se concentra  principalmente em como os conceitos interagem e como são apresentados ao usuário (comando de voz utilizando inteligência artificial, wearable como uma tecnologia de extensão da solução e placas microcontroladoras de baixo custo).
  </p>

  <p>
    Para o dispositivo de comunicação batizado com o nome de SIGA COM, é necessária a instalação de sistema de hardware composta por uma placa de Arduino com módulo de radiofrequência (Transmissor e Receptor), e um módulo GPRS com tecnologias de wi-fi, telefonia móvel (para 3G e 4G), bluetooth e microfone.
  </p>

  <p>
    A radiofrequência garante a efetividade por conta da eficiência do envio do sinal, que são capazes de driblar os inibidores de sinais conhecidos como jammers ou capetinha. Com a aderência pelo público podemos criar uma estrutura de comunicação em rede, criando uma malha, formando uma comunicação onde diversos pontos (nós) emitem e recebem sinal de forma descentralizada e “pegando carona” em outros dispositivos. A implantação desse sistema em diversos veículos e pontos estratégicos na via permite que a radiofrequência tenha maior ampliação de sinal, não dependendo apenas das antenas existentes (que já abrangem uma grande área). 
  </p>

  <p>
    A escolha por uma placa microcontroladora Arduino de hardware e software Open Source é estratégica para o nosso modelo de negócio, uma vez em que por não ser uma tecnologia privada, não possui valor agregado que tornam a implementação dos custos algo elevado. Permitindo criarmos a nossa rede em malha com um baixo custo, de fácil implementação e alta tolerância a falhas, uma vez que é uma tecnologia já existente e utilizada amplamente no mercado tecnológico.
  </p>

  <p>
    Ao criarmos um sistema de alerta descentralizado, graças ao sistema SIGA COM, é possível transformar os veículos na estrada e até mesmo pontos estratégicos como postos de gasolina, em roteadores que aumentam o alcance do rádio. Dessa forma, a informação pode ser transportada em vários saltos sem fio, passando por vários dispositivos, permitindo a aplicabilidade de IoT mesmo em áreas sem rede disponível, e se mostra como mais uma alternativa de comunicação, reduzindo os efeitos dos jammers (inibidores de GPS).
  </p>


# Equipe de desenvolvimento
<table align="center">
    <tr>
        <td style="text-align:center">
            <a href="https://github.com/eng-wilson" target="blank" rel="noopener"><img src="https://avatars2.githubusercontent.com/u/39011719?s=115&u=e8f21d6f29b423d99478af447fb7148ea1f47870&v=4"><br><sub>@eng-wilson | React Dev.</sub></a>
        </td>
        <td></td>
        <td style="text-align:center">
            <a href="https://github.com/BrewertonSantos" target="blank" rel="noopener"><img src="https://avatars2.githubusercontent.com/u/55927647?s=115&u=fdd724c245678796918063eb59d9e60be52f6e54&v=4"><br><sub>@BrewertonSantos | .C# Dev</sub></a>
        </td>
         <td></td>
        <td style="text-align:center">
            <a href="https://github.com/insanedays" target="blank" rel="noopener"><img src="https://avatars0.githubusercontent.com/u/62510469?s=115&v=4"><br><sub>@insanedays | BIZ Dev.</sub></a>
        </td>
         <td></td>
        <td style="text-align:center">
            <a href="https://github.com/felipetanso" target="blank" rel="noopener"><img src="https://avatars0.githubusercontent.com/u/5841447?s=115&v=4"><br><sub>@felipetanso | BIZ Dev.</sub></a>
        </td>
    </tr>
</table>
