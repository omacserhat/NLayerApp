# NLayerApp

## Proje 3 Katmanlıdır.( Core-Repository-Service )

## Core Katmanı
- Model(Entity)
- DTOs
- Repository Interfaces
- Service Interfaces
- UnitOfWork Interfaces (Design Pattern) bulunuyor. 
- (Birden fazla repository içerisinde yapılan tüm işlemleri tek bir transaction'da veri tabanına yansıtmak, herhangi bir hata durumunda ise tüm repositorydeki yapılan değişiklikleri geri almak. )

## Repository Katmanı ( Core katmanını referans alıyor. )
- Migrations 
- Seeds ( Veri Tabanına default datalar atılmasını istiyorsak kullanıyoruz. )
- Repository Impl ( Core katmanındaki interfaces'in implementesini bu katmanda yapıyoruz. )
- UnitOfWork Impl ( Core katmanındaki interfaces'in implementesini bu katmanda yapıyoruz. )


## Service Katmanı (Business ile ilgili yerler) Repository katmanını referans alıyor.
- Mapping ( almış olduğumuz entityleri herhangi bir dto nesnelerine veya herhangi bir classa maplemek için kullanacağımız dosya )
- Service Impl
- Validations
- Exceptions

## Caching ( Dataların cachlenmesi. ) Daha performanslı bir uygulama inşa etmek için kullanacağız.
