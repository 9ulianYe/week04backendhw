// See https://aka.ms/new-console-template for more information

/* ch3-1  Q.請印出從1加到50的結果?*/

//int sum = 0;
//for (int i = 1; i <= 50; i++)
//{
//    sum = sum+i;
//}
//Console.WriteLine(sum);
//Console.ReadKey();

/* ch3-1  Q.請印出從1加到500的結果?*/

//int sum = 0;
//for (int i = 1; i <= 500; i++)
//{
//    sum = sum + i;
//}
//Console.WriteLine(sum);
//Console.ReadKey();

/* 例題3.1 讀入五個整數， 求這五個整數的和*/

//Console.WriteLine("input 5 number ");
//double sum = 0;

//int i = 1;
//while (i<=5)
//{
//    Console.Write($"number{i} = ");
//    double num = Convert.ToDouble(Console.ReadLine());
//    sum = sum + num;
//    i++;
//}
//Console.Write($"sum = {sum}");
//Console.ReadKey();


/*例題3.2 求N個整數的和，N由使用者輸入*/

/* for loop*/

//Console.Write("enter input count = ");
//int inputCount = Convert.ToInt32(Console.ReadLine());
//int num = 0;
//int sum = 0;

//for (int i = 1; i <= inputCount; i++)
//{
//    Console.Write($"num{i}= ");
//    num = Convert.ToInt32(Console.ReadLine());
//    sum = sum + num;
//}
//Console.WriteLine($"sum = {sum}");
//Console.ReadKey();

/* while loop*/

//Console.Write("enter input count = ");
//int inputCount = Convert.ToInt32(Console.ReadLine());
//int num = 0;
//int sum = 0;
//int i = 1;
//while (i<= inputCount)
//{
//    Console.Write($"num{i}= ");
//    num = Convert.ToInt32(Console.ReadLine());
//    sum = sum + num;
//    i++;
//}
//Console.WriteLine($"sum = {sum}");
//Console.ReadKey();




/* 例題3.3 假設有N個正整數，求其中的最大值*/

/* for loop*/

//Console.WriteLine("how many number do you want to input ?");
//int n = Convert.ToInt32(Console.ReadLine());
//int number = 0;
//int max = 0;
//for (int i = 1; i <= n; i++)
//{
//    Console.Write($"the {i} number = ");
//    number = Convert.ToInt32(Console.ReadLine());
//    if (max >= number)
//    {

//    }
//    else
//    {
//        max = number;

//    }
//}
//Console.Write($"the largest number is {max}");
//Console.ReadKey();

/* while loop*/

//Console.WriteLine("how many number do you want to input ?");
//int n = Convert.ToInt32(Console.ReadLine());
//int number = 0;
//int max = 0;
//int i = 1;
//while (i <= n)
//{
//    Console.Write($"the {i} number = ");
//        number = Convert.ToInt32(Console.ReadLine());
//        if (max >= number)
//        {
//        }
//        else
//        {
//            max = number;
//        }
//    i++;
//}
//Console.Write($"the largest number is {max}");
//Console.ReadKey();

/* 例題3.4假設有N個正整數，求最大奇數值。*/

/* for loop*/

//Console.WriteLine("how many number do you want to input ?");
//int n = Convert.ToInt32(Console.ReadLine());
//int num = 0;
//int max = 0;
//for (int i = 1; i <= n; i++)
//{
//    Console.Write($"the {i} number = ");
//    num = Convert.ToInt32(Console.ReadLine());
//    if (num%2==1)
//    {
//        if (max>num)
//        {

//        }
//        else
//        {
//            max = num;
//        }
//    }
//}
//Console.Write($"the largist number = {max}");
//Console.ReadKey();

/* while loop*/
//Console.WriteLine("how many number do you want to input ?");
//int n = Convert.ToInt32(Console.ReadLine());
//int num = 0;
//int max = 0;
//int i = 1;
//while (i<=n)
//{
//    Console.Write($"the {i} number is = ");
//    num = Convert.ToInt32(Console.ReadLine());
//    if (num%2 == 1)
//    {
//        if (max>num)
//        {

