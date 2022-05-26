<?php

namespace App\Services;

class MyService
{
    public function __construct($param, $email, $globalParam, MySecondService $secondService)
    {
        dump($param);
        dump($email);
        dump($globalParam);
    }

    /**
     * @required
     * @param MySecondService $secondService
     */
    public function setSecondService(MySecondService $secondService) //Setter injection
    {
        dump('AAAA Second Service');
    }
}

