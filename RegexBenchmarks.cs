using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexDemodotnet7
{
    [MemoryDiagnoser]
    public partial class RegexBenchmarks
    {
        private const string EmailRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
         @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
         @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
        private readonly Regex _oldEmailRegex=new Regex(EmailRegex);
        private readonly Regex _oldCompiledEmailRegex = new Regex(EmailRegex,RegexOptions.Compiled);

        [RegexGenerator(EmailRegex)]
        private partial Regex NewEmailRegex();

        private readonly Regex _newEmailRegex;

        public RegexBenchmarks(){
            _newEmailRegex=NewEmailRegex();
        }

        [Params("ppillarisetti@ariqt.com","ppillarisetti.com")]

        public string PotentialEmail { get; set; } = default!;

        [Benchmark]
        public bool Old_IsMatch_Email()
        {
            return _oldEmailRegex.IsMatch(PotentialEmail);
        }
        [Benchmark]
        public bool Old_Compiled_IsMatch_Email()
        {
            return _oldCompiledEmailRegex.IsMatch(PotentialEmail);
        }
        [Benchmark]
        public bool New_IsMatch_Email()
        {
            return NewEmailRegex().IsMatch(PotentialEmail);
        }
        [Benchmark]
        public bool New_Compiled_IsMatch_Email()
        {
            return _newEmailRegex.IsMatch(PotentialEmail);
        }
    }
}
