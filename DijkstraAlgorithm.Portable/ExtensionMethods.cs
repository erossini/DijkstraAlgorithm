using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DijkstraAlgorithm.Portable {
   /// <summary>
   /// Adds or Updates the dictionary to include the destination and its associated cost and complete path (and param arrays make paths easier to work with)
   /// </summary>
   public static void Set<T>(this Dictionary<T, KeyValuePair<int, LinkedList<Path<T>>>> Dictionary, T destination, int Cost, params Path<T>[] paths) {
      var CompletePath = paths == null ? new LinkedList<Path<T>>() : new LinkedList<Path<T>>(paths);
      Dictionary[destination] = new KeyValuePair<int, LinkedList<Path<T>>>(Cost, CompletePath);
   }
}