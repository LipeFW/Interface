public interface ParserConstants
{
    int START_SYMBOL = 47;

    int FIRST_NON_TERMINAL    = 47;
    int FIRST_SEMANTIC_ACTION = 88;

    int[][] PARSER_TABLE =
    {
        { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1,  0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 },
        { -1,  1, -1, -1, -1, -1, -1,  1, -1,  1, -1, -1, -1, -1, -1,  1, -1, -1,  1,  1,  1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 },
        { -1,  2, -1, -1, -1, -1, -1,  2, -1,  2,  3,  3, -1, -1, -1,  2, -1, -1,  2,  2,  2, -1, -1, -1, -1,  3, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 },
        { -1, -1, -1, -1, -1, -1, -1, -1, -1,  4, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 },
        { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1,  5, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 },
        { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1,  6,  7, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 },
        { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1,  8,  9, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 },
        { -1, 10, 10, 10, 10, 10, -1, -1, -1, -1, -1, -1, 10, -1, -1, -1, -1, -1, -1, -1, -1, -1, 10, -1, -1, -1, -1, -1, -1, -1, 10, -1, -1, -1, -1, -1, -1, -1, 10, 10, -1, -1, -1, -1, -1, 10 },
        { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 11, -1, -1, -1, 12, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 },
        { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 13, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 },
        { -1, 15, -1, -1, -1, 14, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 },
        { -1, 16, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 },
        { -1, 19, -1, -1, -1, -1, -1, 19, -1, 19, -1, -1, -1, -1, -1, 19, -1, -1, 19, 19, 19, -1, -1, 17, 18, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 },
        { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 20, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 },
        { -1, 21, -1, -1, -1, -1, -1, 21, -1, 21, -1, -1, -1, -1, -1, 21, -1, -1, 21, 21, 21, -1, -1, 21, 21, -1, -1, -1, -1, -1, -1, -1, -1, 22, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 },
        { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 23, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 },
        { -1, 24, -1, -1, -1, -1, -1, 24, -1, 24, -1, -1, -1, -1, -1, 24, -1, -1, 24, 24, 24, -1, -1, 24, 24, -1, -1, -1, -1, -1, -1, -1, -1, 25, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 },
        { -1, 26, -1, -1, -1, -1, -1, 26, -1, 26, -1, -1, -1, -1, -1, 26, -1, -1, 26, 26, 26, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 },
        { -1, 27, -1, -1, -1, -1, -1, 27, -1, 27, -1, -1, -1, -1, -1, 27, -1, -1, 27, 27, 27, -1, -1, 27, 27, -1, -1, -1, -1, -1, -1, -1, -1, 28, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 },
        { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 29, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 },
        { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 30, -1, -1, 31, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 },
        { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 32, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 },
        { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 33, 34, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 },
        { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 35, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 },
        { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 36, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 },
        { -1, 37, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 },
        { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 39, 38, -1, 39, -1, 39, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 },
        { -1, -1, -1, -1, -1, -1, 44, -1, 42, -1, -1, -1, -1, 41, -1, -1, 40, -1, -1, -1, -1, 43, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 },
        { -1, -1, 45, 46, 47, 48, -1, -1, -1, -1, -1, -1, 50, -1, -1, -1, -1, -1, -1, -1, -1, -1, 49, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 },
        { -1, 51, -1, -1, -1, -1, -1, 56, -1, 55, -1, -1, -1, -1, -1, 54, -1, -1, 53, 53, 52, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 },
        { -1, 57, 57, 57, 57, 57, -1, -1, -1, -1, -1, -1, 57, -1, -1, -1, -1, -1, -1, -1, -1, -1, 57, -1, -1, -1, -1, -1, -1, -1, 57, -1, -1, -1, -1, -1, -1, -1, 57, 57, -1, -1, -1, -1, -1, 57 },
        { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 58, 58, -1, -1, 58, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 59, 60, -1 },
        { -1, 61, 61, 61, 61, 61, -1, -1, -1, -1, -1, -1, 63, -1, -1, -1, -1, -1, -1, -1, -1, -1, 62, -1, -1, -1, -1, -1, -1, -1, 61, -1, -1, -1, -1, -1, -1, -1, 61, 61, -1, -1, -1, -1, -1, 64 },
        { -1, 65, 65, 65, 65, 65, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 65, -1, -1, -1, -1, -1, -1, -1, 65, 65, -1, -1, -1, -1, -1, -1 },
        { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 66, 66, -1, -1, 66, -1, -1, 67, 67, 67, 67, -1, -1, -1, -1, -1, 66, 66, -1 },
        { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 68, 69, 70, 71, -1, -1, -1, -1, -1, -1, -1, -1 },
        { -1, 72, 72, 72, 72, 72, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 72, -1, -1, -1, -1, -1, -1, -1, 72, 72, -1, -1, -1, -1, -1, -1 },
        { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 73, 73, -1, -1, 73, -1, -1, 73, 73, 73, 73, 74, 75, -1, -1, -1, 73, 73, -1 },
        { -1, 76, 76, 76, 76, 76, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 76, -1, -1, -1, -1, -1, -1, -1, 76, 76, -1, -1, -1, -1, -1, -1 },
        { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 77, 77, -1, -1, 77, -1, -1, 77, 77, 77, 77, 77, 77, 78, 79, 80, 77, 77, -1 },
        { -1, 81, 82, 83, 84, 85, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 86, -1, -1, -1, -1, -1, -1, -1, 87, 88, -1, -1, -1, -1, -1, -1 }
    };

    int[][] PRODUCTIONS = 
    {
        { 15, 18, 33, 59, 34 },
        { 76, 49 },
        { 48 },
        {  0 },
        { 10, 48, 26, 31, 77, 32, 12, 29 },
        { 16, 31, 77, 32, 48, 52, 12, 29 },
        { 11, 48 },
        {  0 },
        { 19, 31, 54, 32, 29 },
        { 20, 31, 54, 32, 29 },
        { 77, 55 },
        { 28, 54 },
        {  0 },
        { 21, 31, 57, 72, 32, 29 },
        {  6, 28 },
        {  0 },
        {  2, 30, 77, 29 },
        { 60 },
        { 62 },
        { 64 },
        { 66, 61 },
        { 59 },
        {  0 },
        { 71, 63 },
        { 59 },
        {  0 },
        { 76, 65 },
        { 59 },
        {  0 },
        { 24, 72, 67 },
        { 68, 69 },
        { 70 },
        { 27, 74 },
        { 29 },
        { 30, 75, 29 },
        { 30, 75, 29 },
        { 25, 72, 67 },
        {  2, 73 },
        { 28, 72 },
        {  0 },
        { 17 },
        { 14 },
        {  9 },
        { 22 },
        {  7 },
        {  3 },
        {  4 },
        {  5 },
        {  6 },
        { 23 },
        { 13 },
        { 58 },
        { 56 },
        { 53 },
        { 51 },
        { 50 },
        {  8, 29 },
        { 79, 78 },
        {  0 },
        { 44, 79, 78 },
        { 45, 79, 78 },
        { 80 },
        { 23 },
        { 13 },
        { 46, 79 },
        { 83, 81 },
        {  0 },
        { 82, 83 },
        { 35 },
        { 36 },
        { 37 },
        { 38 },
        { 85, 84 },
        {  0 },
        { 39, 85, 84 },
        { 40, 85, 84 },
        { 87, 86 },
        {  0 },
        { 41, 87, 86 },
        { 42, 87, 86 },
        { 43, 87, 86 },
        {  2 },
        {  3 },
        {  4 },
        {  5 },
        {  6 },
        { 31, 77, 32 },
        { 39, 87 },
        { 40, 87 }
    };

    String[] PARSER_ERROR =
    {
        "",
        "Era esperado fim de programa",
        "Era esperado identificador",
        "Era esperado cint",
        "Era esperado cfloat",
        "Era esperado cchar",
        "Era esperado cstring",
        "Era esperado pr_boolean",
        "Era esperado pr_break",
        "Era esperado pr_char",
        "Era esperado pr_do",
        "Era esperado pr_else",
        "Era esperado pr_end",
        "Era esperado pr_false",
        "Era esperado pr_float",
        "Era esperado pr_fun",
        "Era esperado pr_if",
        "Era esperado pr_int",
        "Era esperado pr_main",
        "Era esperado pr_print",
        "Era esperado pr_println",
        "Era esperado pr_readln",
        "Era esperado pr_string",
        "Era esperado pr_true",
        "Era esperado pr_val",
        "Era esperado pr_var",
        "Era esperado pr_while",
        "Era esperado \":\"",
        "Era esperado \",\"",
        "Era esperado \";\"",
        "Era esperado \"=\"",
        "Era esperado \"(\"",
        "Era esperado \")\"",
        "Era esperado \"{\"",
        "Era esperado \"}\"",
        "Era esperado \"==\"",
        "Era esperado \"!=\"",
        "Era esperado \"<\"",
        "Era esperado \">\"",
        "Era esperado \"+\"",
        "Era esperado \"-\"",
        "Era esperado \"*\"",
        "Era esperado \"/\"",
        "Era esperado \"%\"",
        "Era esperado \"&&\"",
        "Era esperado \"||\"",
        "Era esperado \"!\"",
        "<programa> inv�lido",
        "<lista_de_comandos> inv�lido",
        "<optional_lista_de_comandos> inv�lido",
        "<comando_de_repeticao> inv�lido",
        "<comando_de_selecao> inv�lido",
        "<optional_lista_de_comandos_else> inv�lido",
        "<comando_de_saida_de_dados> inv�lido",
        "<lista_de_expressoes> inv�lido",
        "<optional_lista_de_expressoes> inv�lido",
        "<comando_de_entrada_de_dados> inv�lido",
        "<optional_constante_string> inv�lido",
        "<comando_atribuicao> inv�lido",
        "<lista_de_instrucoes> inv�lido",
        "<lista_declaracao_constantes> inv�lido",
        "<optional_lista_declaracao_constantes> inv�lido",
        "<lista_declaracao_variaveis> inv�lido",
        "<optional_lista_declaracao_variaveis> inv�lido",
        "<lista_declaracao_comandos> inv�lido",
        "<optional_lista_declaracao_comandos> inv�lido",
        "<declaracao_constantes> inv�lido",
        "<opcoes_declaracao> inv�lido",
        "<optional_opcoes_declaracao> inv�lido",
        "<declaracao_> inv�lido",
        "<declaracao_3> inv�lido",
        "<declaracao_variaveis> inv�lido",
        "<lista_de_identificadores> inv�lido",
        "<optional_lista_de_identificadores> inv�lido",
        "<tipo> inv�lido",
        "<valor> inv�lido",
        "<comando> inv�lido",
        "<expressao> inv�lido",
        "<expressao_> inv�lido",
        "<elemento> inv�lido",
        "<relacional> inv�lido",
        "<relacional_> inv�lido",
        "<operador_relacional> inv�lido",
        "<aritmetica> inv�lido",
        "<aritmetica_> inv�lido",
        "<termo> inv�lido",
        "<termo_> inv�lido",
        "<fator> inv�lido"
    };
}
