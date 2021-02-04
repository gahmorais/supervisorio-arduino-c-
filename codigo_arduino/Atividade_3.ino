#define MOTOR1 13
#define VALVULA1 12
#define VALVULA2 11
#define VALVULA3 10

int AN0; 
int AN1;
int AN2; 
int AN3;
int valv1sp;
int valv2sp;
int valv3sp;
boolean start;
int AN4;

char str_dados[40];
char Rx;
String Rx1;
boolean EM = true;
boolean ST = true;
void Config_Placa()
{
  pinMode(MOTOR1, OUTPUT);
  pinMode(VALVULA1, OUTPUT);
  pinMode(VALVULA2, OUTPUT);
  pinMode(VALVULA3, OUTPUT);
  Serial.begin(9600);
  pinMode(A0, INPUT);
  pinMode(A1, INPUT);
  pinMode(A2, INPUT);
  pinMode(A3, INPUT);
}


void ControlePlanta()
{
  if(Serial.available() > 0)
  {
    Rx1 = Serial.readStringUntil('\r');// lendo protocolo
    Rx = Serial.read();
    if(Rx1 == "[MOTOR1ON]"){digitalWrite(MOTOR1,1);} 
    if(Rx1 == "[MOTOR1OFF]"){digitalWrite(MOTOR1,0);} 
    if(Rx1 == "[VAL1ON]"){digitalWrite(VALVULA1,1);} 
    if(Rx1 == "[VAL1OFF]"){digitalWrite(VALVULA1,0);} 
    if(Rx1 == "01304030"){valv1sp = 308; valv2sp = 410; valv3sp = 308;start = true;}
    if(Rx1 == "01403030"){valv1sp = 410; valv2sp = 308; valv3sp = 308;start = true;}
    if(Rx1 == "01303040"){valv1sp = 308; valv2sp = 308; valv3sp = 410;start = true;}

    
    switch(Rx)
    {
      case 'A':
      ST = true;
      break;
      case 'B':
      ST = false;
      break;
    }
    
  }
  if(start == true)
    {
      if(AN4 <= 3){        
      if(AN0 <= valv1sp){digitalWrite(VALVULA1,1);digitalWrite(VALVULA3,0);digitalWrite(VALVULA2,0);AN4=1;} 
      else {digitalWrite(VALVULA1,0);
      if(AN0 <= (valv1sp+valv2sp)){digitalWrite(VALVULA2,1);digitalWrite(VALVULA3,0);digitalWrite(VALVULA1,0);AN4=2;}
      else {digitalWrite(VALVULA2,0);
      if(AN0 <= 1020 ){digitalWrite(VALVULA3,1);digitalWrite(VALVULA1,0);digitalWrite(VALVULA2,0);AN4=3; }
      else {digitalWrite(VALVULA3,0);digitalWrite(VALVULA2,0);digitalWrite(MOTOR1,1);AN4=4; }
      }
      }
      }
    else
    {if(AN0 <= 1 ){digitalWrite(MOTOR1,0);start = false;AN4=0;}}
    }
    else{AN4=0;}
    
  if(ST == true)
  {
    AN0 = analogRead(0);
    AN1 = analogRead(1);
    AN2 = analogRead(2);
    AN3 = analogRead(3);
    sprintf(str_dados,"%4d%4d%4d%4d%4d",AN0,AN1,AN2,AN3,AN4);
    Serial.println(str_dados);
    delay(100);  

  }
}


void setup() 
{
 Config_Placa();
}

void loop() 
{
  ControlePlanta();
}
