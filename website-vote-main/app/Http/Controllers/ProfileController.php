<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;

class ProfileController extends Controller
{
    public function profilepage(){
        return view("Profile-page.profile-page");
    }
}
