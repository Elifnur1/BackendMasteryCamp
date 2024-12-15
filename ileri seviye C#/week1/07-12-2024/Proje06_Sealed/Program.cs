sealed class Coupon
{
    //Bu class hiçbir başka class'a miras VEREMESİN!!
    //sealed anahtar kelimesiyle işaretlenen class,miras VEREMEZ!
}

//Örnek hata durumu örneği;
class Product : Coupon
{

}
