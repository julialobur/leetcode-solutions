using System.ComponentModel.Design;

namespace LeetCodeSolutions.Easy;

public class FirstBadVersionSolution : VersionControl
{
    public int FirstBadVersion(int n)
    {
        int left = 1;
        int right = n;
        while (left < right)
        {
            int mid = left + (right - left) / 2;

            if (IsBadVersion(mid))
            {
                if (mid == 1 || (mid - 1 > 0 && !IsBadVersion(mid - 1)))
                {
                    return mid;
                }
                else
                {
                    right = mid;
                }
            }
            else
            {
                left = mid + 1;
            }
        }
        return left;
    }
}
