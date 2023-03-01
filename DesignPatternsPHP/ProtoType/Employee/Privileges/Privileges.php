<?php

namespace DesignPatternsPHP\ProtoType\Employee\Privileges;
use DesignPatternsPHP\ProtoType\Employee\Privileges\Types\PrivilegeTypeInterface;

class Privileges
{
    private array $privileges;

    /**
     * @param array $privileges
     */
    public function __construct(array $privileges) {
    	$this->privileges = $privileges;
    }

    public function addPrivilege(PrivilegeTypeInterface $privilege){
        $this->privileges[] = $privilege;
    }

    public function clearPrivilege(){
        $this->privileges = [];
    }
}
