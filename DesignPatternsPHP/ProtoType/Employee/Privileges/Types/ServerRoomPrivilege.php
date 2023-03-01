<?php

namespace DesignPatternsPHP\ProtoType\Employee\Privileges\Types;
// use DesignPatternsPHP\ProtoType\Privileges\Types\TypeInterface;

class ServerRoomPrivilege implements PrivilegeTypeInterface
{
	/**
	 * @return bool
	 */
	public function enable(): bool {

		return true;
	}
	
	/**
	 * @return bool
	 */
	public function disable(): bool {

		return false;
	}
}
