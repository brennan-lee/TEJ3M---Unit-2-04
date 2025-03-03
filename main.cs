/*
created by: Brennan Lee
created on: Mar 3, 2025

turns an LED on for one second, then off for one second, repeatedly.
*/

void setup()
{
    pinMode(11, OUTPUT) ;
    pinMode(12, OUTPUT) ;
    pinMode(13, OUTPUT) ;
}

void loop()
{
    digitalWrite(11,HIGH) ;
    digitalWrite(12,LOW) ;
    digitalWrite(13,LOW) ;
    delay(1000) ; //wait for 1000 milliseconds
    digitalWrite(11,LOW) ;
    digitalWrite(12,HIGH) ;
    digitalWrite(13,LOW) ;
    delay(1000) ; //wait for 1000 milliseconds
    digitalWrite(11,LOW) ;
    digitalWrite(12,LOW) ;
    digitalWrite(13,HIGH) ;
    delay(1000) ; //wait for 1000 milliseconds
}