//        }
//        else
//        {
//           max = num;
//        }
//    }
//    i++;
//}
//Console.Write($"the largist number = {max}");
//Console.ReadKey();

/* 例題3.5 求N階層 p28，即求1×2×3×…×N。*/

/*for loop*/

//Console.Write("N = ");
//int n = Convert.ToInt32(Console.ReadLine());
//int num = 1;
//for (int i = 1; i <= n; i++)
//{
//    num = i * num;
//}
//Console.Write($"{n}! = {num}");
//Console.ReadKey();

/*while loop*/

//Console.Write("N = ");
//int n = Convert.ToInt32(Console.ReadLine());
//int num = 1;
//int i = 1;
//while (i<=n)
//{
//    num = num * i;
//    i++;
//}
//Console.Write($"{n}! = {num}");
//Console.ReadKey();


/* 例題3.6 p.35 輸出一個九九乘法表 */

/*for loop*/

//int num = 1;
//for (int i = 1; i <= 9; i++)
//{
//    for (int j =1;  j<= 9; j++)
//    {
//        num = i * j;
//        Console.WriteLine($"{i}*{j}={num}");

//    }
//    Console.WriteLine();
//}
//Console.ReadKey();

/*while loop*/

//int num = 1;
//int i = 1;
//while (i<=9)
//{
//    int j =1;
//    while (j<=9)
//    {
//        num = i * j;
//        Console.WriteLine($"{i}*{j}={num}");
//        j++;
//    }
//    Console.WriteLine();
//    i++;
//}
//Console.ReadKey();

例題3.7 請將程式九九乘法表改成3*3的排列  





/* 習題 3-1.寫一程式，輸入10個整數，求其最小值。 */

/* for loop*/

//int num = 0;
//int min = int.MaxValue; 

//for (int i = 1; i <= 10; i++)
//{   Console.Write($"the {i} number =  ");
//    num = Convert.ToInt32(Console.ReadLine());
//    if (min <= num) { 
//    }
//    else
//    {
//        min = num;
//    }
//}
//Console.WriteLine($" the min number = {min}");
//Console.ReadKey();

/* while loop */

//int num = 0;
//int min = int.MaxValue;

//int i = 1;
//while (i<=10)
//{
//    Console.Write($"the {i} number =  ");
//    num = Convert.ToInt32(Console.ReadLine());
//    if (min <= num) { 
//    }
//    else
//    {
//        min = num;
//    }
//    i++;
//}
//Console.WriteLine($"the min number = {min}");
//Console.ReadKey();

/* 習題 3-2.寫一程式，輸入N個整數，求其最小值。*/
/* for loop*/

//int n;
//int min = int.MaxValue;

//Console.Write("N = ");
//n = Convert.ToInt32(Console.ReadLine());

//for (int i = 1; i <= n; i++)
//{
//    Console.Write($"the {i} number = ");
//    int num = Convert.ToInt32(Console.ReadLine());
//    if (min < num)
//    {

//    }
//    else { 
//    min = num;
//    }
//}
//Console.Write($"the min num = {min}");
//Console.ReadKey();

/* while loop */

//int min = int.MaxValue;

//Console.Write("N = ");
//int n = Convert.ToInt32(Console.ReadLine());

//int i = 1;
//while (i<=n)
//{
//    Console.Write($"the {i} number = ");
//    int num = Convert.ToInt32(Console.ReadLine());
//    if (min < num)
//    {

//    }
//    else
//    {
//        min = num;
//    }
//    i++;
//}

//Console.Write($"the min number = {min}");
//Console.ReadKey();



/* 習題 3-3.寫一程式，輸入10個整數，列出其中所有大於12的數字。*/

/* for loop*/

//int num;
//for (int i = 1; i <= 10; i++)
//{
//    Console.Write($"the {i} number = ");
//    num = Convert.ToInt32(Console.ReadLine());
//    if (num > 12)
//    {
//        Console.WriteLine($"{num}>12");
//    }
//}
//Console.ReadKey();

/* while loop*/

