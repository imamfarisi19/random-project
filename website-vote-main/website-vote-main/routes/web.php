<?php

use App\Http\Controllers\HomeController;
use App\Http\Controllers\LoginController;
use App\Http\Controllers\ProfileController;
use App\Http\Controllers\VoteController;

use Illuminate\Support\Facades\Route; 
/*
|--------------------------------------------------------------------------
| Web Routes
|--------------------------------------------------------------------------
|
| Here is where you can register web routes for your application. These
| routes are loaded by the RouteServiceProvider within a group which
| contains the "web" middleware group. Now create something great!
|
*/

// Route::get('/', function () {
//     return view('welcome');
// });

Route::get('/', [HomeController::class,'home'])->name('home');
Route::get('/login', [LoginController::class,'halamanlogin'])->name('login');
Route::get('/logout', [LoginController::class,'logout'])->name('logout');
Route::get('/profile',[ProfileController::class,'profilepage'])->name('profilepage');

Route::post('/postlogin', [LoginController::class,'postlogin'])->name('postlogin');
Route::post('/postvote', [VoteController::class,'voteScore'])->name('postvote');

Route::group(['middleware' => ['auth']], function() {
    Route::get('/vote', [VoteController::class,'votePage'])->name('vote');
});