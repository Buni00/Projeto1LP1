# Bulbs Puzzle
---

## Autoria

* Bruno Rodrigues a22103346

---
## 0. Observações

Este projeto foi muito mais acessível do que o do ano anterior. Consegui fazê-lo sozinho por isso creio que estou num bom caminho. Separando por classes e usando matéria que aprendi no ano passado e no decorrer destes anos. Melhorei a maneira como escrevo commits, comento o codigo, estruturo e organizo. Pena não conseguir funcionar bem com o UniCode tal como eu queria, não aparecem as cores no GitBash dos emogis.

## 1. Commits

Trabalho feito individualmente.

## 2. Repositório Git

https://github.com/Buni00/Projeto1LP1

## 3. Arquitetura da solução

O código foi dividio em métodos para evitar a repetição de código desnecessária e esses métodos foram: CreateBulbs serve para criar 3 lâmpadas e 3 butões; Instructions tem como função imprimir todas as instruções para que seja possível jogar sem qualquer tipo de dúvida; UpdateBulbState tal como o nome indica, atualiza o estado das lampadas visualmente; o método GameCycle este loop verifica a condição de vitória e derrota, também lê os inputs do jogador e controla quantos movimentos faltam; no Main são chamados apenas os métodos indicados anteriormente. Também foi utilizadas classes para uma melhor estrutura do código: a classe Bulb é a lâmpada que contêm um número e um estado (ligada ou desligada) também tem um método Switch que altera entre ligado ou desligado; a classe  Button que cria um botão e associa com uma lista de lampadas, no botão podemos aceder ao Switch para desligar ou ligar a lanterna.

### Fluxograma

![BulbPuzzleFlux.drawio.png](https://drive.google.com/file/d/1IfelZjYqCzXIw2N_y3jnp-hfI560W50m/view?usp=share_link)