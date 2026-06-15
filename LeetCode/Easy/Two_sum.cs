// Time Complexity: O(n²) - two nested loops
// Space Complexity: O(1) - no extra space used

int[] input = {2, 7, 11, 15};
var target = 9;


for (int i = 0; i < input.Length; i++)
{
  for(int j = i + 1; j < input.Length; j++)
  {
    int sum = input[i] + input[j];

    if(sum == target){
      Console.WriteLine($"{i}, {j}")
    }
  }
}