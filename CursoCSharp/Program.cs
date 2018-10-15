using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
				//Fundamentals
				{"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
				{"Comentarios - Fundamentos", Comentarios.Executar},
				{"Variaveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
				{"Inferencia - Fundamentos", Inferencia.Executar},
				{"Interpolacao - Fundamentos", Interpolacao.Executar},
				{"Notação Ponto - Fundamentos", NotacaoPonto.Executar},
				{"Lendo Dados - Fundamentos", LendoDados.Executar},
				{"Formatando Numeros - Fundamentos", FormatandoNumero.Executar},
				{"Conversões - Fundamentos", Conversoes.Executar},
				{"Operadores Aritimeticos - Fundamentos", OperadoresAritmeticos.Executar},
				{"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar},
				{"Operadores Logicos - Fundamentos", OperadoresLogicos.Executar},
				{"Operadores Atribuição - Fundamentos", OperadoresAtribuicao.Executar},
				{"Operadores Unários - Fundamentos", OperadoresUnarios.Executar},
				{"Operadores Ternários - Fundamentos", OperadoresTernarios.Executar},
				//Control Structure
				{ "Estrutura If - Estrutura de Controle", EstruturaIf.Executar},
				{ "Estrutura If/Else - Estrutura de Controle", EstruturaIfElse.Executar},
				{ "Estrutura If/Else/If - Estrutura de Controle", EstruturaIfElseIf.Executar},
				{ "Estrutura Switch - Estrutura de Controle", EstruturaSwitch.Executar},
				{ "Estrutura While - Estrutura de Controle", EstruturaWhile.Executar},
				{ "Estrutura DoWhile - Estrutura de Controle", EstruturaDoWhile.Executar},
				{ "Estrutura For - Estrutura de Controle", EstruturaFor.Executar},
				{ "Estrutura Foreach - Estrutura de Controle", EstruturaForeach.Executar},
				{ "Usando Break - Estrutura de Controle", UsandoBreak.Executar},
			});

            central.SelecionarEExecutar();
        }
    }
}