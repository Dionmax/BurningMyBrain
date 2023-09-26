class Book:

    title = ''
    isbn = 0000000

    def __init__(self, tittle='Book', isbn=99999):
        self.title = tittle
        self.isbn = isbn

    def get_title(self):
        return self.title

    def set_title(self, title):
        self.title = title

    def print_class(self):
        print('Book title: %s with ISBN: %d' %(self.title, self.isbn))


if __name__ == "__main__":
    book1 = Book('banana', 9888888)
    book2 = Book()

    book1.print_class()
    book2.print_class()

    print(hasattr(book1, 'title'))
    print(getattr(book1, 'title'))
    print(book1.get_title())
    # print(delattr(book1, 'title'))
