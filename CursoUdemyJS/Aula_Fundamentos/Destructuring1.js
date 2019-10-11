const pessoa = {
    nome: 'senhor teste',
    idade: 100,
    endereco: {
        logradouro: 'Em todos os lugares',
        numero: 999
    }
}

const { nome: NomeDestruc, idade } = pessoa

console.log(NomeDestruc, idade)

const { sobrenome, bemHumorada = true } = pessoa //Sobrenome não será encontrado e retornará undefined

console.log(sobrenome, bemHumorada)

const { endereco: { logradouro, numero, cep = 0 } } = pessoa //Olhará dentro de "Endereço" para criar as variasveis endereço, numero. Cep recebe valor padrão

console.log(logradouro, numero, cep)