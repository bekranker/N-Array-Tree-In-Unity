# ItemHandler - Tree Yapısı Projesi

Bu proje, öğelerin hiyerarşik bir yapıda düzenlenmesini sağlayan bir sistem içerir. `ItemHandler` sınıfı, öğeler ve onların alt öğelerini bir ağaç yapısına yerleştirerek bu öğeleri yönetir. Proje, alt öğelerle ilişkili veri yapıları üzerinde çalışmak için rekürsif fonksiyonlar kullanır.

## İçindekiler

- [Proje Tanımı](#proje-tanımı)
- [Kullanım](#kullanım)
- [Dosya Yapısı](#dosya-yapısı)
- [Katkıda Bulunma](#katkıda-bulunma)
- [Lisans](#lisans)

## Proje Tanımı

Bu proje, öğeleri ve alt öğelerini yönetmek için hiyerarşik bir ağaç yapısı (`Tree` ve `TreeNode`) kullanır. Her öğe (`Item`) bir kategoriyi temsil eder (örneğin, silahlar, kalkanlar) ve bu öğeler kendi alt öğelerine (`SubItems`) sahip olabilir. Bu alt öğeler de bir ağaç yapısına eklenir. `ItemHandler` sınıfı, bu öğeleri yönetir ve ağaçları oluşturur.

### Temel Bileşenler:

1. **Item**: Kategorileri temsil eden öğeler.
2. **Tree**: Ağaç yapısını temsil eder ve her öğe için kök düğümü içerir.
3. **TreeNode**: Ağaçtaki her bir düğümün verilerini (öğeyi) ve alt öğelerini temsil eder.
4. **ItemHandler**: Öğeleri yönetir ve ağaç yapılarında organize eder.

### İşlevler:

- **CreateNArrayTree()**: Her bir öğe için bir ağaç yapısı oluşturur ve alt öğeleri ekler.
- **AddChildRecursiveFunction()**: Alt öğeleri ağaç yapısına ekler (rekürsif).
- **PrintTreeButtonFunction()**: Ağaç yapısını debug için yazdırır.

## Kullanım

Bu projeyi kullanmak için aşağıdaki adımları takip edebilirsiniz:

1. **Proje dosyasını indirin**: GitHub deposunu klonlayın veya zip olarak indirin.

   ```bash
   git clone https://github.com/username/ItemHandler.git
   ```

##**NOTE**
