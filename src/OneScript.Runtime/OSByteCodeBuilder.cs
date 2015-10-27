﻿using OneScript.Language;
using OneScript.Scopes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OneScript.Runtime
{
    public class OSByteCodeBuilder : IASTBuilder
    {
        public void BeginModule()
        {
            throw new NotImplementedException();
        }

        public void CompleteModule()
        {
            throw new NotImplementedException();
        }

        public void DefineExportVariable(string symbolicName)
        {
            throw new NotImplementedException();
        }

        public void DefineVariable(string symbolicName)
        {
            throw new NotImplementedException();
        }

        public IASTNode SelectOrCreateVariable(string identifier)
        {
            throw new NotImplementedException();
        }

        public IASTNode BuildAssignment(IASTNode acceptor, IASTNode source)
        {
            throw new NotImplementedException();
        }

        public IASTNode ReadLiteral(Lexem lexem)
        {
            throw new NotImplementedException();
        }

        public IASTNode ReadVariable(string identifier)
        {
            throw new NotImplementedException();
        }

        public IASTNode BinaryOperation(Token operationToken, IASTNode leftHandedNode, IASTNode rightHandedNode)
        {
            throw new NotImplementedException();
        }

        public IASTNode UnaryOperation(Token token, IASTNode operandNode)
        {
            throw new NotImplementedException();
        }

        public IASTNode BuildFunctionCall(IASTNode target, string identifier, IASTNode[] args)
        {
            throw new NotImplementedException();
        }

        public void BuildProcedureCall(IASTNode target, string identifier, IASTNode[] args)
        {
            throw new NotImplementedException();
        }

        public IASTNode ResolveProperty(IASTNode target, string propertyName)
        {
            throw new NotImplementedException();
        }

        public IASTNode BuildIndexedAccess(IASTNode target, IASTNode expression)
        {
            throw new NotImplementedException();
        }

        public IASTMethodDefinitionNode BeginMethod()
        {
            throw new NotImplementedException();
        }

        public void EndMethod(IASTMethodDefinitionNode methodNode)
        {
            throw new NotImplementedException();
        }

        public IASTNode BeginBatch()
        {
            throw new NotImplementedException();
        }

        public void EndBatch(IASTNode batch)
        {
            throw new NotImplementedException();
        }

        public IASTConditionNode BeginConditionStatement()
        {
            throw new NotImplementedException();
        }

        public void EndConditionStatement(IASTConditionNode node)
        {
            throw new NotImplementedException();
        }

        public IASTWhileNode BeginWhileStatement()
        {
            throw new NotImplementedException();
        }

        public void EndWhileStatement(IASTWhileNode node)
        {
            throw new NotImplementedException();
        }

        public IASTForLoopNode BeginForLoopNode()
        {
            throw new NotImplementedException();
        }

        public void EndForLoopNode(IASTForLoopNode node)
        {
            throw new NotImplementedException();
        }

        public IASTForEachNode BeginForEachNode()
        {
            throw new NotImplementedException();
        }

        public void EndForEachNode(IASTForEachNode node)
        {
            throw new NotImplementedException();
        }

        public IASTTryExceptNode BeginTryExceptNode()
        {
            throw new NotImplementedException();
        }

        public void EndTryBlock(IASTTryExceptNode node)
        {
            throw new NotImplementedException();
        }

        public void EndExceptBlock(IASTTryExceptNode node)
        {
            throw new NotImplementedException();
        }

        public void BuildBreakStatement()
        {
            throw new NotImplementedException();
        }

        public void BuildContinueStatement()
        {
            throw new NotImplementedException();
        }

        public void BuildReturnStatement(IASTNode expression)
        {
            throw new NotImplementedException();
        }

        public void BuildRaiseExceptionStatement(IASTNode expression)
        {
            throw new NotImplementedException();
        }

        public CompilerContext Context { get; set; }

        internal CompiledModule GetModule()
        {
            throw new NotImplementedException();
        }
    }
}
