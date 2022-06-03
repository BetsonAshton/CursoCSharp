using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp_1.Fundamentos;
using CursoCSharp_1.EstruturasDeControle;
using CursoCSharp_1.ClassesEMetodos;

namespace CursoCSharp{
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                // Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Váriaveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferência - Fundamentos", Inferencia.Executar},
                {"Interpolação - Fundamentos", Interpolacao.Executar},
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar}, 
                {"Lendo Dados - Fundamentos", LendoDados.Executar},
                {"Formatando Número - Fundamentos", FormatandoNumero.Executar},
                {"Conversões - Fundamentos", Conversoes.Executar}, 
                {"Operadores Aritméticos - Fundamentos", OperadoresAritmeticos.Executar},   
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores Lógicos - Fundamentos", OperadoresLogicos.Executar},
                {"Operadores Atribuição - Fundamentos", OperadoresAtribuicao.Executar}, 
                {"Operadores Unários - Fundamentos", OperadoresUnarios.Executar},
                {"Operadores Ternário - Fundamentos", OperadorTernario.Executar},

                // Estruturas de Controle
                {"Estrutura If - Estruturas de Controle", EstruturaIf.Executar},
                {"Estrutura If/Else - Estruturas de Controle", EstruturasIfElse.Executar},
                {"Estrutura If/Else/If - Estruturas de Controle", EstruturaIfElseIf.Executar},
                {"Estrutura Switch - Estruturas de Controle", EstruturaSwitch.Executar},
                {"Estrutura While - Estruturas de Controle", EstruturaWhile.Executar},
                {"Estrutura Do While - Estruturas de Controle", EstruturaDoWhile.Executar},
                {"Estrutura For - Estruturas de Controle", EstruturaFor.Executar},
                {"Estrutura Foreach - Estruturas de Controle",EstruturaForEach.Executar},
                {"Usando Break - Estruturas de Controle",UsandoBreak.Executar},
                {"Usando continue - Estruturas de Controle",UsandoContinue.Executar},
                
                //Classes e Métodos
                {"Membros - Classes e Metodos",Membros.Executar},
                {"Construtores - Classes e Metodos",Construtores.Executar},
                {"Metodos Com Retorno - Classes e Metodos ",MetodosComRetorno.Executar},




            });

            central.SelecionarEExecutar();
        }
    }
}