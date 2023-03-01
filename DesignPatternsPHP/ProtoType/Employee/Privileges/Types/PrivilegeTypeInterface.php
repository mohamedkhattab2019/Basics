<?php

namespace DesignPatternsPHP\ProtoType\Employee\Privileges\Types;

interface PrivilegeTypeInterface
{
    public function enable():bool;
    public function disable():bool;
}
