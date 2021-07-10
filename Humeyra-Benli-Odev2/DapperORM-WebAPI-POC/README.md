# Dapper ORM Nedir?
ORM nedir? ilk olarak bu soruyu cevaplandýralým. ORM yani Object Relational Mapping, veritabanýný doðrudan projelerinizdeki nesnelerle eþleyen bir yapýdýr. Kodlarýnýz ile veritabaný arasýndaki bir köprü gibi düþünebiliriz. ORM kullanarak veritabanýndan verileri okuyabilir ve veriler üzerinde deðiþiklikler yapabilirsiniz. ORM ile artýk SQL sorgularý yazmamýza gerek kalmýyor ve veritabaný ile doðrudan iletiþime geçebiliyoruz.

Her programlama dilinde ORM bulunmaktadýr. Bunlara bir kaç örnek verelim.

C# için "Entity Framework Core, Dapper", Python için "Django, Storm", Java için de "Hibernate, Ebean" örneklerini verebiliriz.

Dapper Micro ORM özellikleri:
-Performans açýsýndan hýzlýdýr. En hýzlý 2. ORM'dir.
-CRUD iþlemlerini doðrudan IDBConnection nesnesini kullanarak gerçekleþtirir.
-Veritabaný üzerinden statik ve dinamik verilerin sorgulanmasýný saðlar.
-Dapper sadece tek bir "Dll"dir. Bu yüzden hýzlýdýr.
-Configuration dosyasýna ihtiyaç duymaz.
-Stackoverflow tarafýndan geliþtirilmiþ bir ORM'dir.

Bu repoda Dapper ORM kullanýlarak geliþtirilmiþ bir Web API proje örneði bulunmaktadýr.
