# Estacionamento - Projeto C#

Este projeto é um sistema simples de gerenciamento de estacionamento desenvolvido em C#. Ele permite cadastrar, listar e remover veículos, além de calcular o valor a ser pago pelo tempo de permanência.

## Funcionalidades

- **Cadastrar veículo:**  
  O usuário informa a placa do veículo. O sistema não permite cadastrar duas vezes a mesma placa.

- **Remover veículo:**  
  O usuário informa a placa do veículo para remover. Caso a placa não exista, o sistema solicita novamente até que uma placa válida seja informada. Se não houver veículos cadastrados, o sistema avisa o usuário.

- **Listar veículos:**  
  Exibe todas as placas dos veículos atualmente estacionados. Caso não haja veículos, informa ao usuário.

- **Cálculo de preço:**  
  - Primeira hora: **R$7,00** (fixo)
  - Demais horas: **R$5,00** por hora adicional

## Como funciona

1. Ao iniciar o programa, são exibidas as informações de preços.
2. O usuário escolhe uma opção no menu:
   - `1` para cadastrar veículo
   - `2` para remover veículo
   - `3` para listar veículos
   - `4` para encerrar o programa
3. Após cada operação, o sistema aguarda o usuário pressionar Enter para continuar.

## Exemplo de uso

```
Seja bem-vindo ao sistema de estacionamento!
Preço da primeira hora: R$7,00
Preço das demais horas: R$5,00 por hora

Digite a sua opção:
1 - Cadastrar veículo
2 - Remover veículo
3 - Listar veículos
4 - Encerrar
```

## Regras

- Não é permitido cadastrar veículos com placas duplicadas.
- Não é possível remover veículos se não houver nenhum cadastrado.
- O valor total é calculado automaticamente conforme o tempo informado.

## Estrutura do projeto

- `Program.cs`: Contém o menu principal e a lógica de interação com o usuário.
- `Models/Estacionamento.cs`: Contém a classe responsável pelo cadastro, remoção, listagem e cálculo de valores dos veículos.

---

**Desenvolvido para fins de aprendizado