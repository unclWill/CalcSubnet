# CalcSubnet

#### Notas 

- Este projeto está em desenvolvimento e ainda não possui todas as funcionalidades operacionais.
- Os requisitos foram escritos depois que o projeto já estava em andamento. Ou seja, comecei a escrever o programa seguindo apenas o que estava na minha cabeça sem um planejamento adequado, ***não faça isso!*** :neutral_face:.

#### Motivação 
- Automatizar o processo de cálculo de sub-redes, utilizando a notação CIDR.

#### Requisitos 

- [RF001] O software deve ser capaz de realizar a conversão das bases numéricas, decimal para binário e o inverso, tanto para o endereço IPv4 inserido quanto para a máscara de sub-rede inserida.
- [RF002] O software deve ser capaz de calcular, com base no endereço IPv4 digitado e na sua notação CIDR, a máscara de subrede correspondente.
- [RF003] O software deve, com base no IPv4 inserido pelo usuário e na máscara de sub-rede, posteriormente calculada exibir a classe do IPv4 (classful) com a letra associada àquela rede, a quantidade de sub-redes que podem ser formadas, a quantidade de hosts por sub-rede (subtraindo o endereço de rede e o endereço de broadcast) e o total de endereços possíveis (incluindo os endereços de rede e de broadcast).
- [RF003] O software deve ser capaz de calcular e exibir o endereço de rede e o endereço de broadcast da rede informada pelo usuário.
- [RF004] O software deve permitir que depois de calculadas as sub-redes, seja possível gerar uma lista ordenada do endereço mais baixo até o mais alto, com todas as sub-redes numeradas e separadas (1ª...Nª Subrede), e em cada uma deve estar contida a faixa de IPs correspondente.

#### To-Do 

1. [ ] Ajustar o processo de conversões de base numérica, tornando a conversão da máscara independente da conversão do IPv4 e vice-versa;
2. [ ] Corrigir o funcionamento da definição da máscara de sub-rede, levando em consideração apenas a notação CIDR (classless);
3. [ ] Corrigir a definição da quantidade de sub-redes, da quantidades de hosts e da quantidade de endereços possíveis (por host).
