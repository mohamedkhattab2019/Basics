<?php

namespace DesignPatternsPHP\ProtoType\Employee;

class Address
{
    private float $longitude;
    private float $latitude;

    private string $street;

    private string $city;
    private string $state;

    private string $zip;

    // public Address(float longitude, float latitude, string street, string city, string state, string zip)

    /**
     */
    public function __construct(float $longitude, float $latitude, string $street, string $city, string $state, string $zip) {
        $this->longitude =$longitude;
        $this->latitude =$latitude;
        $this->street =$street;
        $this->city =$city;
        $this->state =$state;
        $this->zip =$zip;
        
    }


	/**
	 * @return float
	 */
	public function getLongitude(): float {
		return $this->longitude;
	}


	/**
	 * @return float
	 */
	public function getLatitude(): float {
		return $this->latitude;
	}

	/**
	 * @return string
	 */
	public function getCity(): string {
		return $this->city;
	}

	/**
	 * @return string
	 */
	public function getState(): string {
		return $this->state;
	}

	/**
	 * @return string
	 */
	public function getZip(): string {
		return $this->zip;
	}
}
