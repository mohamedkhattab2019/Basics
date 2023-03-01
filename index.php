<?php
require_once 'vendor/autoload.php';
use DesignPatternsPHP\ProtoType\Employee\Address;
use DesignPatternsPHP\ProtoType\Employee\EmployeePrototype;
use DesignPatternsPHP\ProtoType\Employee\Privileges\Privileges;
use DesignPatternsPHP\ProtoType\Employee\Privileges\Types\NetworkPrivilege;
use DesignPatternsPHP\ProtoType\Employee\Privileges\Types\ServerRoomPrivilege;
use DesignPatternsPHP\ProtoType\Employee\Privileges\Types\WebProjectPrivilege;
use DesignPatternsPHP\ProtoType\Employee\ProfileData;
use DesignPatternsPHP\ProtoType\Employee\Salary;
$mohamed = new EmployeePrototype(
        new ProfileData("mohamed khattab" , 27,
            new Address(
                50.5,
                80.6,
                "Al Azhar street",
                "cairo",
                "Egypt",
                "mkhattab@c3s.co",
            ),
            "01127573674",
            "mkhattab@c3s.co"
        ),
        new Salary(
            5000.0,
            0.23,
            300
        ),
        new Privileges(
            [
                new WebProjectPrivilege(),
                new ServerRoomPrivilege()
            ]
        )
    
    );
    // var_dump($mohamed);
    $mohamed->getPrivileges()->addPrivilege(new NetworkPrivilege());
    var_dump($mohamed);

    $ahmed = clone $mohamed;
    var_dump($ahmed);
    