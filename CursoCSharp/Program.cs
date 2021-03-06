﻿using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.ClassesEMetodos;

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
				{ "Usando Continue - Estrutura de Controle", UsandoContinue.Executar},
				
				//Menbers
				{ "Membros - Classes e Metodos", Membros.Executar},
				{ "Construtores - Classes e Metodos", Construtores.Executar},
				{ "Metodos Com Retorno - Classes e Metodos", MetodosComRetorno.Executar},
				{ "Metodos Estáticos - Classes e Metodos", MetodosEstaticos.Executar},
				{ "Atributos Estáticos - Classes e Metodos", AtributosEstaticos.Executar},
				{ "Desafio Atributo - Classes e Metodos", DesafioAtributo.Executar},
				{ "Params - Classes e Metodos", Params.Executar},
				{ "Parametros Nomeados - Classes e Metodos", ParametrosNomeados.Executar},
				{ "Get Set - Classes e Metodos", GetSet.Executar},
				{ "Props - Classes e Metodos", Props.Executar},
				{ "Read Only - Classes e Metodos", Readonly.Executar},
				{ "Enum - Classes e Metodos", ExemploEnum.Executar},
				{ "Struct - Classes e Metodos", ExemploStruct.Executar},
				{ "Struct VS Classes- Classes e Metodos", StructVsClasse.Executar},
				{ "Valor VS Referencia- Classes e Metodos", ValorVsReferencia.Executar},
				{ "Parametros Por Referencia- Classes e Metodos", ParametrosPorReferencia.Executar},
				{ "Parametros com Valor Padrão- Classes e Metodos", ParametroPadrao.Executar},
			});

            central.SelecionarEExecutar();
        }
    }
}