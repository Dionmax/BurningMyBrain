import random
from os import system, name


def clear_screen():
    if name == 'nt':
        _ = system('cls')

    else:
        _ = system('clear')


def game():
    clear_screen()

    print("Welcome to hangman")
    print("Guess the word")

    words = ['banana', 'apple', 'grape', 'pineapple', 'orange']

    word = random.choice(words)

    discovered_letters = ['_' for letters in word]

    chances = 6

    wrong_letters = []

    while chances > 0:
        print(" ".join(discovered_letters))
        print("\nAttempts left: ", chances)
        print("Already used letters: ", " ".join(wrong_letters))

        attempt = input("\nType a letter: ").lower()

        if attempt in word:
            index = 0
            for letter in word:
                if attempt == letter:
                    discovered_letters[index] = letter
                index += 1
        else:
            chances -= 1
            wrong_letters.append(attempt)

        if "_" not in discovered_letters:
            print("You win! The word was: ", word)
            break

    if "_" in discovered_letters:
        print("You lose! The word was: ", word)


if __name__ == "__main__":
    game()
