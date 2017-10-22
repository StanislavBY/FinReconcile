﻿using FinReconcile.Domain;
using FinReconcile.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace FinReconcile.RuleEngine
{
    public class SimpleRuleEngine:IRuleEngine
    {
        ParameterExpression transSource = Expression.Parameter(typeof(Transaction), "transactionSource");
        ParameterExpression transTarget= Expression.Parameter(typeof(Transaction), "transactionTarget");

        RuleSet _ruleSet;
        Func<Transaction, Transaction, bool> _compiledRule;

        public SimpleRuleEngine(RuleSet ruleSet)
        {
            _ruleSet = ruleSet;
            _compiledRule = CompileRule();
        } 

      
        public Func<Transaction, Transaction, bool> CompileRule()
        {            
            Expression finalExpression = null;
            
            for (int i = 0; i < _ruleSet.Rules.Count; i++)
            {
                Expression currentExp = _ruleSet.Rules[i].BuildExpression(transSource, transTarget);
                
                if (finalExpression != null&&i<=_ruleSet.Rules.Count-1)
                {
                    finalExpression = Expression.AndAlso(finalExpression, currentExp);
                }
                else
                {
                    finalExpression = currentExp;
                }
            }                        

            return Expression.Lambda<Func<Transaction, Transaction, bool>>(finalExpression,
                new ParameterExpression[] { transSource, transTarget }).Compile();
        }

        public ReconciledItem Evaluate(Transaction clientTransaction,Transaction tutukaTransaction)
        {
            bool matched = _compiledRule(clientTransaction, tutukaTransaction);
            ReconciledItem resultItem = new ReconciledItem(clientTransaction, tutukaTransaction, matched ? ReconciledMatchType.Matched : ReconciledMatchType.NotMatched);

            return resultItem;
        }
    }
}