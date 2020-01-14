<?php
    $arrayNome = ["Valentina", "Fernanda", "Pedro", "Fernanda", "Lucas", "Marcos", "Joana"];
    $nome = filter_input(INPUT_POST, "txtNome", FILTER_SANITIZE_STRING);
    $email = filter_input(INPUT_POST, "txtEmail", FILTER_SANITIZE_STRING);
    $funcionarioCod = filter_input(INPUT_POST, "slFuncionario", FILTER_SANITIZE_NUMBER_INT);
    $funcionario = "";
    
    if($funcionarioCod){
        $funcionario = $arrayNome[$funcionarioCod - 1];
    }
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>AulaGet</title>
    <style>
            ul{
                list-style: none;
            }
            input, select{
                padding: 5px;
                margin-top: 10px;
            }
        </style>
</head>
<body>
<form method="post">
            <ul>
                <li>Nome: <input type="text" name="txtNome" /></li>
                <li>E-mail: <input type="text" name="txtEmail" /></li>
                <li>Funcionário: 
                    <select name="slFuncionario">
                        <?php
                        for ($i = 0; $i < count($arrayNome); $i++) {
                            ?>
                            <option value="<?= $i + 1; ?>"><?= $arrayNome[$i]; ?></option>
                            <?php
                        }
                        ?>
                    </select>
                </li>
                <li>
                    <input type="submit" name="btnSubmit" value="Cadastrar" />
                    <a href="http://cursophp/Get">Atualizar</a>
                </li>
            </ul>
        </form>
        <br /><hr/><br />
        <p>Nome: <?= $nome; ?></p>
        <p>E-mail: <?= $email; ?></p>
        <p>Funcionário: <?= $funcionario; ?></p>
</body>
</html>