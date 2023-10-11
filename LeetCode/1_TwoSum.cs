using System.Linq;

namespace LeetCode;

public partial class LeetCodeSolution
{
    public int[] TwoSum()
    {
        // nums = [2,7,11,15], target = 9
        // nums = [3,2,4], target = 6

        int[] arr = new int[] { 2, 7, 11, 15 };
        int alvo = 9;

        // Pegar um indice,
        // Ir somando com os outros, se der a soma, break
        // Se não, pegar o proximo e ir somando

        List<int> result = new();

        for (int i = 0; i < arr.Length; i++)
        {
            var next = i + 1;
            var sum = arr[i] + next;

            if (sum == alvo)
            {
                result.Add(arr[i]);
                result.Add(next);
                break;
            }
        }

        return arr;
    }
}
