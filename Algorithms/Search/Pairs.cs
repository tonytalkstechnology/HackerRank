using System;
using System.Collections.Generic;
using System.IO;
class Solution {
/* Head ends here */
static int pairs(int[] a, int k, Dictionary<int, int> map) {
    
    int count = 0;
    
    foreach (var item in a) {
        if (map.ContainsKey(Math.Abs(item + k))) {
            count++;
        }
    }
    
    return count;
    }
/* Tail starts here */
static void Main(String[] args) {
        int res;
        
        String line = Console.ReadLine();
        String[] line_split = line.Split(' ');
        int _a_size = Convert.ToInt32(line_split[0]);
        int _k = Convert.ToInt32(line_split[1]);
        int[] _a = new int [_a_size];
        int _a_item;
        Dictionary<int, int> map = new Dictionary<int, int>();
        String move = Console.ReadLine();
        String[] move_split = move.Split(' ');
        for(int _a_i = 0; _a_i < move_split.Length; _a_i++) {
            _a_item = Convert.ToInt32(move_split[_a_i]);
            _a[_a_i] = _a_item;
            map.Add(_a_item, 1);
        }
        
        res = pairs(_a,_k,map);
        Console.WriteLine(res);
        
    }
}

