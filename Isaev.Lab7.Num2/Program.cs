using System.Text;
{
    #region "Var.1"
    {
        var A = Console.ReadLine().ToCharArray();
        StringBuilder str1 = new StringBuilder();
        StringBuilder str2 = new StringBuilder();


        for (int i = 0; i < A.Length; i++)
        {
            if (i % 2 == 0)
            {
                str1.Append(A[i]);
            }
            if (i % 2 == 1)
            {
                str2.Append(A[i]);
            }
        }
        Console.WriteLine(str1);
        Console.WriteLine(str2);
    }
    #endregion

    #region "Var.2"
    {
        var str = Console.ReadLine();
        var res1 = string.Concat(str.Where((c, i) => i % 2 != 0)); //i % 2 == 0 если нумерация начинается с 0
        var res2 = string.Concat(str.Where((c, i) => i % 2 == 0));//i % 2 != 0 если нумерация начинается с 0
        Console.WriteLine(res1);
        Console.WriteLine(res2);
    }
    #endregion
}