## MVC 5 İLE DİNAMİK ADMİN PANELLİ CV SİTESİ PROJESİ 

Merhabalar, hakkımdaki bilgileri, eğitim bilgilerini, deneyim, hobi, yeteneklerim, sertifikalarım, yazılım projelerim, sosyal medya hesaplarım, iletişim bilgilerim gibi özgeçmişime ait bilgileri ve UI - Admin Panelleri arasındaki ilişkileri takip edebileceğimiz bu projede;

- Admin tarafında Yeni veriler ekleme, silme ve güncelleme (CRUD İşlemleri) yapabildiğiniz gibi aynı zamanda var olan verileri aktif veya pasif olma durumlarına göre UI tarafında görüntülenmesine karar verebilirsiniz.
- Admin panelindeki yeteneklerim listesinde koşullu renklendirme işlemi
- Admin panelinde Modal Popup üzerinden ekleme işlemleri
- UI tarafındaki İletişim Sayfasından Admin'e mesaj yollayabilme
- Model-View-Controller katmanları içeren
- HttpGet ve HttpPost Attributelarının Controller tarafında kullanımları ve ne işlevde olduklarına dair bilgiler,
- Validation Kontrolleri Required
- Code First -ORM aracı olarak Entity Framework -Veri tabanı SQL Server 
- Authorize
- SessionTimeOut Attribute
  gibi bir çok teknoloji kullanılmıştır.
-------------------------------------------------------------------------------------

