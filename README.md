# MergeSort
Birleştirme Sıralaması

MergeSort(arr[],s,e)

if(e>1)
  1. Dizi ikiye bölünerek orta nokta bulunur. 
      orta m=(s+e)/2
      
  2. İlk yarısı için MergeSort prosedürü çağrılır. 
      Call MergeSort(arr, s, m)
      
  3. İkinci yarısı için MergeSort prosedürü çağrılır. 
      Call MergeSort(arr, m+1, e)
      
  4. İkinci ve üçüncü adımda sıralanmışları birleştir.
      Call merge(arr, s, m, e)
      
      
Avarage Case  O(nlogn), 
Worst Case    O(nlogn), 
Best Case     O(nlogn)
  
