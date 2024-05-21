module Solution exposing (filterDigits, main, maskCpf, maskPhone)

import Browser
import Html exposing (Html, br, div, input, label, text)
import Html.Attributes exposing (type_, value)
import Html.Events exposing (onInput)


main =
    Browser.sandbox { init = init, update = update, view = view }



-- MODEL


type alias Model =
    { name : String
    , phone : String
    , cpf : String
    }


init : Model
init =
    Model "" "" ""


-- UPDATE


type Msg
    = SetName String
    | SetPhone String
    | SetCpf String


-- Função para filtrar os dígitos e limitar a quantidade máxima de dígitos
filterDigits : Int -> String -> String
filterDigits maxDigits viewString =
    String.filter Char.isDigit viewString
        |> String.slice 0 maxDigits


-- Função para mascarar o telefone
maskPhone : String -> String
maskPhone phone =
    let
        digits = filterDigits 11 phone
        len = String.length digits
    in
    if len <= 10 then
        case len of
            0 ->
                ""
            1 ->
                "(" ++ digits
            2 ->
                "(" ++ digits ++ ") "
            3 ->
                "(" ++ String.left 2 digits ++ ") " ++ String.slice 2 3 digits
            4 ->
                "(" ++ String.left 2 digits ++ ") " ++ String.slice 2 4 digits
            5 ->
                "(" ++ String.left 2 digits ++ ") " ++ String.slice 2 5 digits
            6 ->
                "(" ++ String.left 2 digits ++ ") " ++ String.slice 2 6 digits
            7 ->
                "(" ++ String.left 2 digits ++ ") " ++ String.slice 2 7 digits ++ "-"
            8 ->
                "(" ++ String.left 2 digits ++ ") " ++ String.slice 2 7 digits ++ "-" ++ String.slice 7 8 digits
            9 ->
                "(" ++ String.left 2 digits ++ ") " ++ String.slice 2 7 digits ++ "-" ++ String.slice 7 9 digits
            _ ->
                "(" ++ String.left 2 digits ++ ") " ++ String.slice 2 7 digits ++ "-" ++ String.slice 7 11 digits
    else
        "(" ++ String.left 2 digits ++ ") " ++ String.slice 2 7 digits ++ "-" ++ String.slice 7 11 digits


-- Função para mascarar o CPF
maskCpf : String -> String
maskCpf cpf =
    let
        digits = filterDigits 11 cpf
        len = String.length digits
    in
    case len of
        0 ->
            ""
        1 ->
            digits
        2 ->
            digits
        3 ->
            digits
        4 ->
            String.left 3 digits ++ "." ++ String.slice 3 4 digits
        5 ->
            String.left 3 digits ++ "." ++ String.slice 3 5 digits
        6 ->
            String.left 3 digits ++ "." ++ String.slice 3 6 digits
        7 ->
            String.left 3 digits ++ "." ++ String.slice 3 6 digits ++ "." ++ String.slice 6 7 digits
        8 ->
            String.left 3 digits ++ "." ++ String.slice 3 6 digits ++ "." ++ String.slice 6 8 digits
        9 ->
            String.left 3 digits ++ "." ++ String.slice 3 6 digits ++ "." ++ String.slice 6 9 digits
        10 ->
            String.left 3 digits ++ "." ++ String.slice 3 6 digits ++ "." ++ String.slice 6 9 digits ++ "-" ++ String.slice 9 10 digits
        _ ->
            String.left 3 digits ++ "." ++ String.slice 3 6 digits ++ "." ++ String.slice 6 9 digits ++ "-" ++ String.slice 9 11 digits


update : Msg -> Model -> Model
update msg model =
    case msg of
        SetName newName ->
            { model | name = newName }

        SetPhone newPhone ->
            { model | phone = filterDigits 11 newPhone }

        SetCpf newCpf ->
            { model | cpf = filterDigits 11 newCpf }



-- VIEW


view : Model -> Html Msg
view model =
    div []
        [ inputFieldView "Nome:" model.name SetName
        , inputFieldView "Telefone:" (maskPhone model.phone) SetPhone
        , inputFieldView "CPF:" (maskCpf model.cpf) SetCpf
        ]


inputFieldView : String -> String -> (String -> msg) -> Html msg
inputFieldView l v toMsg =
    div []
        [ label [] [ text l ]
        , br [] []
        , input [ type_ "text", value v, onInput toMsg ] []
        ]
