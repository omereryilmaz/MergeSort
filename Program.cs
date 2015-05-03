using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSortAA
{
    
    class MergeSort
    {
        int n = 0;
        
        // Iki sirali diziyi birlestiren prosedur
        // Her iki dizininde tek bir dizinin parcasi oldugunu unutmayalim. arr1[start.....mid] and arr2[mid+1 ... end]
        void mergeArray(int[] arr, int start, int mid, int end)
        {
            // Birlestirilen dizileri gecici olarak tutmak icin bos bir dizi olusturuyoruz
            // Bu dizinin boyutu birlesitirilecek dizilerin toplam boyutu kadar olacak
            int[] temp = new int[end - start + 1];

            int i = start, j = mid + 1, k = 0;
            //Simdi  hem dizi traverse ediyoruz hem de en kücük elemani gecici diziye atiyoruz
            
            while (i <= mid && j <= end)
            {
                Console.WriteLine(i + ". eleman : " + arr[i]);
                Console.WriteLine(j + ". eleman : " +arr[j] + " karsilastir..");
                Console.WriteLine("___________________________");
               
                if (arr[i] < arr[j])
                {
                    Console.WriteLine( i + ". eleman " + j +". elemandan kucuk -- > temp[" +k+"] = arr["+i+"]" );
                    Console.WriteLine("___________________________");
                    temp[k] = arr[i];
                    k++;
                    i++;
                }
                else
                {
                    Console.WriteLine(i + ". eleman " + j + ". elemandan buyuk veya esit  -- > temp[" + k + "] = arr[" + j+ "]");
                    Console.WriteLine("___________________________");
                    temp[k] = arr[j];
                    k++;
                    j++;
                }
            }

            // Ilk dizide hic eleman kalmazsa onu temp dizisine ekle
            while (i <= mid)
            {
                Console.WriteLine("Ilk dizide eleman kalmadi..");
                Console.WriteLine( "temp[" + k + "] = arr[" + i+ "]");
                Console.WriteLine("___________________________");

                temp[k] = arr[i];
                k++;
                i++;
            }

            //Ikınci dizide hic eleman kalmamissa onu temp dizisine ekle
            while (j <= end)
            {
                Console.WriteLine("IKinci dizide eleman kalmadi..");
                Console.WriteLine("temp[" + k + "] = arr[" + j + "]");
                Console.WriteLine("___________________________");
                temp[k] = arr[j];
                k++;
                j++;
            }
            // Simdi temp dizisi hem birlestirildi hem siralandi

            // temp dizisini tasiyoruz(traverse); temp dizisindeki elemanlari orijinal diziye atiyoruz.
            k = 0;
            i = start;
            while (k < temp.Length && i <= end)
            {
                Console.WriteLine("*_*_*_*_*_*_*_*_*_*_*_*_*_*_*");
                Console.WriteLine("temp dizisi orjinal arr dizisine aktariliyor..");
                Console.WriteLine("arr["+i+ "] = temp["+k+"]");
                arr[i] = temp[k];
                i++;
                k++;
            }
        }


        // Recursive Merge Procedure
        internal void mergesort(int[] arr, int start, int end)
        {
            if (start < end)
            {
                int mid = (end + start) / 2;
                n++;
                Console.WriteLine("*********************");
                Console.WriteLine(n + " : Dizi ikiye bolundu..");
                Console.WriteLine("*********************");
      
                mergesort(arr, start, mid);
                mergesort(arr, mid + 1, end);
                mergeArray(arr, start, mid, end);
            }
        }
    }
    class Program
    {
       
        static void Main(string[] args)
        {
            int[] arr = { 4, 7, 3, 1, 9, 10, 15, 19, 8, 12 }; // siralanacak dizimiz

            MergeSort merge = new MergeSort();

            // mergesort proseduru cagriliyor
            merge.mergesort(arr, 0, arr.Length - 1);

            // siralanmis dizi yazdiriliyor
            foreach (int a in arr)
            {
                Console.Write(a + " ");
            }
            Console.ReadKey();
        }
    }
}
