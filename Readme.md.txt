# Tic Tac Toe Project

![GitHub repo size](https://img.shields.io/github/repo-size/iuricode/README-template?style=for-the-badge)
![GitHub language count](https://img.shields.io/github/languages/count/iuricode/README-template?style=for-the-badge)

<img src="D:\Projetos\Tic-tac-toe\Tic-tac-toe\Tic-tac-toe.Domain\Images\tictactoe" alt="tictactoe">

> This is a console application (CLI) game where 2 users can battle to the death.

## 💻 Prerequisites

Before starting, make sure you have met the following requirements:
* You have installed visual studio or visual studio code with .net 5 support
* You have a `<Windows / Linux / Mac>` machine.

## ☕ How to play <Tic tac toe>

Para usar <nome_do_projeto>, siga estas etapas:

```
you will need to enter a value corresponding to the numbers that appear in the tic-tac-toe.
According to the example below:

[1]  [2]  [3]
[4]  [5]  [6]
[7]  [8]  [9]

Please enter a number corresponding to a tic-tac-toe position above.

Type the next move of player --X--:
```
Assuming that player X wants to play in position 5, he must type the number into the input, the next rendering of the game will bring up the chosen position with an 'X' marked instead of its number as you can see in the example below:

```
[1]  [2]  [3]
[4]  [X]  [6]
[7]  [8]  [9]

Please enter a number corresponding to a tic-tac-toe position above.

Type the next move of player --O--:
```

the game will end when any of the players complete an unbroken sequence of 3 complete columns, rows or diagonals as you can see in below example:
```
[X]  [O]  [O]
[4]  [X]  [6]
[7]  [8]  [X]

Please enter a number corresponding to a tic-tac-toe position above.

End of the game
Congratulations, the winner is X
```
it is also possible for the game to end in a draw, as in the example below.
```
[X]  [O]  [O]
[O]  [X]  [X]
[X]  [O]  [O]

OUTPUT:
It's a tie!
```

[⬆ Back to the top](#Tic-tac-toe)<br>