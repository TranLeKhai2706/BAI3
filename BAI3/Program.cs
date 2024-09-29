//Bài tập cấu trức điều khiển
//Bài 1
//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.Write("Nhap vao mot so nguyen: ");
//        int n = Convert.ToInt32(Console.ReadLine());


//            if (n % 3 == 0)
//            {
//                Console.WriteLine($"chia het cho 3", n);
//            }
//            else
//            {
//                Console.WriteLine($"không chia het cho 3", n);
//            }
//    }
//}



//Bài 2
//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.Write("Nhap vao so nguyen duong n: ");
//        int n = Convert.ToInt32(Console.ReadLine());

//        if (n <= 0)
//        {
//            Console.WriteLine("Nhap so nguyen duong lon hon 0");
//            return;
//        }

//        for (int i = 1; i <= n; i++)
//        {
//            Console.WriteLine($"Bang cuu chuong {i}");
//            for (int j = 1; j <= 10; j++)
//            {
//                Console.Write("{i} x {j} = {i * j}");
//            }
//            Console.WriteLine();
//        }
//    }
//}



//Bài 4
//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.Write("Nhap vao mot so nguyen: ");
//        int n = Convert.ToInt32(Console.ReadLine());


//        double i = Math.Sqrt(n);

//        if (i % 1 == 0)
//        {
//            Console.WriteLine($"la so chinh phuong ", n);
//        }
//        else
//        {
//            Console.WriteLine($"khong phai la mot so chinh phuong.", n);
//        }
//    }
//}



//Bài 3
//class Program
//{
//    static int TinhGiaiThua(int n)
//    {
//        if (n == 0 || n == 1)
//            return 1;
//        else
//            return n * TinhGiaiThua(n - 1);
//    }
//    static void Main(string[] args)
//    {
//        Console.Write("Nhap vao so nguyen duong n: ");
//        int n = Convert.ToInt32(Console.ReadLine());

//        int tongGiaiThua = 0;
//        for (int i = 1; i <= n; i++)
//        {
//            tongGiaiThua += TinhGiaiThua(i);
//        }

//        Console.WriteLine("Tong gia thua tu 1 den {0} là: {1}", n, tongGiaiThua);
//    }
//}




//bài 5
//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.Write("Nhap vao thang (1-12): ");
//        int thang = Convert.ToInt32(Console.ReadLine());

//        Console.Write("Nhap vao nam: ");
//        int nam = Convert.ToInt32(Console.ReadLine());

//        int soNgay;

//        switch (thang)
//        {
//            case 1:
//            case 3:
//            case 5:
//            case 7:
//            case 8:
//            case 10:
//            case 12:
//                soNgay = 31;
//                break;
//            case 4:
//            case 6:
//            case 9:
//            case 11:
//                soNgay = 30;
//                break;
//            case 2:
//                if ((nam % 4 == 0 && nam % 100 != 0) || nam % 400 == 0)
//                    soNgay = 29;
//                // Năm nhuận
//                else
//                    soNgay = 28;
//                break;
//            default:
//                Console.WriteLine("Tháng không hợp lệ!");
//                return;
//        }

//        Console.WriteLine("Tháng {0} năm {1} có {2} ngày.", thang, nam, soNgay);
//    }
//}





//Bài 6
//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.Write("Nhap vao so nguyen n: ");
//        int n = Convert.ToInt32(Console.ReadLine());

//        double S = 0;

//        for (int i = 1; i <= n; i++)
//        {
//            S += i * i * i;
//        }

//        Console.WriteLine("Tong S = {0}", S);
//    }
//}




//Bài 7
//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.Write("Nhap vao so nguyen n: ");
//        int n = Convert.ToInt32(Console.ReadLine());

//        int tong = 0;

//        for (int i = 1; i <= n; i += 2)
//        {
//            tong += i;
//        }

//        Console.WriteLine("Tong cac so le tu 1 đen {0} la: {1}", n, tong);
//    }
//}


//Bài 9
//Tam giác đều
//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.Write("Nhập số hàng n: ");
//        int n = Convert.ToInt32(Console.ReadLine());

//        for (int i = 1; i <= n; i++)
//        {
//            Console.WriteLine(new string(' ', n - i) + new string('*', 2 * i - 1));
//        }
//    }
//}

//Tam giác xoay ngược
//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.Write("Nhập số hàng n: ");
//        int n = Convert.ToInt32(Console.ReadLine());

//        for (int i = n; i >= 1; i--)
//        {
//            Console.WriteLine(new string('*', i));
//        }
//    }
//}




//Bài 10
//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.Write("Nhap vao so luong so Fibonacci: ");
//        int n = Convert.ToInt32(Console.ReadLine());

//        int a = 0, b = 1, c;
//        Console.Write("Day Fibonacci: ");

//        for (int i = 1; i <= n; i++)
//        {
//            Console.Write(a + " ");
//            c = a + b;
//            a = b;
//            b = c;
//        }
//    }
//}



