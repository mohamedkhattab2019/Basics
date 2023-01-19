<?php
namespace RefactoringGuru\FactoryMethod\RealWorld;

abstract class SocialNetworkPoster
{
    abstract public function getSocialNetwork(): SocialNetworkConnector;

    public function post($content): void{
        $network = $this->getSocialNetwork();
        $network->login();
        $network->createPost($content);
    }
}
class FacebookPoster extends SocialNetworkPoster
{
    private $login, $password;
    
    public function __construct(string $login,string $password){
        $this->login = $login;
        $this->password =$password;
    }
    public function getSocialNetwork(): SocialNetworkConnector
    {
        return new FacebookConnector($this->login, $this->password);
    }
}
class LinkedInPoster extends SocialNetworkPoster
{
    private $email, $password;
    
    public function __construct(string $email,string $password){
        $this->email = $email;
        $this->password =$password;
    }
    public function getSocialNetwork(): SocialNetworkConnector{
        return new LinkedInConnector($this->email, $this->password);
    }
}
interface SocialNetworkConnector
{
    public function logIn(): void;

    public function logOut(): void;

    public function createPost($content): void;
}

class FacebookConnector implements SocialNetworkConnector
{
    private $login, $password;
    
    public function __construct(string $login,string $password){
        $this->login = $login;
        $this->password =$password;
    }
    public function logIn():void{
        echo "Send HTTP API request to log in user $this->login with " .
        "password $this->password\n";
    }

    public function logOut(): void{
        echo "Send HTTP API request to log out user $this->login\n";
    }

    public function createPost($content): void{
        echo "in Facebook post.$content.\n Send HTTP API requests to create a post in Facebook timeline.\n";
    }
}

class LinkedInConnector implements SocialNetworkConnector
{
    private $email, $password;
    
    public function __construct(string $email,string $password){
        $this->$email = $email;
        $this->password =$password;
    }
    public function logIn():void{
        echo "Send HTTP API request to log in user $this->email with " .
        "password $this->password\n";
    }

    public function logOut(): void{
        echo "Send HTTP API request to log out user $this->email\n";
    }

    public function createPost($content): void{
        echo "in LinkedIn post.$content.\n Send HTTP API requests to create a post in LinkedIn timeline.\n";
    }
}

function clientCode(SocialNetworkPoster $creator)
{
    // ...
    $creator->post("Hello world!");
    $creator->post("I had a large hamburger this morning!");
    // ...
}
echo "Testing ConcreteCreator1:\n";
clientCode(new FacebookPoster("mohamedKHATTAB", "F*********"));
echo "\n\n";
echo "Testing ConcreteCreator2:\n";
clientCode(new LinkedInPoster('mkhattab@cs.co', 'LinkedInPass*********'));