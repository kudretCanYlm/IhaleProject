# ISPARTA �HALE WEB SAYFASI
Sitenin 3 tane paneli vard�r . S�per admin paneli, admin paneli , ve normal kullan�c�lar.
## KULLANICI PANEL�:
### YAYINLANAN �HALELER:
- Yay�nda olan ilanlar�n listelenece�i paneldir. Tablo alanlar�:
#### IhaleKayitNo
#### Alim Usulu
#### Alim T�r�
#### Birimi
#### �lan ad�
#### BitisTarihi
#### BaslangicTarihi
#### �ndir (bu alandan ihale indirilebilmektedir)
## S�PER ADM�N PANEL�:
### G�R�� EKRANI: 
#### Kullan�c� Ad� (text box)
#### �ifre   (text box password)
#### Beni hat�rla (checkbox)
#### giri� (button)
### ADM�N ��LEMLER�: 
#### �LAN EKLEME:
- Yeni ilanlar�n eklenece�i ve raporunun al�naca�� paneldir. Yeni ilan eklemek i�in:
##### �stem No / �hale No	(text box)
##### �lan Ad� 			(text box)
##### Birimi 			(list box)
##### Al�m Usul�		(list box)
##### Al�m t�r�			(list box)
##### Detay 			(file)
##### �lan Ba�langi� Tarihi 	(date time)
##### �lan Biti� Tarihi		(date time)
##### �lan Ba�langi� Saati	(time)
##### �lan Biti� Saati		(time) alanlar� bulunuyor.Hatal� veya eksik bir de�er girilirse alert ile uyar�yor
#### �LAN S�RES� B�TM�� YAYINLAR:
- Bu alanda ilan s�resi bitmi� yay�nlar�n bir tablosu bulunuyor. Tablo alanlar�:
##### IhaleKayitNo
##### IlanAdi
##### BitisTarihi
##### BaslangicTarihi
##### BirimId  (ama i�eri�i birim ad�)
##### Dosya
##### Ek
#### KALDIRILMI� YAYINLAR:
- Bu alanda kald�r�lm�� yay�nlar bulunuyor . Tablo alanlar�:
##### �haleKayitNo
##### �lan Ad�
##### Bitis Tarihi
##### Baslangic Tarihi
##### Birimi
##### Durum (�lan� tekrardan yay�na sokabiliriz)
#### T�M YAYINLAR:
- Bu alanda t�m yay�nlar bulunuyor . Tablo alanlar�:
##### IhaleKayitNo
##### IlanAdi
##### BitisTarihi
##### BaslangicTarihi
##### AlimTuruId (sadece id yi g�steriyor)
##### Birimi
##### Durum (Silinmis, Kaldirilmis, Arsiv)
##### Ar�iv (bu k�s�mdan yay�nlar� ar�ive ekleyebiliyoruz)
#### AR��V:
- Bu alanda ar�ive eklenen yay�nlar bulunuyor . Tablo alanlar�:
##### IhaleKayitNo
##### IlanAdi
##### BitisTarihi
##### BaslangicTarihi
##### AlimTuruId (sadece id yi g�steriyor)
##### Birim Ad�
##### Arsiv Eklenme Tarihi
### KULLANICI PROF�L SAYFASI:
- Kullanc�lar�n kendi bilgilerini g�rebilece�i sayfad�r. Sayfa alanlar�:
#### Kullan�c�n�n profil resmi
#### Kullan�c� Ad�
#### Birim
#### Kay�t Tarihi
#### Email
#### Son Giri� Tarihi
#### Durum (aktif,pasif)
### AYARLAR:
��eri�i kullan�c� profil sayfas� ile ayn�
### YAYINDAK� �LANLAR:
- Tablo alanlar�
#### IhaleKayitNo
#### IlanAdi
#### BitisTarihi
#### BaslangicTarihi
#### BirimId
#### G�ncelle
#### Sil
### PARAMETRELER
#### B�R�M EKLE S�L:
-Yeni birimin eklenece�i ve silinece�i b�l�md�r
##### Birim Ad� (text box)
#### ALIM USULU EKLE S�L:
- Yeni al�m usulunun eklenece�i ve silinece�i aland�r
##### Al�m Usul Ad� (text box)
#### ALIM T�R� EKLE S�L:
- Yeni al�m t�r�n�n eklenece�i ve silinece�i aland�r
### ��FRE DE���T�RME
#### E-mail 
#### Eski Sifre 
#### Yeni Sifre 
#### Yeni Sifre Tekrari 
#### G�ncelle
### KULLANICI AYARLARI
#### KULLAN�C� G�NCELLE:
- Kullan�c�n�n kendi bilgilerini g�ncelleyece�i aland�r
##### Kullan�c� Ad�  (text box)
##### Ad�  (text box)
##### Soyad�  (text box)
##### Eposta  (text box)
#### KULLAN�C� YETK�LEND�RME:
- Tablo alanlar�:
##### Kullan�c� ad�
##### �ifre
##### Ad�
##### Soyad�
##### Eposta
##### Eklenme tarihi
##### Kullan�c� Bilgisi (Admin, S�per Admin)
##### Yetkilendirme Butonu
##### Yetki Alma Butonu
##### Silme Butonu
#### KULLAN�C� EKLEME:
- Yeni kullan�c� ekleyebilece�imiz b�l�md�r
##### Email (text box)
##### Kullan�c� Ad� (text box)
##### Ad� (text box)
##### Soyad� (text box)
##### �ifre (text box password)
##### Birim (list box)
##### Yetki (list box ->[admin,s�peradmin]) 
##### Kay�t butonu

# ADM�N PANEL�:
## YAYINDAK� �LANLAR:
- S�per admin ile ayn� ama Sadece Kendi B�l�m�n�zdeki �lanlar� G�rebilirsiniz
## ADM�N ��LEMLER�: 
- S�per admin ile ayn�
## KULLANICI AYARLARI
- Sadece kendi bilgilerimizi g�ncelleyece�imiz alan bulunmakta
### KULLAN�C� G�NCELLE:
-S�per admin ile ayn�
## ��FRE DE���T�RME
-S�per admin ile ayn�
## G�R�� EKRANI: 
-S�per admin ile ayn�
## KULLANICI PROF�L SAYFASI:
-S�per admin ile ayn�
## AYARLAR:
-S�per admin ile ayn�

