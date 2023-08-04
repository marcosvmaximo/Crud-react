# Crud-react
Crud react com uma API construida em domínio rico, para exemplificar uso de conceitos tecnicos

Desenvolvi uma API separadamente, uma representação de banco por um arquivo Excel, onde estão os dados, e por último, a aplicação web utilizando React.

Para a API, adotei uma abordagem mais simplista de DDD, CQRS e alguns patterns, apesar da baixa complexidade do desafio e de não serem necessárias essas abordagens de fato. Decidi utilizá-las para demonstrar um pouco mais desse conhecimento. Além disso, a API simula um banco de dados através do Excel, que realiza leitura e escrita (delete). Para isso, utilizei a biblioteca X.

Já para a aplicação front-end, feita em Angular, utilizei a biblioteca de componentes Material UI para o design e apliquei alguns padrões, mesmo que de forma bem simplista novamente, já que o desafio proposto não exige tanta complexidade. Também utilizei o básico de rotas.



Adendos sobre dependências:

React:

npm install react-router-dom

npm install @mui/material @emotion/react @emotion/styled

.Net API:

ClosedXml

MediatR
