
int SensorPin = A0;
float SensorValue = 0; // Pure data by Sensor in ANALOG PIN 0
double Temperature = 0;

void setup()
{
	Serial.begin(9600);
	pinMode(SensorPin, INPUT);
}

void loop()
{
	SensorValue = analogRead(SensorPin);
	Temperature = (SensorValue * 500) / 1023; // Obtains Temperature in Celsius.
	
	//Serial.println(SensorValue);
	Serial.println(Temperature);
	delay(500);
}
