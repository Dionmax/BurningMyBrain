const [a] = [10] // Array padrão
console.log(a)

const [n1, , n3, , n5, n6 = 0] = [10, 7, 9, 8] // Destrurutando elementos do array, ignorando os inexistentes.
console.log(n1, n3, n5, n6)