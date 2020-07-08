using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using StructLinq.BCL.Dictionary;
using Xunit;

namespace StructLinq.BCL.Tests
{
    public abstract class DictionaryLayoutTests<TKey, TValue>
    {
        protected abstract TKey buildKey(int i);
        protected abstract TValue buildValue(int i);

        Dictionary<TKey, TValue> Dictionary(int size)
        {
            var dico = Enumerable.Range(0, 5)
                                 .ToDictionary(buildKey, buildValue);
            return dico;
        }
    }


    public class DictionaryLayoutTests
    {
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
