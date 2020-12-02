using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using ObjectLayoutInspector;
using StructLinq.BCL.Dictionary;
using Xunit;

namespace StructLinq.BCL.Tests
{

    public class DictionaryLayoutTests
    {
        [Fact]
        public void PrintLayout()
        {
            TypeLayout.PrintLayout<Dictionary<string, int>>();
            TypeLayout.PrintLayout<DictionaryLayout<string, int>>();
        }

        [Fact]
        public void EntryShouldMatch()
        {
            var comparer = EqualityComparer<string>.Default;
            var dico = Enumerable.Range(0, 5)
                                 .ToDictionary(x => x.ToString(), x => x, comparer);
            var dictionaryLayout = Unsafe.As<Dictionary<string, int>, DictionaryLayout<string, int>>(ref dico);

            for (int i = 0; i < 5; i++)
            {
                var entry = dictionaryLayout.Entries[i];
                entry.Value.Should().Be(i);
                entry.Key.Should().Be(i.ToString());
            }   
        }
    }
}
