<?php

use Illuminate\Database\Migrations\Migration;
use Illuminate\Database\Schema\Blueprint;
use Illuminate\Support\Facades\Schema;

class CreateUsersTable extends Migration
{
    /**
     * Run the migrations.
     *
     * @return void
     */
    public function up()
    {
        Schema::create('user', function (Blueprint $table) { 
            $table->increments('id')->id('id')->unique(); 
            $table->string('userName',50); 
            $table->string('password',50); 
            $table->string('wewenang',50); 
            $table->string('email'); 
            $table->timestamp('emailVerifiedAt')->nullable(); 
            $table->rememberToken(); 
            $table->timestamps(); 
        }); 

        Schema::create('mahasiswa', function (Blueprint $table) { 
            $table->id('id')->unique(); 
            $table->string('nama'); 
            $table->string('nim'); 
            $table->date('tanggalLahir'); 
            $table->string('email'); 
            $table->timestamp('email_verified_at')->nullable(); 
            $table->string('password'); 
            $table->rememberToken(); 
            $table->timestamps(); 
        }); 
        
        Schema::create('prodi', function (Blueprint $table) { 
            $table->id('id')->unique(); 
            $table->string('nama',13); 
            $table->string('fakultasId',50); 
        }); 

        Schema::create('fakultas', function (Blueprint $table) { 
            $table->id('id')->unique(); 
            $table->string('nama',30); 
        }); 

        Schema::create('voting', function (Blueprint $table) { 
            $table->id('id')->unique(); 
            $table->timestamp('waktuVoteAt'); 
            $table->foreign('kandidatId')->references('id')->on('kandidat'); 
            $table->foreign('mahasiswaId')->references('id')->on('mahasiswa'); 
            $table->data('TanggalLahir'); 
            $table->string('HasilAkhir'); 
        }); 

        Schema::create('kandidat', function (Blueprint $table) { 
            $table->id('id')->unique(); 
            $table->string('nama',30); 
            $table->string('TotalSuara',50); 
        });

    }

    /**
     * Reverse the migrations.
     *
     * @return void
     */
    public function down()
    {
        Schema::dropIfExists('user'); 
        Schema::dropIfExists('mahasiswa'); 
        Schema::dropIfExists('prodi'); 
        Schema::dropIfExists('fakultas'); 
        Schema::dropIfExists('voting'); 
        Schema::dropIfExists('kandidat'); 
    }
}