//int num;
//int i = 1;
//while (i<=10) {
//    Console.Write($"the {i} number = ");
//    num = Convert.ToInt32(Console.ReadLine());
//    if (num > 12)
//    {
//        Console.WriteLine($"{num}>12");
//    }
//    i++;
//}
//Console.ReadKey();




/* 習題 3-4.寫一程式，輸入10個整數，列出其中所有大於12的數字的總和。*/

/* for loop*/

//int sum = 0;
//for (int i = 1; i <= 10; i++)
//{
//    Console.Write($"the {i} number = ");
//    int num = Convert.ToInt32(Console.ReadLine());
//     if (num > 12)
//    {
//        sum =sum + num;
//    }
//}
//Console.WriteLine($"sun = {sum} ");
//Console.ReadKey();

/* while loop*/

//int sum = 0;
//int i = 1;
//while (i<=10)
//{
//    Console.Write($"the {i} number = ");
//    int num = Convert.ToInt32(Console.ReadLine());
//     if (num > 12)
//    {
//        sum =sum + num;
//    }
//    i++;
//}
//Console.WriteLine($"sun = {sum} ");
//Console.ReadKey();


/* 習題 3-5.寫一程式，輸入N個數字，求其所有奇數中的最大值。例如輸入11,12,3,24,15，答案是15。*/

/* for loop*/

//Console.Write("N = ");
//int n = Convert.ToInt32(Console.ReadLine());
//int max = int.MinValue;

//for (int i = 1; i <=n ; i++)
//{
//    Console.Write($"the {i} number = ");
//    int num = Convert.ToInt32(Console.ReadLine());
//    if (max < num)
//    {
//        max = num;
//    }
//    else {
//        max = max;
//    }
//}
//Console.WriteLine($"the max number = {max}");
//Console.ReadKey();

/* while loop */

//Console.Write("N = ");
//int n = Convert.ToInt32(Console.ReadLine());
//int max = int.MinValue;

//int i = 1;
//while (i<=n)
//{
//    Console.Write($"the {i} number = ");
//    int num = Convert.ToInt32(Console.ReadLine());
//    if (max < num)
//    {
//        max = num;
//    }
//    else {
//        max = max;
//    }

//    i++;
//}

//Console.WriteLine($"the max number = {max}");
//Console.ReadKey();



/*習題 3-6.寫一程式，輸入N個數字，求其所有正數之平方的加總。例如輸入1,-2,3,-4,5五個數字*/

/*for loop*/

//int sum = 0;
//int square = 0;
//Console.Write("N = ");
//int n = Convert.ToInt32(Console.ReadLine());
//for (int i = 1; i <=n; i++)
//{
//    Console.Write($"the {i} number = ");
//    int num = Convert.ToInt32(Console.ReadLine());
//    if (num>0)
//    {
//        square = num * num;
//        sum = sum + square;
//    }
//}
//Console.WriteLine($"the sum = {sum}");
//Console.ReadKey();

/*while loop*/

//int sum = 0;
//int square = 0;
//Console.Write("N = ");
//int n = Convert.ToInt32(Console.ReadLine());
//int i = 1;
//while (i <= n)
//{
//     Console.Write($"the {i} number = ");
//    int num = Convert.ToInt32(Console.ReadLine());
//    if (num > 0)
//    {
//        square = num * num;
//        sum = sum + square;
//    }
//    i++;
//}
//Console.WriteLine($"the sum = {sum}");
//Console.ReadKey();


/* 習題 3-7.寫一程式，輸入N個數字，其中有些是負數，將這些負數轉換成正數，例如-7會被轉換成7。 */

/* for loop*/

//int abs;
//Console.Write("N = ");
//int n = Convert.ToInt32(Console.ReadLine());
//for (int i = 1; i <= n; i++)
//{
//    Console.Write($"the {i} number = ");
//    int num = Convert.ToInt32(Console.ReadLine());
//    if (num<0)
//    {
//        num = -1 * num;
//    }
//    Console.WriteLine($"the num = {num}");
//}
//Console.ReadKey();

/* while loop*/

