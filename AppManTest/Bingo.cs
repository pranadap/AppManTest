using AppManTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppManTest
{
    public class Bingo
    {
        private List<BingoModel> GetBingo()
        {
            var resultBingo = new List<BingoModel>();
            resultBingo.Add(new BingoModel() { value = new int[] { 1, 2, 3, 4, 5 } });
            resultBingo.Add(new BingoModel() { value = new int[] { 6, 7, 8, 9, 10 } });
            resultBingo.Add(new BingoModel() { value = new int[] { 11, 12, 13, 14, 15 } });
            resultBingo.Add(new BingoModel() { value = new int[] { 16, 17, 18, 19, 20 } });
            resultBingo.Add(new BingoModel() { value = new int[] { 21, 22, 23, 24, 25 } });

            resultBingo.Add(new BingoModel() { value = new int[] { 1, 6, 11, 16, 21 } });
            resultBingo.Add(new BingoModel() { value = new int[] { 2, 7, 12, 17, 22 } });
            resultBingo.Add(new BingoModel() { value = new int[] { 3, 8, 12, 18, 23 } });
            resultBingo.Add(new BingoModel() { value = new int[] { 4, 9, 13, 19, 24 } });
            resultBingo.Add(new BingoModel() { value = new int[] { 5, 10, 15, 20, 25 } });

            resultBingo.Add(new BingoModel() { value = new int[] { 1, 7, 13, 19, 25 } });
            resultBingo.Add(new BingoModel() { value = new int[] { 5, 9, 13, 17, 21 } });

            return resultBingo;
        }

        public bool CheckBingo(int[] val)
        {
            if (val == null) return false;

            var list = GetBingo();
            var ret = new List<int>();
            foreach(var item in list)
            {
                ret = item.value.Intersect(val).ToList();
                if (ret.Count >= 5) return true;
            }
            return false;
        }
    }
}