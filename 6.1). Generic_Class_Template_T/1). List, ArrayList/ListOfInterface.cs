using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOfInterface
{
    public interface IRule
    {
        void ExecuteRule();
    }

    public class UppercaseInputRule : IRule
    {
        public void ExecuteRule()
        {
            Console.WriteLine("Execute It");
        }
    }

    public class RuleComposite : IRule
    {
        public RuleComposite(List<IRule> rules)
        {
            Rules = rules;
        }

        protected List<IRule> Rules { get; set; }

        public void ExecuteRule()
        {
            Rules.ForEach(rule => rule.ExecuteRule());
            Console.WriteLine("Hello");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<IRule> validationRules = new List<IRule>();

            IRule validationRuleComposite = new RuleComposite(validationRules);

            IRule uppercaseInputRule = new UppercaseInputRule();

            List<IRule> allRulesDefinition = new List<IRule> { validationRuleComposite, uppercaseInputRule };
            IRule allRules = new RuleComposite(allRulesDefinition);

            allRules.ExecuteRule();
        }
    }
}