//Console.Write("N = ");
//int n = Convert.ToInt32(Console.ReadLine());
//int i = 1;
//while (i <= n)
//{
//     Console.Write($"the {i} number = ");
//    int num = Convert.ToInt32(Console.ReadLine());
//    if (num<0)
//    {
//        num = -1 * num;
//    }
//    Console.WriteLine($"the num = {num}");
//    i++;
//}
//Console.ReadKey();

/* 補充習題 1.判斷101-200之間有多少個質數，並輸出所有質數。*/

//int count = 0;
//for (int i = 101; i <=200; i++)
//{   bool isPrimeNumber = true;
//    double sqrtI =  Math.Truncate(Math.Sqrt(i));;
//    for (int j = 2; j <= sqrtI; j++) {
//        if (i%j ==0)
//        {
//            isPrimeNumber = false;
//            break;
//        }

//    }

//    if (isPrimeNumber) { 
//        Console.WriteLine(i)  ;
//        count++;
//    }
//}
//Console.WriteLine($"有{count}個質數");
//Console.ReadKey();


/* 補充習題 2.輸入一個數，輸出其質因數 */

//Console.Write("輸入一個數 = ");
//int num = Convert.ToInt32(Console.ReadLine());

//for (int i = 2; i <= num; i++)
//{
//    if (num % i == 0) {

//        //如果num能被i整除，i是num的因數
//        bool isPrimeNumber = true; 
//        double sqrtI = Math.Truncate(Math.Sqrt(i));
//        for (int j = 2; j <= sqrtI; j++) {
//            if (i % j == 0) {
//                isPrimeNumber = false;
//                break;
//            }
//        }
//        if (isPrimeNumber) {
//            Console.WriteLine(i);
//        }
//    }
//}
//Console.ReadKey();



/* 補充習題 3.求100到300中可以被3與7整除的個數。*/
/* for loop */

//int count = 0;
//for (int i = 100; i <= 300; i++)
//{
//    if (i % 21 == 0)
//    {
//        count++;
//    }
//}
//Console.WriteLine($"100到300中可以被3與7整除的個數 = {count}");
//Console.ReadKey();

/* while loop*/

//int count = 0;
//int i = 100;
//while (i<=300)
//{
//    if (i % 21 == 0)
//    {
//        count++;
//    }
//    i++;
//}

//Console.WriteLine($"100到300中可以被3與7整除的個數 = {count}");
//Console.ReadKey();

/* 例題4.1 讀入一連串的數字，但事先不知道數字的數目。設定一個特殊的數字，一旦讀到這個數字就終止迴圈。
 * 假設輸入的都是正數，一旦讀到負數就終止。
*/

//int num = 0;
//do
//{
//    Console.WriteLine("input a number = ");
//    num = Convert.ToInt32(Console.ReadLine());
//}
//while (num >0);

//Console.WriteLine($"the number = {num} ");
//Console.ReadKey();




例題4.2 求最大公約數(Greatest Common Divisor，簡寫G.C.D.，或稱最大公因數)

/* 例題4.3 計算N個數字的和。檢查i有沒有超過N，超過就不做了*/
/* 白話：請設計一個流程或程式，可以輸入 N 個數字，並計算這 N 個數字的總和。*/

//int num = 0;
//int sum = 0;
//Console.Write("N = ");
//int n = Convert.ToInt32(Console.ReadLine());

//for (int i = 1; i <= n; i++)
//{
//    Console.Write($"the {i} number = ");
//    num = Convert.ToInt32(Console.ReadLine());
//    sum = sum + num;

//}
//Console.WriteLine($"sum = {sum}");
//Console.ReadKey();


/* 習題 4-1.利用while寫一程式求N個數字的最大值。 */

//int num = 0;
//int max = int.MinValue;
//Console.Write("N = ");
//int n = Convert.ToInt32(Console.ReadLine());
//for (int i = 1; i <= n; i++) {
//    Console.Write($"the {i} number = ");
//    num = Convert.ToInt32(Console.ReadLine());
//    if (max<num)
//    {
//        max = num;
//    }
//}
//Console.WriteLine($"the max num = {max}");
//Console.ReadKey();


/* 習題 4-2.利用while寫一程式求一個等差級數數字的和，一共有N個數字，程式應該輸入最小的起始值以及數字間的差。
 * (即從起始值開始，間格差，共N個 的總和)
 *  白話: 輸入N、起始值、公差 */
