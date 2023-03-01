<?php

namespace DesignPatternsPHP\ProtoType\Employee;

class ProfileData
{
    private string $name;
    private int $age;
    private ?Address $address;
    private string $mobileNumber;
    private string $slackAccountName;
    // public ProfileData(int age, Address address, PhoneNumber phone)

    /**
     * @param string $name
     * @param int $age
     * @param Address|null $address
     * @param string $mobileNumber
     * @param string $slackAccountName
     */
    public function __construct(string $name, int $age, ?Address $address, string $mobileNumber, string $slackAccountName) {
    	$this->name = $name;
    	$this->age = $age;
    	$this->address = $address;
    	$this->mobileNumber = $mobileNumber;
    	$this->slackAccountName = $slackAccountName;
    }

	/**
	 * @return Address
	 */
	public function getAddress(): Address {
		return $this->address;
	}

	/**
	 * @return string
	 */
	public function getMobileNumber(): string {
		return $this->mobileNumber;
	}

	/**
	 * @return string
	 */
	public function getSlackAccountName(): string {
		return $this->slackAccountName;
	}
    

	/**
	 * @param int $age 
	 * @return self
	 */
	public function setAge(int $age): self {
		$this->age = $age;
		return $this;
	}

	/**
	 * @param Address|null $address 
	 * @return self
	 */
	public function setAddress(?Address $address): self {
		$this->address = $address;
		return $this;
	}

	/**
	 * @param string $mobileNumber 
	 * @return self
	 */
	public function setMobileNumber(string $mobileNumber): self {
		$this->mobileNumber = $mobileNumber;
		return $this;
	}

	/**
	 * @param string $slackAccountName 
	 * @return self
	 */
	public function setSlackAccountName(string $slackAccountName): self {
		$this->slackAccountName = $slackAccountName;
		return $this;
	}

	/**
	 * @param string $name 
	 * @return self
	 */
	public function setName(string $name): self {
		$this->name = $name;
		return $this;
	}
}
