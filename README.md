# Solicitação:

Faça um fork deste repositório;

Criar funcionalidade para incluir, consultar e alterar cadastro de Carros.
O cadastro deverá possuir os campos (Marca, Modelo, Ano, Placa, Km, Cor, Preço, lista de opcionais para atribuir ao veículo ex.: (Ar Condicionado, Alarme, Airbag, Freio ABS)).
Deverá ser possível incluir até 15 fotos para o veículo.
Apenas a km, opcionais e fotos não devem ser obrigatórios.

Após terminar seu teste submeta um pull request e aguarde seu feedback.

Instruções:
- Criar um serviço windows para sincronizar dados da api de Tabela FIPE (https://documenter.getpostman.com/view/7064033/SWT5jMGk) das Marcas e Modelos de Carros e gravar em banco de dados, os modelos devem ser vinculados as suas respectivas marcas.
- No cadastro os campos Marca e Modelo devem consultar do banco de dados e os modelos devem ser exibidos conforme selecionar a marca correspondente.
- A tela de consulta deverá ser desenvolvida conforme o layout criado no programa Adobe Illustrator.
- As telas devem ser responsivas, abrir corretamente em desktop e mobile.
- O cadastro de veículo, ao clicar em confirmar não deve gravar diretamente em banco de dados, deverá ser criado um WebService para ser requisitado enviando os dados e deverá ser gravado em banco pelo WebService.
- Deixe a estrutura completa do Migration para o Entity Framework Code-First pronta para apenas executarmos e gerar o banco e tabelas.


# Pré-requisitos:
- Microsoft Visual Studio Community (https://visualstudio.microsoft.com/pt-br/vs/community/) 
- Microsoft SQL Server Express (https://go.microsoft.com/fwlink/p/?linkid=2216019&clcid=0x416&culture=pt-br&country=br)

# Notas:
* Lembre-se de fazer um fork deste repositório! Apenas cloná-lo vai te impedir de criar o pull request e dificultar a entrega;
