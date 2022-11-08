# Flappy-Bird
  PROJE TANITIMI
  
  Flappy Bird projesi mobil platform için iki boyutlu bir oyun projesidir. Oyunun genel amacı; her ekrana tıklandığında (tap) ekranın ortasındaki kuşu zıplatarak, kuşun önüne gelen engellere (blok) dokunmadan ilerleyebilmesini sağlamaktır. Her geçilen engelde puan (score) artırılır ve ekrana anlık olarak yansıtılır. Kuş herhangi bir engel veya zemine dokunduğunda ise oyun sonlandırılır.
  
  GELİŞTİRME ORTAMI VE KULLANILAN TEKNOLOJİLER
  
  Flappy Bird projesi Unity oyun motoru kullanılarak geliştirilmiştir. Kuşun zıplaması, butonların aktive edilmesi, skor sayacı gibi oyun özellikleri için ise kodlama kısmında C# yazılım dili kullanılmıştır.
  
  TASARIM
  
  Kullanım sırasında kullanıcının karşılaşacağı ekranlar sırasıyla başlangıç ekranı, oyun ekranı ve bitiş ekranıdır.
 Başlangıç Ekranı: Uygulama başlatıldığında kullanıcıyı karşılayan ana ekrandır. Başlangıç ekranı; play tuşu, skor tuşu, oyun oynanışı animasyonuna ilaveten oyunun logosunun bulunduğu alanı içerir. Başlangıç ekranının grafiksel kullanıcı arayüzü şu şekildedir:
 
![image](https://user-images.githubusercontent.com/74682394/200566146-233916e1-cdf6-4a40-aaf7-28946111bae8.png)
![image](https://user-images.githubusercontent.com/74682394/200566239-46f0c6c7-2a4f-4f1d-b332-48fa7bcae14c.png)

Başlangıç ekranı bileşenlerinin kullanım senaryoları:
-Play tuşuna basıldığında başlangıç ekranı kapanır ve oyun ekranı başlatılır.
-Skor tuşuna basıldığında o ana kadar yapılmış en iyi 10 skor ekrana gelir.
