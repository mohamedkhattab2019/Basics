<?php

namespace DesignPatternsPHP\ProtoType\Employee;

class Salary
{
    private float    $salary;
    private float   $tax;
    private float   $medicalInsurance;

    


    /**
     * @param float $salary
     * @param float $tax
     * @param float $medicalInsurance
     */
    public function __construct(float $salary, float $tax, float $medicalInsurance) {
    	$this->salary = $salary;
    	$this->tax = $tax;
    	$this->medicalInsurance = $medicalInsurance;
    }
    

	/**
	 * @return float
	 */
	public function getSalary(): float {
		return $this->salary;
	}

	/**
	 * @return float
	 */
	public function getTax(): float {
		return $this->tax;
	}

	/**
	 * @return float
	 */
	public function getMedicalInsurance(): float {
		return $this->medicalInsurance;
	}

	/**
	 * @param float $salary 
	 * @return self
	 */
	public function setSalary(float $salary): self {
		$this->salary = $salary;
		return $this;
	}

	/**
	 * @param float $tax 
	 * @return self
	 */
	public function setTax(float $tax): self {
		$this->tax = $tax;
		return $this;
	}

	/**
	 * @param float $medicalInsurance 
	 * @return self
	 */
	public function setMedicalInsurance(float $medicalInsurance): self {
		$this->medicalInsurance = $medicalInsurance;
		return $this;
	}
}
