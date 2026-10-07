<div align="center">

# Öğrenci Bilgi Sistemi

**Öğrenci ve bölüm yönetimi**

![C#](https://img.shields.io/badge/C%23-2563eb?style=flat-square)
![ASP.NET Core MVC](https://img.shields.io/badge/ASP.NET%20Core%20MVC-0891b2?style=flat-square)
![EF Core](https://img.shields.io/badge/EF%20Core-7c3aed?style=flat-square)
[![MIT License](https://img.shields.io/badge/License-MIT-16a34a?style=flat-square)](LICENSE)

Öğrenci kayıtları ve akademik bölümler arasındaki ilişkileri Entity Framework Core ile yöneten web uygulaması.

</div>

---

## Öne Çıkanlar

- Öğrenci ekleme, düzenleme ve listeleme
- Bölüm atama ve not ortalaması takibi
- SQL Server bağlantısı ve migration yönetimi

## Teknolojiler

C# · ASP.NET Core MVC · EF Core

<details>
<summary><strong>Kurulum, kullanım ve teknik ayrıntılar</strong></summary>

Bu proje, ASP.NET Core MVC mimarisi kullanılarak geliştirilmiş, öğrenci ve akademik bölüm yönetimini sağlayan modern bir web uygulamasıdır. MVC yapısı, Entity Framework Core ve katmanlı mimari prensipleri ile birleştirilerek sürdürülebilir ve ölçeklenebilir bir sistem tasarlanmıştır.

---

 Projenin Amacı
---

Bu projenin temel amacı, ASP.NET Core MVC mimarisini kullanarak gerçek dünya senaryolarına uygun bir öğrenci otomasyon sistemi geliştirmektir.

Bu kapsamda:

- Dinamik Entegrasyon: Veritabanı verilerinin anlık olarak arayüze yansıtılması  
- Clean Code: Temiz, okunabilir ve sürdürülebilir kod yapısı oluşturulması  
- MVC Uyumu: Backend ve frontend bileşenlerinin uyumlu çalışması  
- Veri Yönetimi: Öğrenci, bölüm ve akademik bilgilerin merkezi yönetimi  

---

 Temel Özellikler
---

## Öğrenci Yönetimi

- CRUD İşlemleri: Öğrenci ekleme, listeleme, güncelleme ve silme  
- Akademik Takip: Öğrenci not ortalaması (GPA) yönetimi  
- Bölüm Atama: Öğrencilerin bölümlerle ilişkilendirilmesi  

---

## Bölüm Yönetimi
---

- Bölüm Ekleme: Yeni akademik bölümlerin sisteme dahil edilmesi  
- Görsel Yönetim: Bölüm görsellerinin tanımlanması ve gösterimi  
- İlişkisel Yapı: Bölüm-öğrenci ilişkilerinin otomatik yönetimi  

---

 Teknik Detaylar
---

| Özellik | Açıklama |
|----------|----------|
| Dil | C# |
| Framework | ASP.NET Core MVC |
| Mimari | MVC (Model-View-Controller) |
| Veritabanı | Microsoft SQL Server (EF Core) |
| Frontend | Razor Pages, Bootstrap 5 |
| Paradigma | Nesne Yönelimli Programlama (OOP) |

---

 Implementasyon Detayları
---

Proje, Entity Framework Core kullanılarak geliştirilmiş olup veritabanı işlemleri `AppDbContext` üzerinden yönetilmektedir. Migration yapısı ile veritabanı sürüm kontrolü sağlanmaktadır.

### Örnek Model: Department

```csharp
public class Department
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Image { get; set; }

    // Bir bölümün birden fazla öğrencisi olabilir
    public ICollection<Student> Students { get; set; }
}
```

---

Uygulama, `StudentController` ve `DepartmentController` üzerinden gelen istekleri işleyerek Razor View yapısı ile kullanıcıya dinamik içerik sunmaktadır.

---

## Kurulum ve Çalıştırma

1.   **Projeyi İndirin**: Projeyi indirin ve bir klasöre çıkarın.
2.   **Çözümü Açın**: `OgrenciBS.sln` dosyasını Visual Studio ile açın.
3.   **Veritabanı Yapılandırması**: `appsettings.json` dosyası içindeki SQL Server bağlantı dizesini (Connection String) kendi sunucunuza göre düzenleyin.
4.   **Migration Uygulayın**: Package Manager Console üzerinden `Update-Database` komutunu çalıştırarak veritabanını oluşturun.
5.   **Projeyi Başlatın**: Projeyi **F5** tuşu ile derleyip başlatın.

---

## Proje Yapısı

Proje, katmanlı mimari prensiplerine uygun olarak şu şekilde yapılandırılmıştır:

```text
OgrenciSistemi-master/
├── OgrenciBS/
│   ├── Controllers/   # MVC Controller katmanı
│   ├── Data/          # DbContext ve veritabanı işlemleri
│   ├── Migrations/    # EF Core migration dosyaları
│   ├── Models/        # Veri modelleri (Student, Department)
│   ├── Views/         # Razor UI sayfaları
│   └── wwwroot/       # Statik dosyalar (CSS, JS, Resimler)
└── OgrenciSistemi.sln # Visual Studio Solution dosyası
```

---


</details>

---

<div align="center">

**© 2025 Şilan PEHLİVAN**

Bu proje MIT lisansı kapsamında sunulmaktadır. Kullanım ve dağıtım koşulları: [LICENSE](LICENSE).

</div>
