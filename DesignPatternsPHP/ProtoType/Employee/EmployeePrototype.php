<?php

// namespace DesignPatternsPHP\protoType\Employee;

// interface  Prototype
// {
//     public function clone();
// }
namespace DesignPatternsPHP\ProtoType\Employee;
use DesignPatternsPHP\ProtoType\Employee\Privileges\Privileges;
use DesignPatternsPHP\ProtoType\Employee\Privileges\Types\ServerRoomPrivilege;
use DesignPatternsPHP\ProtoType\Employee\Privileges\Types\WebProjectPrivilege;

interface  ProtoType
{
    public function __clone();
}

class EmployeePrototype implements ProtoType{
    private ProfileData $profileData;

    private Salary $salary;

    private Privileges $privileges;

    /**
     * @param ProfileData $profileData
     * @param Salary $salary
     * @param Privileges $privileges
     */
    public function __construct(ProfileData $profileData, Salary $salary, Privileges $privileges) {
    	$this->profileData = $profileData;
    	$this->salary = $salary;
    	$this->privileges = $privileges;
    }
	/**
	 * @return mixed
	 */
	public function __clone() {
        $this->privileges->clearPrivilege();
        $this->privileges->addPrivilege(new WebProjectPrivilege);
        $this->privileges->addPrivilege(new ServerRoomPrivilege);

        $this->salary->setTax(0.1);
        $this->salary->setSalary(1500);
        $this->salary->setMedicalInsurance(200);

        $this->profileData->setAddress(null);
        $this->profileData->setAge(20);
        $this->profileData->setMobileNumber(0);
        $this->profileData->setSlackAccountName('slack.account');
        $this->profileData->setName('Default Employee Name');
        
        return $this;
	}

	/**
	 * @return Privileges
	 */
	public function getPrivileges(): Privileges {
		return $this->privileges;
	}
}

// $mohamed = new EmployeePrototype(
//     new ProfileData("mohamed khattab" , 27,
//         new Address(
//             50.5,
//             80.6,
//             "Al Azhar street",
//             "cairo",
//             "Egypt",
//             "mkhattab@c3s.co",
//         ),
//         "01127573674",
//         "mkhattab@c3s.co"
//     ),
//     new Salary(
//         5000.0,
//         0.23,
//         300
//     ),
//     new Privileges(
//         [
//             new WebProjectPrivilege(),
//             new ServerRoomPrivilege()
//         ]
//     )

// );
// var_dump($mohamed);
// // $ahmed = clone $mohamed;
// // var_dump($ahmed);
