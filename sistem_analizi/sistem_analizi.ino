#include <Wire.h>
#include <FaBoLCD_PCF8574.h>
#include <DHT.h>
#include <DHT_U.h>
#define DHTPIN 2
#define DHTTYPE DHT11

DHT dht(DHTPIN, DHTTYPE);
FaBoLCD_PCF8574 lcd;

int buzzerPin = 13;
int ldr = 0;

void setup() {
  // put your setup code here, to run once:
  pinMode(11, OUTPUT);
  pinMode(9, OUTPUT);
  pinMode(10, OUTPUT);
  pinMode(buzzerPin, OUTPUT);//Lcd ekran, ısı ve nem ölçer, led, ldr ve buzzer'ın pinlerini tanımlayarak output olarak ayarladık
  Serial.begin(9600);//Seri haberleşme hızını ayarlıyoruz

  lcd.begin(16, 2);
  lcd.print("Hosgeldiniz!");//Ekrana Hoşgeldiniz yazısıyla birlikte buzzerpin'i çalıştırdık.
  delay(1000);
  digitalWrite(buzzerPin, HIGH);
  delay(1000);
  digitalWrite(buzzerPin, LOW);
  dht.begin();

}

void loop() {//ısı ve nem ölçerden gelen verileri okuyup ekrana yazdırdık.
  int temp = dht.readTemperature();
  int hum = dht.readHumidity();
  lcd.clear();

  lcd.setCursor(0, 0);
  lcd.print("Sicaklik: ");
  lcd.print(temp);
  lcd.print(" C");

  lcd.setCursor(0, 1);
  lcd.print("Nem: %");
  lcd.print(hum);
  delay(5000);
  lcd.clear();


  // put your main code here, to run repeatedly:
  int deger = analogRead(ldr); //ldr'den gelen değeri oku
  Serial.println(deger); //değeri seri port ekranına yaz
  delay(2000);
//ldr den gelen veriyi okuyarak ışık değeri olarak ekrana yazdırıyoruz.
  lcd.setCursor(0, 0);
  lcd.print("Isik Degeri: ");
  lcd.print(deger);
  delay(5000);
  lcd.clear();

  if (deger < 15) //değer 15'den küçükse ledleri yakıyoruz.
  {
    lcd.setCursor(0, 0);
    lcd.print("Hava : Karanlik");
    lcd.setCursor(0, 1);
    lcd.print("Ledler Acildi! ");
    delay(1000);
    digitalWrite(buzzerPin, HIGH);
    delay(1000);
    digitalWrite(buzzerPin, LOW);

    digitalWrite(11, HIGH);
    digitalWrite(9, LOW);
    digitalWrite(10, LOW);
    delay(200);

    digitalWrite(11, LOW);
    digitalWrite(9, HIGH);
    digitalWrite(10, LOW);
    delay(200);

    digitalWrite(11, LOW);
    digitalWrite(9, LOW);
    digitalWrite(10, HIGH);
    delay(200);

    digitalWrite(11, HIGH);
    digitalWrite(9, LOW);
    digitalWrite(10, HIGH);
    delay(200);

    digitalWrite(11, HIGH);
    digitalWrite(9, HIGH);
    digitalWrite(10, LOW);
    delay(200);

    digitalWrite(11, LOW);
    digitalWrite(9, HIGH);
    digitalWrite(10, HIGH);
    delay(200);
  }

  else if (deger > 20 ) //ışık değeri 20den büyükse ledleri kapatıyoruz.
  {
    lcd.setCursor(0, 0);
    lcd.print("Hava : Aydinlik");
    lcd.setCursor(0, 1);
    lcd.print("Ledler Kapali! ");
    delay(2000);

    digitalWrite(11, LOW);
    digitalWrite(9, LOW);
    digitalWrite(10, LOW);
  }
}
