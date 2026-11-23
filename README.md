feito por Ruben e Miguel

codigo do arduino:

#include <Wire.h>
#include <LiquidCrystal_I2C.h>

// LCD 16x2 I2C
LiquidCrystal_I2C lcd(0x27, 16, 2);

// Sensor ultrassonico
const int trigPin = 9;
const int echoPin = 10;

long duracao;
float distancia;

void setup()
{
    pinMode(trigPin, OUTPUT);
    pinMode(echoPin, INPUT);

    // Comunicacao com o computador
    Serial.begin(9600);

    // Inicializar LCD
    lcd.init();
    lcd.backlight();

    lcd.setCursor(0, 0);
    lcd.print("MEDIDOR DIST.");
    lcd.setCursor(0, 1);
    lcd.print("A iniciar...");
    
    delay(2000);
    lcd.clear();
}

void loop()
{
    // Enviar impulso ultrassonico
    digitalWrite(trigPin, LOW);
    delayMicroseconds(2);

    digitalWrite(trigPin, HIGH);
    delayMicroseconds(10);

    digitalWrite(trigPin, LOW);

    // Receber resposta
    duracao = pulseIn(echoPin, HIGH, 30000);

    if (duracao == 0)
    {
        lcd.setCursor(0, 0);
        lcd.print("Sem deteccao   ");
        lcd.setCursor(0, 1);
        lcd.print("                ");

        Serial.println("ERRO");
    }
    else
    {
        // Calcular distancia em cm
        distancia = duracao * 0.0343 / 2;

        // Mostrar no LCD
        lcd.setCursor(0, 0);
        lcd.print("Distancia:");

        lcd.setCursor(0, 1);
        lcd.print(distancia, 1);
        lcd.print(" cm          ");

        // Enviar para o Visual Studio
        Serial.println(distancia, 1);
    }

    delay(500);
}
