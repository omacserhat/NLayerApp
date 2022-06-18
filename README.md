# NLayerApp

Core-Repository-Service

Core katmanında 
Model(Entity)
DTOs
Repository Interfaces
Service Interfaces
UnitOfWork Interfaces (Design Pattern) bulunuyor. 
(Birden fazla repository içerisinde yapılan tüm işlemleri tek bir transaction'da veri tabanına yansıtmak, herhangi bir hata durumunda ise tüm repositorydeki yapılan değişiklikleri geri almak. )

Repository () Core katmanını referans alacak 
Migrations 
Seeds ( Veri Tabanına default datalar atılmasını istiyorsak kullanıyoruz. )
Repository Impl ( Core katmanındaki interfaces'in implementesini bu katmanda yapıyoruz. )
UnitOfWork Impl ( Core katmanındaki interfaces'in implementesini bu katmanda yapıyoruz. )


Service ( Business ile ilgili yerler )Repository katmanını referans alacak
Mapping ( almış olduğumuz entityleri herhangi bir dto nesnelerine veya herhangi bir classa maplemek için kullanacağımız dosya )
Service Impl
Validations
Exceptions

Caching ( Dataların cachlenmesi. ) Daha performanslı bir uygulama inşa etmek için kullanacağız.
