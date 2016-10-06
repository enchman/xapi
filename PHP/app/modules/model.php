<?php

namespace App\Modules;

interface IModule
{
    function Run();
}

abstract class Module implements IModule
{
    public function Run() {
        
    }
}