/* 補充: 等差公式 
 * 第n項 an = a0+ nd
 * S = a1+a2+a3+...an */

//Console.Write("N = ");
//int n = Convert.ToInt32(Console.ReadLine());
//Console.Write("initial num = ");
//int a0 = Convert.ToInt32(Console.ReadLine());
//Console.Write("d = ");
//int d = Convert.ToInt32(Console.ReadLine());

//int an = 0;
//int sum = 0;
//int i = 0;
//while (i<n)
//{
//    an = a0 + i*d;
//    sum = an+sum;
//    i++;
//}
//Console.Write($"sum = {sum}");
//Console.ReadKey(); 


/* 習題 4-3.利用while寫一程式，讀入N個數字，然後找出所有小於13的數，再求這些數字的和。*/

//int sum = 0;
//Console.Write("N = ");
//int n = Convert.ToInt32(Console.ReadLine());
//int i = 1;
//while (i <= n) {
//    Console.Write($"第{i}個數字 = ");
//    int num = Convert.ToInt32(Console.ReadLine());
//    if (num < 13) { 
//    sum = sum + num;
//    }
//    i++;
//}
//Console.Write($"Sum = {sum}");
//Console.ReadKey();

/*習題 4-4.利用while寫一程式，讀入N個數字，找到第一個大於7而小於10的數字就停止，而且列印出這個數字*/

//Console.Write("N = ");
//int n = Convert.ToInt32(Console.ReadLine());

//int i = 1;
//while (i<=n)
//{
//    Console.Write($"第{i}個數字 = ");
//    int num = Convert.ToInt32(Console.ReadLine());
//    if (num > 7 && num < 10) {
//        Console.WriteLine($"你找到了，數字{num}");
//        break;
//    }
//    i++;

//}
//Console.ReadKey();

/* 習題 4-5.利用while寫一程式，讀入a1,a2,…,a5和b1,b2,…,b5。找到第一個ai>bi，即停止，並列印出ai及bi。*/
int i = 1;
while (i<=5) {
    Console.Write($"a{i} = ");
    int a = Convert.ToInt32( Console.ReadLine() );
    i++;
}






/* 補充題目 1.Eric覺得麥蒂勞的39元漢堡實在太便宜、太好吃了，因此他決定晚餐要把口袋裡所有錢通通拿來吃39元漢堡。
假設他每5分鐘就能吃一個漢堡，請隨意輸入一個時間，輸出這段時間吃漢堡的紀錄。*/

//Console.Write("input time (min) = ");
//int min = Convert.ToInt32(Console.ReadLine());
//int humbergerCount = 1;
//for (int i = 1; i <= min; i++)
//{
//    if (i % 5 != 0)
//    {
//        Console.WriteLine($"第{i}分鐘時，正在吃第{humbergerCount}個漢堡");
//    }
//    else
//    {
//        Console.WriteLine($"第{i}分鐘時，已經吃完第{humbergerCount}個漢堡");
//        humbergerCount++;
//    }
//}       
//Console.ReadKey();  



補充題目 2.小明貸款買房花560萬，每個月可還4萬，每還12個月，因為年終獎金可以多還一萬，請問需要幾個月還清。

/* 補充題目 3.系統隨機產生一個數字，讓使用者數入數字，直到猜中才離開程式！，猜錯時，要提示是比較大還是比較小。*/

//Console.WriteLine("系統隨機產生一個1~20的數字");
//Random rnd = new Random();
//int ans = rnd.Next(1,21);

//do
//{
//    Console.Write("猜數字是多少 = ");
//    int num = Convert.ToInt32(Console.ReadLine());
//    if (num == ans) {
//        break;
//    }
//    else if (num < ans)
//    {
//         Console.WriteLine("你的num比ans小，再猜高一點");
//    }
//    else
//    {
//       Console.WriteLine("你的num比ans大，再猜低一點"); 
//    }
//}
//while (true);
//Console.WriteLine($"你答對了，答案是{ans}");
//Console.ReadKey();

