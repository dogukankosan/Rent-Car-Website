# 🚗 Rent Car Website

![Proje Durumu](https://img.shields.io/badge/status-active-brightgreen?style=flat-square)
![Platform](https://img.shields.io/badge/platform-ASP.NET-blueviolet?style=flat-square)
![Lisans](https://img.shields.io/badge/license-MIT-yellow?style=flat-square)

![Rent Car Website Ekran Görüntüsü](https://github.com/user-attachments/assets/09f28c0b-0a83-4bfe-a5a9-cf710001e264)

## 📋 İçindekiler
- [Tanıtım](#tanıtım)
- [Özellikler](#özellikler)
- [Teknik Altyapı](#teknik-altyapı)
- [Kurulum](#kurulum)
- [Klasör Yapısı](#klasör-yapısı)
- [Ekran Görüntüleri](#ekran-görüntüleri)
- [Katkı](#katkı)
- [Lisans](#lisans)
- [İletişim](#iletişim)

---

## Tanıtım

**Rent Car Website**, araç kiralama sürecini dijitalleştirerek kullanıcıların kolayca araç seçip rezervasyon yapabilmesini sağlayan modern ve kullanıcı dostu bir web uygulamasıdır. ASP.NET MVC mimarisiyle geliştirilmiştir.

---

## Özellikler

| Kullanıcı | Yönetici |
| --------- | -------- |
| 🚙 Araçları listeleme ve filtreleme | 🚗 Araç ekleme/düzenleme/silme |
| 📅 Rezervasyon oluşturma | 📊 Raporlama & istatistikler |
| 👨‍💼 Kayıt ve giriş işlemleri | 👥 Kullanıcı yönetimi |
| 📝 Otomatik sözleşme PDF'i | 🔒 Yetkilendirme & doğrulama |
| 🌐 Duyarlı ve modern arayüz | ⚙️ Sistem ayarları |

---

## Teknik Altyapı

- **Backend:**  
  - ASP.NET MVC 5 (C#) ile çok katmanlı (Controller/Model/View) yapı.
  - SQL Server ile entegre, Entity Framework kullanımı (veya doğrudan ADO.NET).
  - Tüm CRUD işlemleri controller'lar üzerinden yönetilir.
  - Rezervasyonlar, kullanıcılar ve araçlar için ayrı modeller.
  - Yetkilendirme ve oturum yönetimi (Forms Authentication veya Identity ile).

- **Frontend:**  
  - Razor View Engine ile dinamik HTML sayfalar.
  - Admin paneli için AdminLTE tema (responsive ve modern arayüz).
  - Statik dosyalar (CSS, JavaScript) Content ve Scripts klasörlerinde.
  - Kullanıcı dostu formlar, filtreleme ve validasyonlar.

- **Ekstra:**  
  - PDF sözleşme otomatik oluşturma ve indirme.
  - Model doğrulamaları için özel Validation katmanı.
  - Detaylı hata ve bildirim yönetimi.
  - Kapsamlı raporlama ve istatistik sayfaları.

---

## Kurulum

1. **Projeyi Klonlayın**
   ```sh
   git clone https://github.com/dogukankosan/Rent-Car-Website.git
   ```
2. **Gerekli NuGet Paketlerini Yükleyin**
   - Visual Studio'da **Tools > NuGet Package Manager > Restore Packages** adımlarını izleyin.
3. **Veritabanı Bağlantısı**
   - `Web.config` dosyasında kendi SQL bağlantınızı girin.
4. **Projeyi Çalıştırın**
   - Visual Studio ile açıp F5'e basmanız yeterli.

---

## Klasör Yapısı

```text
├── Controllers      # İş mantığı ve yönlendirmeler
├── Models           # Veritabanı modelleri
├── Views            # Arayüz (HTML/CSS/Razor)
├── Content          # Statik dosyalar (CSS, görsel vs.)
├── Scripts          # JavaScript dosyaları
├── Validation       # Doğrulama kuralları
├── AdminLTE-3.0.4   # Admin panel şablonu
└── Sozlesme.pdf     # Kiralama sözleşmesi örneği
```

---

## Katkı

Katkıda bulunmak isterseniz lütfen fork'layıp pull request gönderin ya da bir [issue](https://github.com/dogukankosan/Rent-Car-Website/issues) açın.

---

## Lisans

Bu proje [MIT Lisansı](LICENSE) ile sunulmaktadır.

---

## İletişim

Her türlü öneri ve sorularınız için bana ulaşabilirsiniz:  
[GitHub Profilim](https://github.com/dogukankosan)
