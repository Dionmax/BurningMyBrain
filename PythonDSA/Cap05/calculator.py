
class my_calculator:
    valid = True
    
    def calculator(input_choice):
        _sum = lambda a, b: a + b

        _mult = lambda a, b: a * b

        _sub = lambda a, b: a - b

        _div = lambda a, b: a / b if b != 0 else "error"
        
        if input_choice > 0 and input_choice < 5:
            input_a = float(input("Value A: "))
            input_b = float(input("Value B: "))
        
        match input_choice:
            case 1:
                print(_sum(input_a, input_b))
            
            case 2:
                print(_mult(input_a, input_b))
            
            case 3:
                print(_sub(input_a, input_b))
            
            case 4:
                print(_div(input_a, input_b))
            
            case _:
                print("Invalid")
                
    print("Select op: \n")
    print("1: Sum\n2: Mult\n3: Sub\n4: Div")

    while valid:
        input_choice = int(input("Choose one: "))
        calculator(input_choice)
        