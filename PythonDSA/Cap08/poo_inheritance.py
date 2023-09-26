class Animal:
    def __init__(self):
        print("The animal was created")

    def print_yourself(self):
        print('This is an animal')

    def eat(self):
        print('Time to eat')

    def make_sound(self):
        pass


class Dog(Animal):

    def __init__(self):
        Animal.__init__(self)
        print('The dog was made')

    def make_sound(self):
        print("Worf!")


class Cat(Animal):

    def __init__(self):
        Animal.__init__(self)
        print('The cat was made')

    def make_sound(self):
        print("Miau!")


class Parrot(Animal):

    def __init__(self):
        Animal.__init__(self)
        print('The parrot was made')

    def make_sound(self):
        print("PRR!")

    def fly(self):
        print('The parrot is flying')


if __name__ == "__main__":
    animal_list = [Dog(), Cat(), Parrot()]

    for animal in animal_list:
        animal.make_sound()

        if isinstance(animal, Parrot):
            animal.fly()
