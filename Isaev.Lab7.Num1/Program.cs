
    #region "Var.1"
    {
        var str = Console.ReadLine().ToCharArray();
        int countWords = 0;
        int id = 0;
        //Ставим флаг поиска пробела в false - это позволит 
        //избежать ошибок, если в начале строки будут пробелы
        bool findSpace = false;
        //Идём по символам строки
        while (id < str.Length)
        {
            //Если нашли пробел
            if (str[id] == ' ')
            {
                //Проверяем - искали-ли мы его.
                //Если искали, то ставим флаг того, что нашли, 
                //если не искали (ищщем уже не пробел) - просто идём дальше.
                if (findSpace)
                    findSpace = false;
            }
            //Если нашли не пробел
            else
            {
                //Если искали пробел, то ничего не делаем, 
                //а просто идём дальше, в противном случае
                //Говорим, что мы нашлю символ-который-не-пробел,
                //и увеличиваем счётчик
                if (!findSpace)
                {
                    //Говорим, что теперь ищщем снова пробел
                    findSpace = true;
                    //Увеличиваем счётчик слов
                    countWords++;
                }
            }

            id++;
        }
        Console.WriteLine(countWords);
    }
    #endregion

    #region "Var.2"
    {
        var str = Console.ReadLine();
        var str1 = str.Trim().Split(' ');
        Console.WriteLine(str1.Length);
    }
    #endregion


