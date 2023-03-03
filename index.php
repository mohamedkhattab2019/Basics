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
use DesignPatternsPHP\Structural\Adapter\SMSAdapter\Adapters\ABCSMSClientAdapter;
use DesignPatternsPHP\Structural\Adapter\SMSAdapter\Messages\SMSMessage;
use DesignPatternsPHP\Structural\Adapter\SMSAdapter\MonkeySMSClient;

/**
 * Prototype client
 */
// $mohamed = new EmployeePrototype(
//         new ProfileData("mohamed khattab" , 27,
//             new Address(
//                 50.5,
//                 80.6,
//                 "Al Azhar street",
//                 "cairo",
//                 "Egypt",
//                 "mkhattab@c3s.co",
//             ),
//             "01127573674",
//             "mkhattab@c3s.co"
//         ),
//         new Salary(
//             5000.0,
//             0.23,
//             300
//         ),
//         new Privileges(
//             [
//                 new WebProjectPrivilege(),
//                 new ServerRoomPrivilege()
//             ]
//         )
    
//     );
//     // var_dump($mohamed);
//     $mohamed->getPrivileges()->addPrivilege(new NetworkPrivilege());
//     var_dump($mohamed);

//     $ahmed = clone $mohamed;
//     var_dump($ahmed);

/**
 * Adapter Client
 */

 $message = new SMSMessage("Welcome to Khattab Community","01127573674");
 $message2 = new SMSMessage("Please Join our Community","0113674");
 $message3 = new SMSMessage("Your account has been activated","0119999993674");
 $message4 = new SMSMessage("Thank you for your feed back","012345");

//  $client = new MonkeySMSClient([$message,$message2,$message3,$message4]);

// use adapter sms client
 $client = new ABCSMSClientAdapter([$message,$message2,$message3,$message4]);

 $client->filterNumbers();
 $client->send();
 $client->getDeliveryStatus();

 var_dump($client->getDeliveryStatus());



    