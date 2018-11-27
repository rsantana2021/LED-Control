const int ledPin = 2; //LED pin on Arduino Nano

void setup(){
  Serial.begin(9600);
  pinMode(ledPin, OUTPUT);
}

void loop(){
  String messageSent; //Incoming C# string of characters
  String message; //We are using this string to concatinate the string of characters that is being sent through serial communiccation

  while (Serial.available()){
    
    delay(1); //wait 1 millisecond before executing code again

    if (Serial.available() > 0){ //if serial information is anything greater than nothing
      char incomingLetters = Serial.read(); //assign whatever the serial message to a character C

      if (isControl(incomingLetters)){
        break; //if Serial.read() returns a control character
      }
      messageSent += incomingLetters; //takes in a byte at a time and concatinates them
    }
  }
  
  message = messageSent; //Set the concatinated C# message to a string varialble called message

  if (message == "on")
    digitalWrite(ledPin, HIGH);
  else if (message == "off")
    digitalWrite(ledPin, LOW);
}
