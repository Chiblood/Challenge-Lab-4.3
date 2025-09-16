/* Challenge Lab 4.3
3. Write a function that reverses a string. The input string is given as an array of characters s.

You must do this by modifying the input array in-place. (Problem 344 in leetcode)

Example 1:

Input: s = ["h","e","l","l","o"]

Output: ["o","l","l","e","h"]

Example 2:

Input: s = ["H","a","n","n","a","h"]

Output: ["h","a","n","n","a","H"]
*/
public class ChallengeLab4_3
{
    public void ReverseString(char[] s)
    {
        int left = 0;
        int right = s.Length - 1;

        while (left < right)
        {
            // Swap characters at left and right indices
            char temp = s[left];
            s[left] = s[right];
            s[right] = temp;

            // Move towards the middle
            left++;
            right--;
        }
    }
}