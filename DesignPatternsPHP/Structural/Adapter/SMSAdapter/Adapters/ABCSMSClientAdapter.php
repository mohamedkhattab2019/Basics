<?php

namespace DesignPatternsPHP\Structural\Adapter\SMSAdapter\Adapters;
use DesignPatternsPHP\Structural\Adapter\SMSAdapter\Adapters\ABCSMSManager\SMSManager;
use DesignPatternsPHP\Structural\Adapter\SMSAdapter\Messages\Message;
use DesignPatternsPHP\Structural\Adapter\SMSAdapter\SMSClient;
use DesignPatternsPHP\Structural\Adapter\SMSAdapter\SMSDeliveryStatus;

class ABCSMSClientAdapter extends SMSClient
{

    // the third party service to be adapted with the interface
    private ?SMSManager $manager =null;


    public function __construct(array $messages = []){
        parent::__construct($messages);
        $this->manager = new SMSManager();
    }

	/**
	 * @return bool
	 */
	public function filterNumbers(): bool {
        $this->messages = array_filter(
            $this->messages,
            fn(Message $message) => $this->manager->ValidatePhoneNumber($message->getNumber())
        );

        return !empty($this->messages);
	}
	
	/**
	 * @return bool
	 */
	public function send(): bool {
		if ($this->filterNumbers()) {
                $this->manager->send(
                    array_map(function(Message $message):array{
                        return [
                            'number' => $message->getNumber(),
                            'text' => $message->getMessage()
                        ];
                    },$this->messages)
                );
		}

		return $this->getDeliveryStatus() === SMSDeliveryStatus::SENT ;
	}
	
	/**
	 * @return string
	 */
	public function getDeliveryStatus(): string {
        return $this->manager->getDeliveryStatus() - 4 ; // to map  4-8 to 1-4 
	}

    
}
