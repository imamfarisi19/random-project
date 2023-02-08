<?php

namespace App\Http\Controllers;

use Illuminate\Auth\Events\Login;
use Illuminate\Http\Request;
use Illuminate\Support\Facades\Auth;
use App\Models\User;
use Illuminate\Support\Str;

class LoginController extends Controller
{
    public function halamanLogin(){
        return view('Login.Login-aplikasi');
    }

    public function postLogin(Request $request){
        if(Auth::attempt($request->only('email','password'))){
            return redirect('/home');
        }
        return redirect('/');
    }

    public function logout(Request $request){
        Auth::logout();
        return redirect('/');
    }
    
    public function registrasi(){
        return view('Login.registrasi');
    }

    public function simpanregistrasi(Request $request){
        //dd($request->all());

        User::create([
            'name'=>$request->name,
            'level'=> 'karyawan',
            'email'=> $request->email,
            'password' => bcrypt($request->password),
            'remember_token' => Str::random(60),
        ]);
        return view('welcome');
    }
}
