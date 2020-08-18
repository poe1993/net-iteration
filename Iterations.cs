using System;
using System.Collections.Generic;
using System.Linq;
using DotnetIteration.Models;

namespace DotnetIteration
{

    public static class Iteration
    {
        public static IEnumerable<string> Yelling(List<string> words)
        {
            var newWords = words.Select(word => word.ToUpper());
            return newWords;
        }
        public static IEnumerable<int> Double(List<int> numbers)
        {
            var doubleNumbers = numbers.Select(number => number * 2);
            return doubleNumbers;
        }
        public static IEnumerable<string> StringyIndexes(List<string> data)
        {
            var newIndexes = data.Select((stringy, index) => $"{stringy} is at index {index}");
            return newIndexes;
        }
        public static IEnumerable<int> OnlyTheEvenSurvive(List<int> data)
        {
            var survivingEvens = data.Where(data => data % 2 == 0);
            return survivingEvens;
        }
        public static IEnumerable<int> OnlyTheEvenIndexedSurvive(List<int> data)
        {
            var survivingIndexes = data.Where((data, index) => index % 2 == 0);
            return survivingIndexes;
        }
        public static IEnumerable<string> BestMovieOfTheYear(List<Movie> data, int year)
        {
            var bestMovies = data.Where(data => data.Year == year && data.Score > 90).Select(data => data.Name);
            return bestMovies;
        }
        public static bool EveryoneIsOdd(List<int> data)
        {
            var areTheyOdds = data.All(data => data % 2 != 0);
            return areTheyOdds;
        }
        public static string FindTheNeedle(List<string> data)
        {
            var foundNeedle = data.FirstOrDefault(data => data.Contains("needle"));
            return foundNeedle;
        }
        public static int FindTheNeedleIndex(List<string> data)
        {
            var foundIndex = data.FindIndex(data => data.Contains("needle"));
            return foundIndex;
        }
        public static bool SomeoneToLove(List<string> data)
        {
            var foundLove = data.Any(data => data.Count() == 4);
            return foundLove;
        }
    }
}