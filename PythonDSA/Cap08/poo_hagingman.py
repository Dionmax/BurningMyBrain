import random
from os import system, name


def clear_screen():
    if name == 'nt':
        _ = system('cls')

    else:
        _ = system('clear')


class HangingMan:
    words = ['banana', 'apple', 'grape', 'pineapple', 'orange']
    word = ''
    chances = 6
    discovered_letters = []
    wrong_letters = []

    def __init__(self):
        self.word = random.choice(self.words)
        self.discovered_letters = ['_' for letters in self.word]

    def get_word(self):
        return self.word

    def set_word(self, _word):
        self.word = _word

    def get_chances(self):
        return self.chances

    def set_chances(self, _chances):
        self.chances = _chances

    def decrease_chances(self):
        self.chances -= 1

    def get_discovered_letters(self):
        return self.discovered_letters

    def set_discovered_letters(self, _discovered_letters):
        self.discovered_letters = _discovered_letters

    def set_discovered_letters_by_index(self, _discovered_letter, _index):
        self.discovered_letters[index] = _discovered_letter

    def get_wrong_letters(self):
        return self.wrong_letters

    def set_wrong_letters(self, _wrong_letters):
        self.wrong_letters = _wrong_letters

    def append_wrong_letters(self, _wrong_letter):
        temp = self.get_wrong_letters()
        temp.append(_wrong_letter)
        self.set_wrong_letters(temp)


if __name__ == "__main__":
    game = HangingMan()

    clear_screen()

    while game.get_chances() > 0:
        print(" ".join(game.get_discovered_letters()))
        print("\nAttempts left: ", game.get_chances())
        print("Already used letters: ", " ".join(game.get_wrong_letters()))

        attempt = input("\nType a letter: ").lower()

        if attempt in game.get_word():
            index = 0
            for letter in game.get_word():
                if attempt == letter:
                    game.set_discovered_letters_by_index(letter, index)
                index += 1
        else:
            game.decrease_chances()
            game.append_wrong_letters(attempt)

        if "_" not in game.get_discovered_letters():
            print("You win! The word was: ", game.get_word())
            break

    if "_" in game.get_discovered_letters():
        print("You lose! The word was: ", game.get_word())
