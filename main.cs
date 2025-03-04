/*
created by: Brennan Lee
created on: Mar 3, 2025

turns an LED on for one second, then off for one second, repeatedly.
*/
const int PIN_11 = 11;
const int PIN_12 = 12;
const int PIN_13 = 13;

void setup()
{
    pinMode(PIN_11, OUTPUT) ;
    pinMode(PIN_12, OUTPUT) ;
    pinMode(PIN_13, OUTPUT) ;
}

void loop()
{
    digitalWrite(PIN_11,HIGH) ;
    digitalWrite(PIN_12,LOW) ;
    digitalWrite(PIN_13,LOW) ;
    delay(1000) ; //wait for 1000 milliseconds
    digitalWrite(PIN_11,LOW) ;
    digitalWrite(PIN_12,HIGH) ;
    digitalWrite(PIN_13,LOW) ;
    delay(1000) ; //wait for 1000 milliseconds
    digitalWrite(PIN_11,LOW) ;
    digitalWrite(PIN_12,LOW) ;
    digitalWrite(PIN_13,HIGH) ;
    delay(1000) ; //wait for 1000 milliseconds
    digitalWrite(PIN_11,HIGH) ;
    digitalWrite(PIN_12,HIGH) ;
    digitalWrite(PIN_13,LOW) ;
    delay(1000) ; //wait for 1000 milliseconds
    digitalWrite(PIN_11,LOW) ;
    digitalWrite(PIN_12,HIGH) ;
    digitalWrite(PIN_13,HIGH) ;
    delay(1000) ; //wait for 1000 milliseconds
    digitalWrite(PIN_11,HIGH) ;
    digitalWrite(PIN_12,LOW) ;
    digitalWrite(PIN_13,HIGH) ;
    delay(1000) ; //wait for 1000 milliseconds
    digitalWrite(PIN_11,LOW) ;
    digitalWrite(PIN_12,LOW) ;
    digitalWrite(PIN_13,LOW) ;
    delay(1000) ; //wait for 1000 milliseconds
}