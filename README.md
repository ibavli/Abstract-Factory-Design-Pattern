## Abstract Factory Design Pattern

### Çalışma Mantığı
Abstract Factory tasarım deseni factory deseni ile benzer özelliklere sahiptir. Factory'den farkı tek bir ara yüzden değil, her ürün ailesi için farklı bir ara yüzden nesne oluşturmasıdır. Nesne oluşumunu ara yüzler üzerinden gerçekleştirdiği için çok esnek ve genişletilebilir yapıya sahiptir. Abstract factory tasarım deseni, somut ürün oluşturucu sınıf üzerinden alt sınıfları oluşturur. İstemci, hiçbir şekilde somut sınıfları bilmez. Soyut sınıflar üzerinden tür dönüşümleri ile nesneleri oluşturur. Bu sayede factory desenindeki if-switch gibi hangi nesnenin üretileceğine karar verecek bir yapıya da gerek kalmaz. Bütün nesne oluşturma işlemi ara yüzler üzerinden gerçekleşir.

### Ne zaman kullanılır?

Birden fazla ürün ailesi ile çalışmak durumunda kaldığınızda, kullanacağınız ürün ailesi ile istemci tarafı soyutlamak için Abstract Factory kullanılır. Bir başka kullanım amacı ise, factory deseni kullandığımızda oluşturucu sınıfın içerisine if-else blokları yazarız. Bu if blokları ile hangi ürünün oluşturacağına karar veririz. Bu if-else bloklarını yazmak istemiyorsak abstrac factory tasarım kalıbını kullanabiliriz.

### Örnek

Bir yazılım projesi yapmak istediğimizi düşünün. Dinamik ekran oluşturan bir proje yapacağız. Kullanıcı hiç kod yazmadan ve bu ekranı daha sonra kullanabileceğimiz bir web sitesi yapalım. Yani bir panel var ve bir kullanıcının bu panel yardımı ile ekranlar oluşturacağı bizim geliştireceğimiz web sitesi ile de bunun gösterileceği. Uygulama sadece webte çalışmayacak. İleride istek gelirse başka ortamlarda da çalışacak şekilde ayarlanacak.