| Login Sayfası Genel Görünüm |
|-----------------|
![LOGİN](https://github.com/esincaglakiral/MVC5-DynamicCV-Project/assets/68962573/b7e0ca99-cb2a-4d86-b426-83736a10cf1f)
-------------------------------------------------------------------------------------

| UI Tarafı Sayfa Genel Görünüm |
|-----------------|
![U1](https://github.com/esincaglakiral/MVC5-DynamicCV-Project/assets/68962573/a3f76b80-eab3-44d2-b8ec-e03da09ce7f4)
![UI2](https://github.com/esincaglakiral/MVC5-DynamicCV-Project/assets/68962573/0216e79c-de86-4158-8e5e-18fe2322fc25)
![UI3](https://github.com/esincaglakiral/MVC5-DynamicCV-Project/assets/68962573/9ec5533f-22c4-477a-ab51-dc3cd19ff87a)
![UI4](https://github.com/esincaglakiral/MVC5-DynamicCV-Project/assets/68962573/53595f3a-93f6-492d-862d-5239d681068f)
![UI5](https://github.com/esincaglakiral/MVC5-DynamicCV-Project/assets/68962573/c688f3b8-63bf-447e-bc13-0fe802387053)
![UI6](https://github.com/esincaglakiral/MVC5-DynamicCV-Project/assets/68962573/efe59819-cd02-48df-ae4d-9c2323f91069)
![UI7](https://github.com/esincaglakiral/MVC5-DynamicCV-Project/assets/68962573/d11533de-8dab-495b-bdf1-0aca5306dee2)
![UI8](https://github.com/esincaglakiral/MVC5-DynamicCV-Project/assets/68962573/4f68f9a7-2f19-423d-bea2-bd440b67f4d3)
-------------------------------------------------------------------------------------

| Admin Panelindeki İşlemler |
|-----------------|
-------------------------------------------------------------------------------------

| Hakkımda Panelindeki İşlemler |
|-----------------|
hakkımda paneli
![hakkımdapanel](https://github.com/esincaglakiral/MVC5-DynamicCV-Project/assets/68962573/3bf1e41c-847c-45ed-ab2f-ab16e1ac6c9c)
hakkımda ekleme sayfası
![hakkımdaeklemesayfası](https://github.com/esincaglakiral/MVC5-DynamicCV-Project/assets/68962573/267fe349-5b13-48d8-8655-f0f28bff23f7) 
(hakkımda eklemesayfası validasyon kontrolu)
![hakkımdaeklemesayfasıvalidasyonkontrolu](https://github.com/esincaglakiral/MVC5-DynamicCV-Project/assets/68962573/16097cf2-cd72-45c8-807e-fbe2ae2b9a6f) 
 yeni hakkımda eklendi
![yenihakkımdaeklendi](https://github.com/esincaglakiral/MVC5-DynamicCV-Project/assets/68962573/27326711-1351-4927-a052-1625e44bf251)
yeni eklenen kişiyi aktif yaptım
![yenieklenenkişiyiaktifyaptım](https://github.com/esincaglakiral/MVC5-DynamicCV-Project/assets/68962573/7f9bf2eb-d572-40ef-8ae3-cf8dbf0beddb) 
siteye de aktif olan hakkımda yansıdı
![siteyedeaktifolanhakkımdayansıdı](https://github.com/esincaglakiral/MVC5-DynamicCV-Project/assets/68962573/9de1ab0c-e54c-49ce-97cc-df746569c08a) 
hakkımda güncelleme sayfası
![hakkımdagüncellemesayfası](https://github.com/esincaglakiral/MVC5-DynamicCV-Project/assets/68962573/23f64cac-91b2-42cd-9ac9-2c298578c6cd) 
hakkımda değişiklikler
![hakkımdadeğişiklikler](https://github.com/esincaglakiral/MVC5-DynamicCV-Project/assets/68962573/e06b41e9-bebb-4a45-9714-89f2453a414b) 
 hakkımda degişiklikler yapıldı
![hakkımdadegişiklikleryapıldı](https://github.com/esincaglakiral/MVC5-DynamicCV-Project/assets/68962573/4ab3ad29-0dde-4fe8-b1e7-764f402559e5)

-------------------------------------------------------------------------------------

| Admin Panelindeki Diğer Sayfalar ve İşlemler |
|-----------------|
egitimlerim sayfası
![egitimlerimsayfası](https://github.com/esincaglakiral/MVC5-DynamicCV-Project/assets/68962573/912869dd-1f03-4e73-befa-ce6d2882e77d) 
deneyimlerim sayfası
![deneyimlerimsayfası](https://github.com/esincaglakiral/MVC5-DynamicCV-Project/assets/68962573/85e7d373-a5e0-48b8-ba5f-b551aaac087b)
hobi sayfası
![hobisayfası](https://github.com/esincaglakiral/MVC5-DynamicCV-Project/assets/68962573/840f1990-94e8-44ec-92a3-fec3c4458905) 
ayarlar
![ayarlar](https://github.com/esincaglakiral/MVC5-DynamicCV-Project/assets/68962573/98c89b4c-a14f-4446-b723-22543f9d206a) 
-------------------------------------------------------------------------------------
yeteneklerim sayfası
![yeteneklerimsayfası](https://github.com/esincaglakiral/MVC5-DynamicCV-Project/assets/68962573/d765c136-b5d1-488b-bee6-d0763c23baae) 
 koşullu renklendirme
![koşullurenklendirme](https://github.com/esincaglakiral/MVC5-DynamicCV-Project/assets/68962573/8c3235d3-30ec-4011-b644-cc8f896563d5)
yetenek ekleme
![yetenekekleme](https://github.com/esincaglakiral/MVC5-DynamicCV-Project/assets/68962573/f79160fe-d4f3-4820-8250-901cb569134f) 
yetenek ekleme2
![yetenekekleme2](https://github.com/esincaglakiral/MVC5-DynamicCV-Project/assets/68962573/855a44fe-ae39-48ce-93d7-142cc5d471dd) 
yeni yetenek eklendi
![yeniyetenekeklendi](https://github.com/esincaglakiral/MVC5-DynamicCV-Project/assets/68962573/911eaafe-7ead-4a2d-b3cd-e7a1e52ed9d0) 
yeni eklenen yetenek sayfaya yansıdı
![yenieklenenyeteneksayfayayansıdı](https://github.com/esincaglakiral/MVC5-DynamicCV-Project/assets/68962573/f6b02536-a39d-456e-a242-b3cdb733bc3f) 

-------------------------------------------------------------------------------------
sertifika paneli
![sertifikapaneli](https://github.com/esincaglakiral/MVC5-DynamicCV-Project/assets/68962573/ba57548b-6782-49ca-8fc0-63d0ec9d2d40) 
sertifika ekleme
![sertifikaekleme](https://github.com/esincaglakiral/MVC5-DynamicCV-Project/assets/68962573/702899f7-d7f7-435e-a9a7-bef002ca9118) 
yeni sertifika eklendi
![yenisertifikaeklendi](https://github.com/esincaglakiral/MVC5-DynamicCV-Project/assets/68962573/624f3ed9-778f-4ed0-947e-22d35948819a) 
sertifika güncelleme
![sertifikagüncelleme](https://github.com/esincaglakiral/MVC5-DynamicCV-Project/assets/68962573/e88b6717-801f-4402-9c35-3865086ea729) 

-------------------------------------------------------------------------------------
projeler paneli
![projelerpaneli](https://github.com/esincaglakiral/MVC5-DynamicCV-Project/assets/68962573/948817c6-992b-4069-b8b4-769121636211) 
yeni proje ekleme
![yeniprojeekleme](https://github.com/esincaglakiral/MVC5-DynamicCV-Project/assets/68962573/484dc222-d05b-4ecf-9dc9-1ee6e3ba9c65) 
 yeni proje ekleme2
![yeniprojeekleme2](https://github.com/esincaglakiral/MVC5-DynamicCV-Project/assets/68962573/b0ff5984-c1f9-4615-b04b-8398b226fbcb)
 proje eklendi
![projeeklendi](https://github.com/esincaglakiral/MVC5-DynamicCV-Project/assets/68962573/3853dcdf-30c4-4510-9440-d6eceb955df1)
proje linkine tıkla
![projelinkinetıkla](https://github.com/esincaglakiral/MVC5-DynamicCV-Project/assets/68962573/806aebe5-3ea1-49c6-a1e5-232a7650b8aa) 
 yeni eklenen proje uı tarafına yansıdı
![yenieklenenprojeuıtarafınayansıdı](https://github.com/esincaglakiral/MVC5-DynamicCV-Project/assets/68962573/f2953533-93c9-4bdd-af8d-3c4ff04ec6a7)

-------------------------------------------------------------------------------------
Sosyal Medya
![SosyalMesya](https://github.com/esincaglakiral/MVC5-DynamicCV-Project/assets/68962573/9b7eb2c5-48f4-443f-be18-13b9d1df8ad9) 
sosyal medya ekleme
![sosyalmedyaekleme](https://github.com/esincaglakiral/MVC5-DynamicCV-Project/assets/68962573/31ccfbec-86f1-484b-8812-60eed38f553a) 
sosyal medya ekleme3
![sosyalmedyaekleme3](https://github.com/esincaglakiral/MVC5-DynamicCV-Project/assets/68962573/f17abccf-f4f7-4116-a41e-14f320b6279f) 
yeni sosyal medya eklendi
![yenisosyalmedyaeklendi](https://github.com/esincaglakiral/MVC5-DynamicCV-Project/assets/68962573/b05a06b8-a3d5-42f5-bb43-acb577ca9ce7) 
eklenen sosyal medya uı tarafına yansıdı
![eklenensosyalmedyauıtarafınayansıdı](https://github.com/esincaglakiral/MVC5-DynamicCV-Project/assets/68962573/3c155387-31b9-4e53-a436-a8de966478ef) 

-------------------------------------------------------------------------------------
admine mesaj gönderme
![adminemesajgönderme](https://github.com/esincaglakiral/MVC5-DynamicCV-Project/assets/68962573/78f0743a-b8f2-480b-89f4-529170d528e3) 
 mesaj gönderildi
![mesajgönderildi](https://github.com/esincaglakiral/MVC5-DynamicCV-Project/assets/68962573/f4287adf-28d5-4af6-80ea-3f89ad5ea166)

















