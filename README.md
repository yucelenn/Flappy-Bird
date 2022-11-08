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

![hs](https://user-images.githubusercontent.com/74682394/200570588-395d9cfd-1344-4ead-8847-4bf69f027d43.png)
![cc](https://user-images.githubusercontent.com/74682394/200570618-e747dd8e-25f6-413a-92c3-60422a1d5b22.png)
![cc2](https://user-images.githubusercontent.com/74682394/200570656-c71641d5-4f09-4e47-ad40-ffdd3a05186d.png)


Başlangıç ekranı bileşenlerinin kullanım senaryoları:
-Play tuşuna basıldığında başlangıç ekranı kapanır ve oyun ekranı başlatılır.
-Skor tuşuna basıldığında o ana kadar yapılmış en iyi 10 skor ekrana gelir.

Oyun Ekranı: Uygulama amacının gerçekleştirildiği yani kullanıcının oyunu deneyimlediği ekrandır. Kullanıcı, üzerine gelen bloklara temas etmeden ilerleyebilmek için ekrana tıklayarak kuşu kontrol eder ve kullanıcının geçtiği blok sayısı ekrana basılır. Kuşun bloklara veya zemine temas etmesi haline bitiş ekranı açılır. Oyun ekranının grafiksel kullanıcı arayüzü şu şekildedir:

![image](https://user-images.githubusercontent.com/74682394/200567333-52b0d159-8728-4ac2-af6e-058efe1f1bdd.png)
![image](https://user-images.githubusercontent.com/74682394/200567368-4d9c4235-2f67-420a-8b52-9b3266c072f7.png)

Bitiş Ekranı: Oyun esnasında kuşun bloklara-zemine teması halinde yani oyun sonlandığı zaman ortaya çıkan ekrandır. Bu ekranda skor alanları, “Game Over” simgesi, replay tuşu ve çıkış tuşu bulunur. Bitiş ekranının grafiksel kullanıcı arayüzü şu şekildedir:
![son](https://user-images.githubusercontent.com/74682394/200570020-f3d18b58-b85e-47fa-b700-b1cce0595297.png)

Bitiş ekranı bileşenlerinin kullanım senaryoları:
-Skor alanındaki “Score” bölümü en son elde edilen skoru belirtir.
-Skor alanındaki “Best” bölümü o ana kadarki elde edilen en yüksek skoru belirtir.
-Retry tuşuna basıldığında oyun ekranı tekrar başlatılır.
-Quit tuşuna basıldığında uygulama kapatılır.



