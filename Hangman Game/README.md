# Hangman Game
Hangman is a classic word-guessing game where players have to guess a hidden word by suggesting letters. The game displays the progress and keeps track of the number of incorrect guesses.

## How to Play
1. The game selects a word, and the player's goal is to guess the word by suggesting letters one at a time.

2. The player starts with a certain number of allowed incorrect guesses (e.g., 6). Each incorrect guess brings the player closer to losing the game.

3. The player suggests a letter by entering it through the keyboard.

4. If the letter is present in the hidden word, it is revealed in the corresponding positions. Otherwise, the player is notified of the incorrect guess.

5. The player continues guessing letters until they either guess the entire word correctly or run out of allowed incorrect guesses.

6. If the player guesses the word correctly, they win. If the player runs out of guesses before guessing the word, they lose.

7. The game ends, and the player is informed of the outcome.

## Prerequisites
- .NET Framework (version X.X or higher) installed

## How to Run
1. Clone the repository:
```
git clone https://github.com/your-username/hangman-game.git
```
2. Navigate to the project directory:
```
cd hangman-game
```
3. Build the project:
```
dotnet build
```
4. Run the application:
```
dotnet run
```

