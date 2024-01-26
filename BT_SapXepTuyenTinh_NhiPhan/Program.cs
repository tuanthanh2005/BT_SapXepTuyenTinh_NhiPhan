using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_SapXepTuyenTinh_NhiPhan
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int[] a = new int[100];
            int n;
            Console.Write("nhap so phan tử của mảng ");
            n = int.Parse(Console.ReadLine());
            random(a, n);
            Console.WriteLine("So Duoc Cap ramDom là: "  );
            Xuat(a, n);
            Console.WriteLine("sap tang");
            InterChangeSort(a, n);
            Console.WriteLine("kq sau khi sap tang");
            Xuat(a, n);
            Console.Write("\nNhap Gia tri X Can Tim");
            int x = int.Parse(Console.ReadLine());
            // tim tuyến tính hay tim nhi phan thi thay vào kq=?
            int kq = TimTuyenTinh(a, n, x);
            if (kq==-1)// ko có kq
   
                Console.Write($"{x} Khong Coa Xuat Hien trong ramdom");
       
            else
    
                Console.Write($"{x} Co Xuat Hien Va Nam Ơ vị trí {kq}");
     
            Console.ReadLine();
           }
        static void random(int[] a, int n)
        {
         
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                a[i] = r.Next(5);
            }
        }
        static void Xuat(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{a[i]} ");
            }
        }
        // kết quả là xet từ 0-1-2-3-4-5 tim 1 là ở vị 1
        // !! đặc biệt 0-1-1-2-3-4 tìm 1 là vẫn ở vị trí 1 
        static int TimTuyenTinh(int[] a, int n, int x)
        {
            int i = 0;
            while (i < n && a[i] != x)
            {
                i++;
            }
            if (i == n)

                return -1; // khong tim tháy

            else
                return i; // tim thaasy keets qua

        }
        // được sắp xếp tăng hoặc giảm
        // chia thành 2 phần trái và phải 
        // đặt mid ở giữa
        // vẫn lấy ở vị trí như tuyến tính 
        // đặc biệt : 0-1-2-3-3-3-4-5-1 ( thì sẽ lấy số 3 ở giữa )( hoặc nếu có 2 số 3 thì lấy sổ 3 cuối )

        static int TimNhiPhan(int[] a, int n, int x)
        {
            int left, right, mid;
            left = 0;
            right = n - 1;
            while (left <= right)
            {


                mid = (left + right) / 2;

                if (a[mid] == x)
                {
                    return mid;
                }
                else if (a[mid] > x)
                    right = mid - 1;
                else
                    left = mid + 1;
                      
            }
            return -1;
        }
        static  void InterChangeSort(int[] a, int n)
        {
            int sap;
            for (int i = 0; i < n; i++)
           for(int j = i + 1; j < n; j++)
                {
                    if (a[i] > a[j])
                    {


                        sap = a[i];
                        a[i] = a[j];
                        a[j] = sap;
                    }
                }
        }
    }
}
