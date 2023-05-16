# ISPARTA ÝHALE WEB SAYFASI
Sitenin 3 tane paneli vardýr . Süper admin paneli, admin paneli , ve normal kullanýcýlar.
## KULLANICI PANELÝ:
### YAYINLANAN ÝHALELER:
- Yayýnda olan ilanlarýn listeleneceði paneldir. Tablo alanlarý:
#### IhaleKayitNo
#### Alim Usulu
#### Alim Türü
#### Birimi
#### Ýlan adý
#### BitisTarihi
#### BaslangicTarihi
#### Ýndir (bu alandan ihale indirilebilmektedir)
## SÜPER ADMÝN PANELÝ:
### GÝRÝÞ EKRANI: 
#### Kullanýcý Adý (text box)
#### Þifre   (text box password)
#### Beni hatýrla (checkbox)
#### giriþ (button)
### ADMÝN ÝÞLEMLERÝ: 
#### ÝLAN EKLEME:
- Yeni ilanlarýn ekleneceði ve raporunun alýnacaðý paneldir. Yeni ilan eklemek için:
##### Ýstem No / Ýhale No	(text box)
##### Ýlan Adý 			(text box)
##### Birimi 			(list box)
##### Alým Usulü		(list box)
##### Alým türü			(list box)
##### Detay 			(file)
##### Ýlan Baþlangiç Tarihi 	(date time)
##### Ýlan Bitiþ Tarihi		(date time)
##### Ýlan Baþlangiç Saati	(time)
##### Ýlan Bitiþ Saati		(time) alanlarý bulunuyor.Hatalý veya eksik bir deðer girilirse alert ile uyarýyor
#### ÝLAN SÜRESÝ BÝTMÝÞ YAYINLAR:
- Bu alanda ilan süresi bitmiþ yayýnlarýn bir tablosu bulunuyor. Tablo alanlarý:
##### IhaleKayitNo
##### IlanAdi
##### BitisTarihi
##### BaslangicTarihi
##### BirimId  (ama içeriði birim adý)
##### Dosya
##### Ek
#### KALDIRILMIÞ YAYINLAR:
- Bu alanda kaldýrýlmýþ yayýnlar bulunuyor . Tablo alanlarý:
##### ÝhaleKayitNo
##### Ýlan Adý
##### Bitis Tarihi
##### Baslangic Tarihi
##### Birimi
##### Durum (Ýlaný tekrardan yayýna sokabiliriz)
#### TÜM YAYINLAR:
- Bu alanda tüm yayýnlar bulunuyor . Tablo alanlarý:
##### IhaleKayitNo
##### IlanAdi
##### BitisTarihi
##### BaslangicTarihi
##### AlimTuruId (sadece id yi gösteriyor)
##### Birimi
##### Durum (Silinmis, Kaldirilmis, Arsiv)
##### Arþiv (bu kýsýmdan yayýnlarý arþive ekleyebiliyoruz)
#### ARÞÝV:
- Bu alanda arþive eklenen yayýnlar bulunuyor . Tablo alanlarý:
##### IhaleKayitNo
##### IlanAdi
##### BitisTarihi
##### BaslangicTarihi
##### AlimTuruId (sadece id yi gösteriyor)
##### Birim Adý
##### Arsiv Eklenme Tarihi
### KULLANICI PROFÝL SAYFASI:
- Kullancýlarýn kendi bilgilerini görebileceði sayfadýr. Sayfa alanlarý:
#### Kullanýcýnýn profil resmi
#### Kullanýcý Adý
#### Birim
#### Kayýt Tarihi
#### Email
#### Son Giriþ Tarihi
#### Durum (aktif,pasif)
### AYARLAR:
Ýçeriði kullanýcý profil sayfasý ile ayný
### YAYINDAKÝ ÝLANLAR:
- Tablo alanlarý
#### IhaleKayitNo
#### IlanAdi
#### BitisTarihi
#### BaslangicTarihi
#### BirimId
#### Güncelle
#### Sil
### PARAMETRELER
#### BÝRÝM EKLE SÝL:
-Yeni birimin ekleneceði ve silineceði bölümdür
##### Birim Adý (text box)
#### ALIM USULU EKLE SÝL:
- Yeni alým usulunun ekleneceði ve silineceði alandýr
##### Alým Usul Adý (text box)
#### ALIM TÜRÜ EKLE SÝL:
- Yeni alým türünün ekleneceði ve silineceði alandýr
### ÞÝFRE DEÐÝÞTÝRME
#### E-mail 
#### Eski Sifre 
#### Yeni Sifre 
#### Yeni Sifre Tekrari 
#### Güncelle
### KULLANICI AYARLARI
#### KULLANÝCÝ GÜNCELLE:
- Kullanýcýnýn kendi bilgilerini güncelleyeceði alandýr
##### Kullanýcý Adý  (text box)
##### Adý  (text box)
##### Soyadý  (text box)
##### Eposta  (text box)
#### KULLANÝCÝ YETKÝLENDÝRME:
- Tablo alanlarý:
##### Kullanýcý adý
##### Þifre
##### Adý
##### Soyadý
##### Eposta
##### Eklenme tarihi
##### Kullanýcý Bilgisi (Admin, Süper Admin)
##### Yetkilendirme Butonu
##### Yetki Alma Butonu
##### Silme Butonu
#### KULLANÝCÝ EKLEME:
- Yeni kullanýcý ekleyebileceðimiz bölümdür
##### Email (text box)
##### Kullanýcý Adý (text box)
##### Adý (text box)
##### Soyadý (text box)
##### Þifre (text box password)
##### Birim (list box)
##### Yetki (list box ->[admin,süperadmin]) 
##### Kayýt butonu

# ADMÝN PANELÝ:
## YAYINDAKÝ ÝLANLAR:
- Süper admin ile ayný ama Sadece Kendi Bölümünüzdeki Ýlanlarý Görebilirsiniz
## ADMÝN ÝÞLEMLERÝ: 
- Süper admin ile ayný
## KULLANICI AYARLARI
- Sadece kendi bilgilerimizi güncelleyeceðimiz alan bulunmakta
### KULLANÝCÝ GÜNCELLE:
-Süper admin ile ayný
## ÞÝFRE DEÐÝÞTÝRME
-Süper admin ile ayný
## GÝRÝÞ EKRANI: 
-Süper admin ile ayný
## KULLANICI PROFÝL SAYFASI:
-Süper admin ile ayný
## AYARLAR:
-Süper admin ile ayný

