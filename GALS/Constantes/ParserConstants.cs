﻿namespace Interface.GALS.Constantes
{
    public class ParserConstants
    {
        public static int START_SYMBOL = 47;

        public static int FIRST_NON_TERMINAL = 47;
        public static int FIRST_SEMANTIC_ACTION = 88;

        public int[,] PARSER_TABLE =
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

        public int[][] PRODUCTIONS =
          {
        new int[]{ 103,  15,  18,  33,  59,  34, 104 },
        new int[]{  76,  49 },
        new int[]{  48 },
        new int[]{   0 },
        new int[]{ 115,  10,  48,  26,  31,  77,  32, 116,  12,  29 },
        new int[]{  16,  31,  77,  32, 112,  48,  52,  12, 114,  29 },
        new int[]{  11, 113,  48 },
        new int[]{   0 },
        new int[]{  19,  31,  54,  32,  29 },
        new int[]{  20,  31,  54,  32, 105,  29 },
        new int[]{  77, 102,  55 },
        new int[]{  28,  54 },
        new int[]{   0 },
        new int[]{  21,  31,  57,  72, 123,  32,  29 },
        new int[]{   6, 110, 102,  28 },
        new int[]{   0 },
        new int[]{   2, 120,  30,  77, 122,  29 },
        new int[]{  60 },
        new int[]{  62 },
        new int[]{  64 },
        new int[]{  66,  61 },
        new int[]{  59 },
        new int[]{   0 },
       new int[]{  71,  63 },
        new int[]{  59 },
        new int[]{   0 },
        new int[]{  76,  65 },
        new int[]{  59 },
        new int[]{   0 },
        new int[]{  24,  72,  67 },
        new int[]{  68, 118, 119,  69 },
        new int[]{  70 },
       new int[]{  27,  74 },
       new int[]{  29 },
       new int[]{  30,  75,  29 },
       new int[]{  30,  75,  29 },
        new int[]{  25,  72,  67 },
        new int[]{   2, 120,  73 },
        new int[]{  28,  72 },
        new int[]{   0 },
        new int[]{  17 },
        new int[]{  14 },
        new int[]{   9 },
        new int[]{  22 },
        new int[]{   7 },
        new int[]{   3 },
        new int[]{   4 },
        new int[]{   5 },
        new int[]{   6 },
        new int[]{  23 },
        new int[]{  13 },
        new int[]{  58 },
        new int[]{  56 },
        new int[]{  53 },
        new int[]{  51 },
        new int[]{  50 },
        new int[]{   8,  29 },
        new int[]{  79,  78 },
        new int[]{   0 },
        new int[]{  44,  79, 106,  78 },
        new int[]{  45,  79, 107,  78 },
        new int[]{  80 },
        new int[]{  23,  99 },
        new int[]{  13, 100 },
        new int[]{  46,  79, 101 },
        new int[]{  83,  81 },
        new int[]{   0 },
        new int[]{  82,  97,  83,  98 },
        new int[]{  35 },
        new int[]{  36 },
        new int[]{  37 },
        new int[]{  38 },
        new int[]{  85,  84 },
        new int[]{   0 },
        new int[]{  39,  85,  89,  84 },
        new int[]{  40,  85,  90,  84 },
        new int[]{  87,  86 },
        new int[]{   0 },
        new int[]{  41,  87,  91,  86 },
        new int[]{  42,  87,  92,  86 },
        new int[]{  43,  87, 108,  86 },
        new int[]{   2, 121 },
        new int[]{   3,  93 },
        new int[]{   4,  94 },
        new int[]{   5, 109 },
        new int[]{   6, 110 },
        new int[]{  31,  77,  32 },
        new int[]{  39,  87,  95 },
        new int[]{  40,  87,  96 }
            };

        public string[] PARSER_ERROR =
        {
        "",
        "esperado EOF", // "Era esperado fim de programa",
        "esperado identificador", //"Era esperado identificador",
        "esperado constante_int", //"Era esperado cint",
        "esperado constante_float", //"Era esperado cfloat",
        "esperado constante_char", //"Era esperado cchar",
        "esperado constante_string", //"Era esperado cstring",
        "esperado boolean", //"Era esperado pr_boolean",
        "esperado break", //"Era esperado pr_break",
        "esperado char", //"Era esperado pr_char",
        "esperado do", //"Era esperado pr_do",
        "esperado else", //"Era esperado pr_else",
        "esperado end", //"Era esperado pr_end",
        "esperado false", //"Era esperado pr_false",
        "esperado float", //"Era esperado pr_float",
        "esperado fun", //"Era esperado pr_fun",
        "esperado if", //"Era esperado pr_if",
        "esperado int", //"Era esperado pr_int",
        "esperado main", //"Era esperado pr_main",
        "esperado print", //"Era esperado pr_print",
        "esperado println ", //"Era esperado pr_println",
        "esperado readln", //"Era esperado pr_readln",
        "esperado string", //"Era esperado pr_string",
        "esperado true", //"Era esperado pr_true",
        "esperado val", //"Era esperado pr_val",
        "esperado var", //"Era esperado pr_var",
        "esperado while", //"Era esperado pr_while",
        "esperado :", //"Era esperado \":\"",
        "esperado ,", //"Era esperado \",\"",
        "esperado ;", //"Era esperado \";\"",
        "esperado =", //"Era esperado \"=\"",
        "esperado (", //"Era esperado \"(\"",
        "esperado )", // "Era esperado \"(\"",
        "esperado {", //"Era esperado \"{\"",
        "esperado }", //"Era esperado \"}\"",
        "esperado ==", //"Era esperado \"==\"",
        "esperado !=", //"Era esperado \"!=\"",
        "esperado <", //"Era esperado \"<\"",
        "esperado >", //"Era esperado \">\"",
        "esperado +", //"Era esperado \"+\"",
        "esperado -", //"Era esperado \"-\"",
        "esperado *", //"Era esperado \"*\"",
        "esperado /", //"Era esperado \"/\"",
        "esperado %", //"Era esperado \"%\"",
        "esperado &&", //"Era esperado \"&&\"",
        "esperado ||", //"Era esperado \"||\"",
        "esperado !", //"Era esperado \"!\"",
        "esperado fun", //"<programa> inválido",
        "esperado identificador break do if print println readln", //"<lista_de_comandos> inválido",
        "esperado identificador break do else end if print println readln while", //"<optional_lista_de_comandos> inválido",
        "esperado do", //"<comando_de_repeticao> inválido",
        "esperado if", //"<comando_de_selecao> inválido",
        "esperado else end", //"<optional_lista_de_comandos_else> inválido",
        "esperado print println", //"<comando_de_saida_de_dados> inválido",
        "esperado expressão", //<lista_de_expressoes> inválido
        "esperado , )", //"<optional_lista_de_expressoes> inválido",
        "esperado readln", //"<comando_de_entrada_de_dados> inválido",
        "esperado identificador constante_string", //"<optional_constante_string> inválido",
        "esperado identificador", //"<comando_atribuicao> inválido",
        "esperado identificador break do if print println readln val var", //"<lista_de_instrucoes> inválido",
        "esperado val", //"<lista_declaracao_constantes> inválido",
        "esperado identificador break do if print println readln val var }", //"<optional_lista_declaracao_constantes> inválido",
        "esperado var", //"<lista_declaracao_variaveis> inválido",
        "esperado identificador break do if print println readln val var", //"<optional_lista_declaracao_variaveis> inválido",
        "esperado identificador break do if print println readln", //"<lista_declaracao_comandos> inválido",
        "esperado identificador break do if print println readln val var", //"<optional_lista_declaracao_comandos> inválido",
        "esperado val", //"<declaracao_constantes> inválido",
        "esperado : =", //"<opcoes_declaracao> inválido",
        "esperado :", //"<optional_opcoes_declaracao> inválido",
        "esperado ; =", //"<declaracao_> inválido",
        "esperado =", //"<declaracao_3> inválido",
        "esperado var", //"<declaracao_variaveis> inválido",
        "esperado id", //"<lista_de_identificadores> inválido",
        "esperado : , = )", //"<optional_lista_de_identificadores> inválido",
        "esperado boolean char float int string", //"<tipo> inválido",
        "esperado constante_int constante_float constante_char constante_string false true", //"<valor> inválido",
        "esperado identificador break do if print println readln", //"<comando> inválido",
        "esperado expressão",//"<expressao> inválido",
        "esperado expressão",//"<expressao_> inválido",
        "esperado expressão",//"<elemento> inválido",
        "esperado expressão",//"<relacional> inválido",
        "esperado expressão",//"<relacional_> inválido",
        "esperado == != < >",//"<operador_relacional> inválido",
        "esperado expressão",//"<aritmetica> inválido",
        "esperado expressão",//"<aritmetica_> inválido",
        "esperado expressão",//"<termo> inválido",
        "esperado expressão",//"<termo_> inválido",
        "esperado expressão",//"<fator> inválido"
    };
    }
}