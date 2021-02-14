/* References used in program development */

/***************************************************************************************
*    Title: Control stepper motor driver DRV8825 with arduino 
*    Author: unknown
*    Date: 13.07.2020
*    Code version: unknown
*    Modified: Yes
*    Availability: https://lastminuteengineers.com/drv8825-stepper-motor-driver-arduino-tutorial/
***************************************************************************************/

/***************************************************************************************
*    Title: Exit from loop
*    Author: User on forum.arduino.cc website with nickname "uobstudent"
*    Date: 14.07.2020
*    Code version: unknown
*    Modified: Yes
*    Availability: https://forum.arduino.cc/index.php?topic=222433.0
***************************************************************************************/

/***************************************************************************************
*    Title: Connect and read data from serial port
*    Author: User on forum.arduino.cc website with nickname "CrossRoads"
*    Date: 16.07.2020
*    Code version: unknown
*    Modified: Yes
*    Availability: https://forum.arduino.cc/index.php?topic=168673.0
***************************************************************************************/

/***************************************************************************************
*    Title: Read numerical values from serial port
*    Author: unknown
*    Date: 18.07.2020
*    Code version: unknown
*    Modified: Yes
*    Availability: https://learn.adafruit.com/adafruit-arduino-lesson-13-dc-motors/arduino-code
***************************************************************************************/

int minimumRevolutions = 499;
int pulseDelay = 1000;
unsigned long revolutions = 0;
int dirPin = 5;
int stepPin = 3;
int data;

void setup()
{  
	Serial.begin(9600);  
	pinMode(directionPin, OUTPUT);
	pinMode(stepPin, OUTPUT);
	digitalWrite(dirPin, HIGH);
}  

void loop() 
{  
	if (Serial.available()) 
	{  
		data = Serial.read();
		if (data == 'A') 
		{  
			while(1)
			{
				if (Serial.read() == 'B') break;
				digitalWrite(stepPin, HIGH);
				delayMicroseconds(pulseDelay);
				digitalWrite(stepPin, LOW);
				delayMicroseconds(pulseDelay);
			}
		}	
		if (data == 'C') 
		{
			revolutions = Serial.parseInt();
			if (revolutions > minimumRevolutions)
			{
				for(int x = 0; x < revolutions; x++)
				{
					if (Serial.read() == 'D') break;
					digitalWrite(stepPin, HIGH);
					delayMicroseconds(pulseDelay);
					digitalWrite(stepPin, LOW);
					delayMicroseconds(pulseDelay);
				}
				Serial.write('E');
			}
		}
	}
}