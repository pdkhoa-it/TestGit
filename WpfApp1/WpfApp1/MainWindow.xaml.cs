using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //int[] value = TwoSum(new int[] { 1, 1, 1, 1, 1, 4, 1, 1, 1, 1, 1, 7, 1, 1, 1, 1, 1 }, 11);
        }

        public string twoArrays(int k, List<int> A, List<int> B)
        {
            bool checkMin = false;
            for (int i = 0; i < A.Count; i++)
            {
                checkMin = false;
                for (int j = 0; j < B.Count; j++)
                {
                    if (A[i] + B[j] >= k)
                    {
                        checkMin = true;
                        B[j] = 0;
                        break;
                    }
                }
                if (!checkMin)
                {
                    return "NO";
                }
            }
            return "YES";
        }

        public string pangrams(string s)
        {
            s = s.ToLower();
            int count = 26;
            for(int i=97; i <= 122; i++)
            {
                if (s.Contains(((char)i).ToString()))
                {
                    count--;
                }
            }
            return count == 0 ? "pangram" : "not pangram";
        }

        public int diagonalDifference(List<List<int>> arr)
        {
            int sumI = 0, sumII = 0;
            int pos = 0;
            for(int i = 0; i < arr.Count; i++)
            {
                sumI += arr[i][pos];
                sumII += arr[i][arr.Count - pos - 1];
                pos++;
            }
            return Math.Abs(sumI - sumII);
        }

        public static long flippingBits(long n)
        {
            string binaryValue = Convert.ToString(n, 2).PadLeft(32, '0');
            binaryValue = binaryValue.Replace("0", "-");
            binaryValue = binaryValue.Replace('1', '0');
            binaryValue = binaryValue.Replace('-', '1');
            return Convert.ToInt64(binaryValue, 2);
        }
        public int lonelyinteger(List<int> a)
        {
            int max = 0;
            for (int i = 0; i < a.Count; i++)
            {
                if (max < a[i] && a.Count(x => x == a[i]) == 1)
                {
                    max = a[i];
                }
            }
            return max;
        }
        public List<int> matchingStrings(List<string> strings, List<string> queries)
        {
            List<int> result = new List<int>();
            for(int i = 0; i < queries.Count; i++)
            {
                result.Add(strings.Count(x => x == queries[i]));
            }
            return result;
        }

        public string timeConversion(string s)
        {
            if (s[8] == 'A')
            {
                if (int.Parse(s.Substring(0, 2)) < 12)
                {
                    return s.Substring(0, 8);
                }
                else
                {
                    return "00" + s.Substring(2, 6);
                }
            }
            else
            {
                if (int.Parse(s.Substring(0, 2)) < 12)
                {
                    return (int.Parse(s.Substring(0, 2)) + 12).ToString() + s.Substring(2, 6);
                }
                else
                {
                    return "12" + s.Substring(2, 6);
                }
            }
        }
        public void miniMaxSum(List<int> arr)
        {
            arr.Sort();
            decimal maxSum = 0;
            for (int i = 0; i < 5; i++)
            {
                maxSum += arr[i];
            }
            Console.WriteLine((maxSum - arr[4]).ToString() + " " + (maxSum - arr[0]).ToString());
        }
        public void plusMinus(List<int> arr)
        {
            int pos = 0, neg = 0, zero = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] > 0)
                {
                    pos++;
                }
                else if (arr[i] < 0)
                {
                    neg++;
                }
                else
                {
                    zero++;
                }
            }

            Console.WriteLine((float)pos / arr.Count);
            Console.WriteLine((float)neg / arr.Count);
            Console.WriteLine((float)zero / arr.Count);
        }

        private int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int needNum = target - nums[i];
                if (dictionary.ContainsKey(needNum) && dictionary[needNum] != i)
                {
                    return new int[] { i, dictionary[needNum] };
                }
                dictionary[nums[i]] = i;
            }
            return new int[] { nums[0], nums[1] };
        }
    }
}
