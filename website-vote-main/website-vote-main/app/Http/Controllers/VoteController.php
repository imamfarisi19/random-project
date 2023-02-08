<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;

class VoteController extends Controller
{
    public function votePage(){
        return view('Vote.vote-page');
    }

    public function voteScore(){

    }
}
