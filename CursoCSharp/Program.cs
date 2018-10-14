using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
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
			});

            central.SelecionarEExecutar();
        }
    }
}