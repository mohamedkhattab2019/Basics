<?php

namespace DesignPatternsPHP\Structural\Adapter\SMSAdapter\Messages;

class SMSMessage implements Message
{
    private string $message;
    private string $number;
    
    /**
     * @param string $message
     * @param string $number
     */
    public function __construct(string $message, string $number) {
        $this->message = $message;
        $this->number = $number;
    }

	/**
	 * @return bool
	 */
	public function validateMessage(): bool {
        return strlen($this->message) < 10;
	}
	
	/**
	 * @return bool
	 */
	public function validateNumber(): bool {
        return strlen($this->number) > 8;

	}

	/**
	 * @return string
	 */
	public function getMessage(): string {
		return $this->message;
	}

	/**
	 * @return string
	 */
	public function getNumber(): string {
		return $this->number;
	}
}
