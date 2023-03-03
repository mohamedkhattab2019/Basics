<?php

namespace DesignPatternsPHP\Structural\Adapter\SMSAdapter\Adapters\ABCSMSManager;

class SMSManager
{
    public function send(array $messages){
        // this is how u send a message;
        if ($this->checkConnection() && $this->Authenticate() && $this->connect() ) {
            foreach ($messages as $message) {

				echo "Your Message '{$message['text']}' Is bing sent to '{$message['number']}'\n";
			}
        }

    }
    public function connect():bool{
    
        return true;
    }
    public  function checkConnection():bool{
        
        return true;
    }
    public function Authenticate():bool{

        return true;
    }

    public function ValidatePhoneNumber(string $phoneNumber):bool{

        return strlen($phoneNumber) < 8 ;
    }    

    public function getDeliveryStatus():string{
        return rand(5,8);
    }

}
