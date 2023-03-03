<?php
namespace DesignPatternsPHP\Structural\Adapter\SMSAdapter\Messages;

interface Message
{
    public function getMessage():string;
    public function getNumber():string;
    public function validateMessage():bool;

    public function validateNumber():bool;
}
