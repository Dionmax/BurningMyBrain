valid = True


def calculator(input_choice):
    _sum = lambda a, b: a + b

    _mult = lambda a, b: a * b

    _sub = lambda a, b: a - b

    _div = lambda a, b: a / b if b != 0 else "error"

    if 0 < input_choice < 5:
        input_a = float(input("Value A: "))
        input_b = float(input("Value B: "))

        if input_choice == 1:
            print(_sum(input_a, input_b))

        if input_choice == 2:
            print(_mult(input_a, input_b))

        if input_choice == 3:
            print(_sub(input_a, input_b))

        if input_choice == 4:
            print(_div(input_a, input_b))


print("Select op: \n")
print("1: Sum\n2: Mult\n3: Sub\n4: Div")

while valid:
    input_choice = int(input("Choose one: "))
    calculator(input_choice)
