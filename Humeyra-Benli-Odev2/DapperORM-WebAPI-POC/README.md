# Dapper ORM Nedir?
ORM nedir? ilk olarak bu soruyu cevapland�ral�m. ORM yani Object Relational Mapping, veritaban�n� do�rudan projelerinizdeki nesnelerle e�leyen bir yap�d�r. Kodlar�n�z ile veritaban� aras�ndaki bir k�pr� gibi d���nebiliriz. ORM kullanarak veritaban�ndan verileri okuyabilir ve veriler �zerinde de�i�iklikler yapabilirsiniz. ORM ile art�k SQL sorgular� yazmam�za gerek kalm�yor ve veritaban� ile do�rudan ileti�ime ge�ebiliyoruz.

Her programlama dilinde ORM bulunmaktad�r. Bunlara bir ka� �rnek verelim.

C# i�in "Entity Framework Core, Dapper", Python i�in "Django, Storm", Java i�in de "Hibernate, Ebean" �rneklerini verebiliriz.

Dapper Micro ORM �zellikleri:
-Performans a��s�ndan h�zl�d�r. En h�zl� 2. ORM'dir.
-CRUD i�lemlerini do�rudan IDBConnection nesnesini kullanarak ger�ekle�tirir.
-Veritaban� �zerinden statik ve dinamik verilerin sorgulanmas�n� sa�lar.
-Dapper sadece tek bir "Dll"dir. Bu y�zden h�zl�d�r.
-Configuration dosyas�na ihtiya� duymaz.
-Stackoverflow taraf�ndan geli�tirilmi� bir ORM'dir.

Bu repoda Dapper ORM kullan�larak geli�tirilmi� bir Web API proje �rne�i bulunmaktad�r.
