# Flappy-Bird
    PROJE TANITIMI
  
  Flappy Bird projesi mobil platform için iki boyutlu bir oyun projesidir. Oyunun genel amacı; her ekrana tıklandığında (tap) ekranın ortasındaki kuşu zıplatarak, kuşun önüne gelen engellere (blok) dokunmadan ilerleyebilmesini sağlamaktır. Her geçilen engelde puan (score) artırılır ve ekrana anlık olarak yansıtılır. Kuş herhangi bir engel veya zemine dokunduğunda ise oyun sonlandırılır.
  
  GELİŞTİRME ORTAMI VE KULLANILAN TEKNOLOJİLER
  
  Flappy Bird projesi Unity oyun motoru kullanılarak geliştirilmiştir. Kuşun zıplaması, butonların aktive edilmesi, skor sayacı gibi oyun özellikleri için ise kodlama kısmında C# yazılım dili kullanılmıştır.
  
  TASARIM
  
  Kullanım sırasında kullanıcının karşılaşacağı ekranlar sırasıyla başlangıç ekranı, oyun ekranı ve bitiş ekranıdır.
  
Başlangıç Ekranı: Uygulama başlatıldığında kullanıcıyı karşılayan ana ekrandır. Başlangıç ekranı; play tuşu, scores tuşu, oyun oynanışı animasyonuna ilaveten oyunun logosunun bulunduğu alanı içerir. Başlangıç ekranının grafiksel kullanıcı arayüzü şu şekildedir:
![baş](https://user-images.githubusercontent.com/74682394/200574263-d82b6ae6-7926-4d37-a360-2506ad49da32.png)

Başlangıç ekranı bileşenlerinin kullanım senaryoları:

-Play tuşuna basıldığında başlangıç ekranı kapanır ve oyun ekranı başlatılır.

-Skor tuşuna basıldığında o ana kadar yapılmış en iyi 10 skor ekrana gelir.

Oyun Ekranı: Uygulama amacının gerçekleştirildiği yani kullanıcının oyunu deneyimlediği ekrandır. Kullanıcı, üzerine gelen bloklara temas etmeden ilerleyebilmek için ekrana tıklayarak kuşu kontrol eder ve kullanıcının geçtiği blok sayısı ekrana basılır. Kuşun bloklara veya zemine temas etmesi haline bitiş ekranı açılır. Oyun ekranının grafiksel kullanıcı arayüzü şu şekildedir:

![image](https://user-images.githubusercontent.com/74682394/200567333-52b0d159-8728-4ac2-af6e-058efe1f1bdd.png)
![image](https://user-images.githubusercontent.com/74682394/200567368-4d9c4235-2f67-420a-8b52-9b3266c072f7.png)

Bitiş Ekranı: Oyun esnasında kuşun bloklara-zemine teması halinde yani oyun sonlandığı zaman ortaya çıkan ekrandır. Bu ekranda skor alanları, “Game Over” simgesi, retry tuşu ve quit tuşu bulunur. Bitiş ekranının grafiksel kullanıcı arayüzü şu şekildedir:

![final](https://user-images.githubusercontent.com/74682394/200577279-e23e212e-7f5b-4e99-8e6c-6fb91540213e.png)


Bitiş ekranı bileşenlerinin kullanım senaryoları:

-Skor alanındaki “Score” bölümü en son elde edilen skoru belirtir.

-Skor alanındaki “Best” bölümü o ana kadarki elde edilen en yüksek skoru belirtir.

-Retry tuşuna basıldığında oyun ekranı tekrar başlatılır.

-Quit tuşuna basıldığında uygulama kapatılır.



