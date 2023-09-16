const int BuiltInArduinoPin = 13;
int LEDState = 0;

void setup(){
  
  pinMode(BuiltInArduinoPin, OUTPUT);
  Serial.begin(9600);
  
}

void loop(){
  
  char receiveVal;
  if(Serial.available() > 0){
    
    receiveVal = Serial.read();
    
    if(receiveVal == '1'){
      
      LEDState = 1;
      
    }
    else{
      
      LEDState = 0;
      
    }
    
  }
  
  digitalWrite(BuiltInArduinoPin, LEDState);
  delay(50);
  
}
