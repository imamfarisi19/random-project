<?php

namespace Database\Seeders;

use Illuminate\Database\Seeder;
use Illuminate\Support\Str;
use App\Models\User;

class UserSeeder extends Seeder
{
    /**
     * Run the database seeds.
     *
     * @return void
     */ 
    public function run() 
    { 
        User::truncate(); 
        User::create([ 
            'name' => 'Imam Farisi', 
            'level' => 'user', 
            'email' => 'user123@user.com', 
            'password' => bcrypt('user'), 
            'remember_token' => Str::random(60), 
        ]); 
    } 
} 
