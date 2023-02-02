
public class Program
{
    static int countAll = 0;
    public static void Main(string[] args)
    {
        Console.WriteLine(Solution("23A84Q", "K2Q25J"));
    }

    public static int Solution(String alec, String bob)
    {
        if (alec.Length != bob.Length)
            return -1;

        int count = 0;
        for (int i = 0; i < alec.Length; i++)
        {
            char aCard = alec.ToCharArray()[i];
            char bCard = bob.ToCharArray()[i];

            count = GetRank(aCard, bCard);
        }

        return count;
    }

    public static int GetRank(char a, char b)
    {
        Dictionary<int, string> rank = new Dictionary<int, string>();
        rank.Add(2, "2");
        rank.Add(3, "3");
        rank.Add(4, "4");
        rank.Add(5, "5");
        rank.Add(6, "6");
        rank.Add(7, "7");
        rank.Add(8, "8");
        rank.Add(9, "9");
        rank.Add(10, "T");
        rank.Add(11, "J");
        rank.Add(12, "Q");
        rank.Add(13, "K");
        rank.Add(14, "A");
        
        int aPoint = rank.FirstOrDefault(v => v.Value == a.ToString()).Key;

        //foreach(string value in rank.Values)
        //{
        //    if (value.Equals(a.ToString()))
        //    {
        //        foreach (var item in rank)
        //        {
        //            if (item.Value.Equals(value))
        //            {
        //                aPoint = item.Key;
        //            }
        //        }
        //    }
        //}

        int bPoint = rank.FirstOrDefault(v => v.Value == b.ToString()).Key;
        //foreach(string value in rank.Values)
        //{
        //    if (value.Equals(b.ToString()))
        //    {
        //        foreach(var item in rank)
        //        {
        //            if (item.Value.Equals(value))
        //            {
        //                bPoint = item.Key;
        //            }
        //        }
        //    }
        //}

        if (aPoint > bPoint)
            countAll++;

        return countAll;
    }
}