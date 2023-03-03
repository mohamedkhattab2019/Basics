<?php

namespace  DesignPatternsPHP\Structural\Adapter\SMSAdapter;
use DesignPatternsPHP\Structural\Adapter\SMSAdapter\Messages\Message;

class MonkeySMSClient extends SMSClient
{
	/**
	 * @return bool
	 */
	public function filterNumbers(): bool {
		$this->messages = array_filter($this->messages,fn (Message $message)=>$message->validateNumber());

		return !empty($this->messages);
	}
	
	/**
	 * @return bool
	 */
	public function send(): bool {
		if ($this->filterNumbers()) {
			foreach ($this->messages as $message) {
				$this->deliveryStatus = rand(1,4);

				echo "Message Is bing sent '{$message->getMessage()}'\n";
			}
		}

		return $this->getDeliveryStatus() === SMSDeliveryStatus::SENT ;
	}
	
	/**
	 * @return string
	 */
	public function getDeliveryStatus(): string {

		return $this->deliveryStatus;
	}

}
